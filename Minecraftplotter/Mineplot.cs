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
        private FileDetail[] fileList;
        private CancellationTokenSource cts;
        private bool plotting = false;

        public Mineplot()
        {
            InitializeComponent();
            if (Properties.Settings.Default.binVoxDir == "")
            {
                Properties.Settings.Default.binVoxDir = new FileInfo(Assembly.GetExecutingAssembly().Location).DirectoryName;
            }
            binvoxDirEntry.SelectedPath = Properties.Settings.Default.binVoxDir;
            UpdateFileList();
        }

        public class ThreadInfo
        {

            public CancellationToken token { get; set; }
            public FileDetail file { get; set; }

            public string minecraftTitle { get; set; }
            
            public int resumefrom { get; set; }
            public int relative_x { get; set; }
            public int relative_y { get; set; }
            public int relative_z { get; set; }

            public ThreadInfo(CancellationToken token, FileDetail file, string minecraftTitle, int resumefrom, int relative_x, int relative_y, int relative_z)
            {
                this.token = token;
                this.file = file;

                this.minecraftTitle = minecraftTitle;
                
                this.resumefrom = resumefrom;
                this.relative_x = relative_x;
                this.relative_y = relative_y;
                this.relative_z = relative_z;
            }
        }

        public class FileDetail
        {
            public string Display { get; set; }
            public string FullName { get; set; }
        }

        private void UpdateFileList()
        {
            var dir = new DirectoryInfo(Properties.Settings.Default.binVoxDir);
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

        // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref RECT lpRect);
        [StructLayout(LayoutKind.Sequential)]
        
        private struct RECT
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }



        private static void plotInThread(object obj)
        {
            ThreadInfo info = (ThreadInfo)obj;
            BinVoxModel binVox = new BinVoxModel(info.file.FullName);

            int resumefrom = info.resumefrom;
            int addx = info.relative_x;
            int addy = info.relative_y;
            int addz = info.relative_z;
            
            Thread.Sleep(100);
            // and window name were obtained using the Spy++ tool.
            IntPtr minecraftHandle = FindWindow(null, info.minecraftTitle);

            // Verify that Calculator is a running process. 
            if (minecraftHandle == IntPtr.Zero)
            {
                MessageBox.Show("Minecraft with title '" + info.minecraftTitle + "' not running");
                return;
            }

            // FocusWindow(minecraftHandle); // later?

            SetForegroundWindow(minecraftHandle);



            Thread.Sleep(100);

            // ClickOnPoint(minecraftHandle, new Point(375, 340)); // hrm

            SendKeys.SendWait("{ESC}");
            
            int blocksplaced = 0;

            while (binVox.HasNext())
            {

                Voxel voxel = binVox.Next();

                if (voxel.is_present)
                {

                    if (info.token.IsCancellationRequested)
                    {
                        break;
                    }


                    blocksplaced++;
                    if (blocksplaced < resumefrom) continue;

                    if (blocksplaced % 20 == 0)
                    {
                        Properties.Settings.Default.resumefrom = blocksplaced.ToString();
                        Thread.Sleep(5000);
                    }

                    string cmd = "/setblock " + (voxel.x + addx)
                        + " " + (voxel.y + addy)
                        + " " + (voxel.z + addz)
                        + " minecraft:sandstone 0 destroy";
                    
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

        private void Mineplot_Load(object sender, EventArgs e)
        {
            minecraftTitle.Text = Properties.Settings.Default.minecraftTitle;
            coordinates_relative_x.Text = Properties.Settings.Default.relative_x;
            coordinates_relative_y.Text = Properties.Settings.Default.relative_y;
            coordinates_relative_z.Text = Properties.Settings.Default.relative_z;
            resume_voxel.Text = Properties.Settings.Default.resumefrom;
        }

        private void plotButton_Click(object sender, EventArgs e)
        {
            //Thread 1: The Requestor 
            if (plotting == false)
            {
                plotButton.Text = "Stop";
                plotting = true;
                
                int resumefrom = int.Parse(resume_voxel.Text);

                // Create the token source.                                
                cts = new CancellationTokenSource();

                // Pass the token to the cancelable operation.
                ThreadPool.QueueUserWorkItem(new WaitCallback(plotInThread),
                    new ThreadInfo(
                        cts.Token,
                        fileList[filesListBox.SelectedIndex],

                        minecraftTitle.Text,

                        resumefrom,
                        int.Parse(coordinates_relative_x.Text),
                        int.Parse(coordinates_relative_y.Text),
                        int.Parse(coordinates_relative_z.Text)
                    )
                );
            }

            else
            {
                plotting = false;
                plotButton.Text = "Plot!";

                Properties.Settings.Default.Save();
                resume_voxel.Text = Properties.Settings.Default.resumefrom;

                // Request cancellation by setting a flag on the token.
                if (cts != null) cts.Cancel();
            }
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FileDetail selectedFile = fileList[filesListBox.SelectedIndex];
            BinVoxModel binVox = new BinVoxModel(selectedFile.FullName);
            
            fileInfo.Clear();

            fileInfo.AppendText("file: " + selectedFile.Display + "\r\n\r\n");

            fileInfo.AppendText("depth: " + binVox.dims.depth + " width: " + binVox.dims.width + " height: " + binVox.dims.height + "\r\n");
            fileInfo.AppendText("voxels: " + binVox.size + "\r\n");
            fileInfo.AppendText("present voxels: " + binVox.present_voxels);

            plotButton.Enabled = true;
        }

        private void changeBinvoxDirButton_Click(object sender, EventArgs e)
        {
            if (binvoxDirEntry.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.binVoxDir = binvoxDirEntry.SelectedPath;
                plotButton.Enabled = false;
                UpdateFileList();
            }
        }

        private void minecraftTitle_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.minecraftTitle = minecraftTitle.Text;
        }

        private void coordinates_relative_x_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.relative_x = coordinates_relative_x.Text;

        }

        private void coordinates_relative_y_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.relative_y = coordinates_relative_y.Text;

        }

        private void coordinates_relative_z_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.relative_z = coordinates_relative_z.Text;
        }

        private void Mineplot_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void resume_voxel_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.resumefrom = resume_voxel.Text;

        }


    }

}
