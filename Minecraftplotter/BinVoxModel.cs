using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinVox
{

    public class Dims
    {
        public Dims(int depth, int height, int width)
        {
            this.depth=depth;
            this.height=height;
            this.width=width;
        }
        
        public int depth { get; set; }
        public int height { get; set; }
        public int width { get; set; }
    }

    public class Translate
    {
        public Translate(float x, float y, float z)
        {
            this.x=x;
            this.y=y;
            this.z=z;
        }
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }

    public class Voxel
    {
        public int x;
        public int y;
        public int z;
        public bool is_present;

        public Voxel(int atx, int atz, int aty, bool present) {
            x = atx;
            y = aty;
            z = atz;
            is_present = present;
        }
    }


    public class LineReader : BinaryReader
    {
        private Encoding _encoding;
        private Decoder _decoder;

        private bool clrf = false;
        
        const int bufferSize = 1024;
        private char[] _LineBuffer = new char[bufferSize];

        public LineReader(Stream stream, Encoding encoding, bool clrf = false)
            : base(stream, encoding)
        {
            this.clrf = clrf; 
            this._encoding = encoding;
            this._decoder = encoding.GetDecoder();
        }

        public string ReadLine()
        {
            int pos = 0;
            
            char[] buf = new char[2];
            
            StringBuilder stringBuffer = null;
            bool lineEndFound = false;

            while(base.Read(buf, 0, 1) > 0)
            {
                if (buf[0] == '\r')
                {
                    // grab buf[0]
                    this._LineBuffer[pos++] = buf[0];
                    if (this.clrf)
                    {// get the '\n'
                        char ch = base.ReadChar();
                        Debug.Assert(ch == '\n');
                    }
                    lineEndFound = true;
                }
                else if (buf[0] == '\n')
                {
                    lineEndFound = true;
                }
                else
                {
                    this._LineBuffer[pos] = buf[0];
                    pos += 1;

                    if (pos >= bufferSize)
                    {
                        stringBuffer = new StringBuilder(bufferSize + 80);
                        stringBuffer.Append(this._LineBuffer, 0, bufferSize);
                        pos = 0;
                    }
                }

                if (lineEndFound)
                {
                    if (stringBuffer == null)
                    {
                        if (pos > 0)
                            return new string(this._LineBuffer, 0, pos);
                        else
                            return string.Empty;
                    }
                    else
                    {
                        if (pos > 0)
                            stringBuffer.Append(this._LineBuffer, 0, pos);
                        return stringBuffer.ToString();
                    }
                }
            }

            if (stringBuffer != null)
            {
                if (pos > 0)
                    stringBuffer.Append(this._LineBuffer, 0, pos);
                return stringBuffer.ToString();
            }
            else
            {
                if (pos > 0)
                    return new string(this._LineBuffer, 0, pos);
                else
                    return null;
            }
        }

    }
    class BinVoxModel
    {
        private LineReader binVoxStream;
        private bool header_read = false;
        private bool voxels_read = false;

        
        private byte[] voxels = new byte[300000];

        private int atx = 0;
        private int atz = 0;
        private int aty = 0;

        private int xmult = 0;
        private int zmult = 0;
        
        public int size = 0;

        public int present_voxels = 0;

        public Dims dims;

        public Translate translate;

        public double scale;

        public BinVoxModel(string fileName, int x=0, int y=0, int z=0)
        {

            atx = x;
            aty = y;
            atz = z;

            if (File.Exists(fileName)) {
               binVoxStream = new LineReader(File.Open(fileName, FileMode.Open), Encoding.UTF8);
            }
            

            this.readHeader();
            try
            {
                this.readVoxels();
            }
            catch (IOException)
            {

            }
            
            binVoxStream.Close();

            xmult = dims.width*dims.height;
            zmult = dims.width;
        }

        public int Index(int x, int z, int y) {
            return x * xmult + z * zmult + y;
        }

        public Voxel getVoxelAt(int x, int z, int y)
        {
            int index = this.Index(x, z, y);
            return new Voxel(x, z, y, voxels[index] == 1);
        }
        public bool HasNext()
        {
            if (atx*atz*aty < size) return true;
            return false;
        }

        public Voxel Next()
        {
            if (aty == dims.height)
            {
                if (atz == dims.width)
                {
                    if (atx < dims.depth) { atx++; atz = 0; }
                }
                else
                {
                    atz++; aty = 0;
                }
            }
            else {
                aty++;
            }
            return getVoxelAt(atx, atz, aty);
        }

        public bool HasPrev()
        {
            if (aty * atz * atx != 0) return true;
            return false;
        }

        public Voxel Prev()
        {
            if (aty == 0)
            {
                if (atz == 0)
                {
                    if (atx > 0) { atx--; atz = dims.width; }
                }
                else
                {
                    atz--; aty = dims.height;
                }
            }
            else {
                aty--;
            }
            return getVoxelAt(atx, atz, aty);
        }
        

        private void readHeader()
        {
            if (!header_read)
            {
                
                bool done=false;
                
                while (!done)
                {
                    string line = binVoxStream.ReadLine();

                    if (line.StartsWith("data"))
                    {
                        done = true;
                        header_read=true;
                    }
                    else if (line.StartsWith("dim")) {
                        string[] dimensions = line.Split(' ');
                        dims = new Dims(
                            int.Parse(dimensions[1]),
                            int.Parse(dimensions[2]),
                            int.Parse(dimensions[3])
                        );

                    }
                    else if (line.StartsWith("translate"))
                    {
                        string[] translations = line.Split(' ');
                        translate = new Translate(
                            float.Parse(translations[1], CultureInfo.InvariantCulture),
                            float.Parse(translations[2], CultureInfo.InvariantCulture),
                            float.Parse(translations[3], CultureInfo.InvariantCulture)
                        );
                    }
                    else if (line.StartsWith("scale")) {
                        string[] scales = line.Split(' ');
                        scale = float.Parse(scales[1], CultureInfo.InvariantCulture);
                    }
                    
                }

            }
        }

        private void readVoxels()
        {
            if (!voxels_read)
            {
                size = dims.depth * dims.height * dims.depth;

                byte value;
                int count;
                int index = 0;
                int end_index = 0;

                while (end_index < size)
                {

                    value = binVoxStream.ReadByte();
                    count = (int)binVoxStream.ReadByte();

                    end_index = index + count;
                    for (int i = index; i < end_index; i++) voxels[i] = value;

                    if (value > 0) present_voxels += count;
                    index = end_index;

                }  // while
                voxels_read = true;
            }

        }
    }
}
