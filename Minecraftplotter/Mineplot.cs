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
        private CancellationTokenSource cts;
        private bool plotting = false;

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

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        // When you don't want the ProcessId, use this overload and pass IntPtr.Zero for the second parameter
        [DllImport("user32.dll")]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);

        [DllImport("kernel32.dll")]
        static extern uint GetCurrentThreadId();

        /// <summary>The GetForegroundWindow function returns a handle to the foreground window.</summary>
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        static extern bool AttachThreadInput(uint idAttach, uint idAttachTo, bool fAttach);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool BringWindowToTop(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern bool BringWindowToTop(HandleRef hWnd);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, uint nCmdShow);

        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);

        [DllImport("user32.dll")]
        static extern bool ClientToScreen(IntPtr hWnd, ref Point lpPoint);

        private void ClickOnPoint(IntPtr wndHandle, Point clientPoint)
        {
            var oldPos = Cursor.Position;

            /// get screen coordinates
            ClientToScreen(wndHandle, ref clientPoint);

            /// set cursor on coords, and press mouse
            Cursor.Position = new Point(clientPoint.X, clientPoint.Y);
            mouse_event(0x00000002, 0, 0, 0, UIntPtr.Zero); /// left mouse button down
            mouse_event(0x00000004, 0, 0, 0, UIntPtr.Zero); /// left mouse button up

            /// return mouse 
            Cursor.Position = oldPos;
        }

        private void FocusWindow(IntPtr hWnd)
        {
            // force window to have focus
            uint foreThread = GetWindowThreadProcessId(hWnd, IntPtr.Zero);
            uint appThread = GetCurrentThreadId();
            const uint SW_SHOW = 5;
            if (foreThread != appThread)
            {
                AttachThreadInput(foreThread, appThread, true);
                BringWindowToTop(hWnd);
                ShowWindow(hWnd, SW_SHOW);
                AttachThreadInput(foreThread, appThread, false);
            }
            else
            {
                BringWindowToTop(hWnd);
                ShowWindow(hWnd, SW_SHOW);
            }
        }

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
            //Thread 1: The Requestor 
            if (plotting == false)
            {
                plotButton.Text = "Stop";
                plotting = true;
                // Create the token source.
                cts = new CancellationTokenSource();

                // Pass the token to the cancelable operation.
                ThreadPool.QueueUserWorkItem(new WaitCallback(plotInThread), cts.Token);
            }

            else
            {
                plotting = false;
                plotButton.Text = "Plot!";

                // Request cancellation by setting a flag on the token.
                cts.Cancel();
            }
        }

        private void plotInThread(object obj)
        {
            CancellationToken token = (CancellationToken)obj;

            Thread.Sleep(100);
            // and window name were obtained using the Spy++ tool.
            IntPtr minecraftHandle = FindWindow(null, minecraftTitle.Text);

            // Verify that Calculator is a running process. 
            if (minecraftHandle == IntPtr.Zero)
            {
                MessageBox.Show("Minecraft with title '" + minecraftTitle.Text + "' not running");
                return;
            }
            
            // FocusWindow(minecraftHandle); // later?
            
            SetForegroundWindow(minecraftHandle);
            
            string player_mod = "";
            int addx;
            int addz;
            int addy;
            if (player_relative.Checked)
            {
                player_mod = "~";
                addx = int.Parse(player_relative_x.Text);
                addz = int.Parse(player_relative_z.Text);
                addy = int.Parse(player_relative_y.Text);
            }
            else
            {
                addx = int.Parse(coordinates_relative_x.Text);
                addz = int.Parse(coordinates_relative_z.Text);
                addy = int.Parse(coordinates_relative_y.Text);
            }

            Thread.Sleep(100);

            // ClickOnPoint(minecraftHandle, new Point(375, 340)); // hrm

            SendKeys.SendWait("{ESC}");
            int blocksplaced = 0;        
            while (binVox.HasNext())
            {


                Voxel voxel = binVox.Next();
                
                if (voxel.is_present)
                {
                    if (token.IsCancellationRequested)
                    {
                        break;
                    }
                    
                    blocksplaced++;
                    if (blocksplaced % 20 == 0)
                    {
                        Thread.Sleep(5000);
                    }
                    
                    // logBox.Items.Add("x:" + voxel.x + " z:" + voxel.z + " y:" + voxel.y + " present: " + voxel.is_present);
                   
                    string cmd = "/setblock " + player_mod + (voxel.x + addx)
                        + " " + player_mod + (voxel.y + addy)
                        + " " + player_mod + (voxel.z + addz) 
                        + " minecraft:sandstone 0 destroy";
                    // logBox.Items.Add(cmd);


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

        private void coordinates_relative_CheckedChanged(object sender, EventArgs e)
        {
            if (coordinates_relative.Checked) coordinates_relative_group.Enabled = true;
            else coordinates_relative_group.Enabled = false;
        }

        private void player_relative_CheckedChanged(object sender, EventArgs e)
        {
            if (player_relative.Checked) player_relative_group.Enabled = true;
            else player_relative_group.Enabled = false;

        }

    }
}
