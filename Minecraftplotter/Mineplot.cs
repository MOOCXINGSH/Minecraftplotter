using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using BinVox;

namespace MineplotApp
{

    public partial class Mineplot : Form
    {   
        private string directoryName;
        private FileDetail[] fileList;
        private BinVoxModel binVox;

        public Mineplot()
        {
            InitializeComponent();
            directoryName = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
            binvoxDirEntry.SelectedPath = directoryName;
            UpdateFileList();
        }
        
        internal class FileDetail
        {
            public string Display { get; set; }
            public string FullName { get; set; }
        }

        private void UpdateFileList(){
            var dir = new DirectoryInfo(directoryName);
            filesListBox.Items.Clear();

            fileList = (from fi in dir.GetFiles()
                        where fi.Name.EndsWith(".binvox")
                        select new FileDetail
                        {
                            Display = fi.Name,
                            FullName = fi.FullName
                        }).ToArray();
            filesListBox.Items.AddRange(fileList);
        }


        private void Mineplot_Load(object sender, EventArgs e)
        {

        }

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            logBox.Items.Clear();
            FileDetail selectedFile = fileList[filesListBox.SelectedIndex];

            logBox.Items.Add(selectedFile.Display);

            binVox = new BinVoxModel(selectedFile.FullName);

            logBox.Items.Add("depth:" + binVox.getHeader().dims.depth +
                " width:" + binVox.getHeader().dims.width +
                " height:" + binVox.getHeader().dims.height);

            plotButton.Enabled = true;
        }

        private void changeBinvoxDirButton_Click(object sender, EventArgs e)
        {
            if (binvoxDirEntry.ShowDialog() == DialogResult.OK)
            {
                directoryName = binvoxDirEntry.SelectedPath;
                plotButton.Enabled = false;
                UpdateFileList();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void plotButton_Click(object sender, EventArgs e)
        {


            // and window name were obtained using the Spy++ tool.
            IntPtr minecraftHandle = FindWindow(null, minecraftTitle.Text);

            // Verify that Calculator is a running process. 
            if (minecraftHandle == IntPtr.Zero)
            {
                MessageBox.Show("Minecraft with title '" + minecraftTitle.Text + "' not running");
                return;
            }

            SetForegroundWindow(minecraftHandle);
            
            Thread.Sleep(1000);
            
            SendKeys.SendWait("{ESC}");
                    
            while (binVox.HasNext())
            {
                Voxel voxel = binVox.Next();
                
                if (voxel.is_present)
                {
                    // logBox.Items.Add("x:" + voxel.x + " z:" + voxel.z + " y:" + voxel.y + " present: " + voxel.is_present);

                    string cmd = "/setblock ~" + (voxel.x + 2) + " ~" + (voxel.z + 2) + " ~" + (voxel.y + 2) + " minecraft:sandstone 0 destroy";
                    logBox.Items.Add(cmd);


                    SendKeys.SendWait("t");
                    
                    Thread.Sleep(120);
                    

                    
                    string[] keys = cmd.Select(x => x.ToString()).ToArray();

                    for (int i = 0; i < keys.Length; i++)
                    {
                        Thread.Sleep(10);

                        if (keys[i] == "~")
                        {
                            SendKeys.SendWait("{~}");
                        }
                        else
                        {
                            SendKeys.SendWait(keys[i]);
                        }

                    }
                    
                    Thread.Sleep(10);

                    SendKeys.SendWait("{ENTER}");

                    Thread.Sleep(1000);

                }
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
