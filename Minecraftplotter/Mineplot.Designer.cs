namespace MineplotApp
{
    partial class Mineplot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label2;
            this.minecraftTitle = new System.Windows.Forms.TextBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.changeBinvoxDirButton = new System.Windows.Forms.Button();
            this.binvoxDirEntry = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.coordinates_relative_x = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coordinates_relative_y = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coordinates_relative_z = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox3 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.resume_voxel_num = new System.Windows.Forms.Label();
            this.resume_voxel = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.fileInfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            label2 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupbox3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 13);
            label2.TabIndex = 3;
            label2.Text = "Minecraft Apptitle";
            // 
            // minecraftTitle
            // 
            this.minecraftTitle.Location = new System.Drawing.Point(15, 25);
            this.minecraftTitle.Name = "minecraftTitle";
            this.minecraftTitle.Size = new System.Drawing.Size(124, 20);
            this.minecraftTitle.TabIndex = 2;
            this.minecraftTitle.Text = "Minecraft 1.7.4";
            this.minecraftTitle.TextChanged += new System.EventHandler(this.minecraftTitle_TextChanged);
            // 
            // filesListBox
            // 
            this.filesListBox.DisplayMember = "Display";
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(6, 19);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(311, 121);
            this.filesListBox.TabIndex = 4;
            this.filesListBox.ValueMember = "FullName";
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // plotButton
            // 
            this.plotButton.Enabled = false;
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotButton.Location = new System.Drawing.Point(219, 186);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(109, 237);
            this.plotButton.TabIndex = 5;
            this.plotButton.Text = "Plot!";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // changeBinvoxDirButton
            // 
            this.changeBinvoxDirButton.Location = new System.Drawing.Point(188, 144);
            this.changeBinvoxDirButton.Name = "changeBinvoxDirButton";
            this.changeBinvoxDirButton.Size = new System.Drawing.Size(129, 23);
            this.changeBinvoxDirButton.TabIndex = 6;
            this.changeBinvoxDirButton.Text = "Change .binvox files dir";
            this.changeBinvoxDirButton.UseVisualStyleBackColor = true;
            this.changeBinvoxDirButton.Click += new System.EventHandler(this.changeBinvoxDirButton_Click);
            // 
            // binvoxDirEntry
            // 
            this.binvoxDirEntry.ShowNewFolderButton = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filesListBox);
            this.groupBox4.Controls.Add(this.changeBinvoxDirButton);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 174);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File to plot";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.coordinates_relative_x);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.coordinates_relative_y);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.coordinates_relative_z);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(202, 26);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "x";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates_relative_x
            // 
            this.coordinates_relative_x.Location = new System.Drawing.Point(14, 3);
            this.coordinates_relative_x.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.coordinates_relative_x.Name = "coordinates_relative_x";
            this.coordinates_relative_x.Size = new System.Drawing.Size(55, 20);
            this.coordinates_relative_x.TabIndex = 0;
            this.coordinates_relative_x.Text = "0";
            this.coordinates_relative_x.TextChanged += new System.EventHandler(this.coordinates_relative_x_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 5);
            this.label8.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "y";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates_relative_y
            // 
            this.coordinates_relative_y.Location = new System.Drawing.Point(84, 3);
            this.coordinates_relative_y.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.coordinates_relative_y.Name = "coordinates_relative_y";
            this.coordinates_relative_y.Size = new System.Drawing.Size(48, 20);
            this.coordinates_relative_y.TabIndex = 2;
            this.coordinates_relative_y.Text = "0";
            this.coordinates_relative_y.TextChanged += new System.EventHandler(this.coordinates_relative_y_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(132, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "z";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates_relative_z
            // 
            this.coordinates_relative_z.Location = new System.Drawing.Point(146, 3);
            this.coordinates_relative_z.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.coordinates_relative_z.Name = "coordinates_relative_z";
            this.coordinates_relative_z.Size = new System.Drawing.Size(53, 20);
            this.coordinates_relative_z.TabIndex = 1;
            this.coordinates_relative_z.Text = "0";
            this.coordinates_relative_z.TextChanged += new System.EventHandler(this.coordinates_relative_z_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(6, 364);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 59);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // groupbox3
            // 
            this.groupbox3.Controls.Add(this.flowLayoutPanel3);
            this.groupbox3.Location = new System.Drawing.Point(6, 299);
            this.groupbox3.Name = "groupbox3";
            this.groupbox3.Size = new System.Drawing.Size(211, 59);
            this.groupbox3.TabIndex = 13;
            this.groupbox3.TabStop = false;
            this.groupbox3.Text = "Resume";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.resume_voxel_num);
            this.flowLayoutPanel3.Controls.Add(this.resume_voxel);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(205, 34);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // resume_voxel_num
            // 
            this.resume_voxel_num.AutoSize = true;
            this.resume_voxel_num.Location = new System.Drawing.Point(3, 6);
            this.resume_voxel_num.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.resume_voxel_num.Name = "resume_voxel_num";
            this.resume_voxel_num.Size = new System.Drawing.Size(145, 13);
            this.resume_voxel_num.TabIndex = 0;
            this.resume_voxel_num.Text = "Resume from present voxel #";
            // 
            // resume_voxel
            // 
            this.resume_voxel.Location = new System.Drawing.Point(151, 3);
            this.resume_voxel.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.resume_voxel.Name = "resume_voxel";
            this.resume_voxel.Size = new System.Drawing.Size(53, 20);
            this.resume_voxel.TabIndex = 2;
            this.resume_voxel.Text = "0";
            this.resume_voxel.TextChanged += new System.EventHandler(this.resume_voxel_TextChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel4);
            this.groupBox5.Location = new System.Drawing.Point(6, 186);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(211, 107);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Fileinfo";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.fileInfo);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(9, 20);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(198, 81);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // fileInfo
            // 
            this.fileInfo.Location = new System.Drawing.Point(3, 3);
            this.fileInfo.Multiline = true;
            this.fileInfo.Name = "fileInfo";
            this.fileInfo.Size = new System.Drawing.Size(190, 78);
            this.fileInfo.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 458);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupbox3);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.plotButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Plotter";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Autominer";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Mineplot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 526);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(label2);
            this.Controls.Add(this.minecraftTitle);
            this.Name = "Mineplot";
            this.Text = "Mineplot";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mineplot_FormClosed);
            this.Load += new System.EventHandler(this.Mineplot_Load);
            this.groupBox4.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupbox3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minecraftTitle;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Button changeBinvoxDirButton;
        public System.Windows.Forms.FolderBrowserDialog binvoxDirEntry;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coordinates_relative_x;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox coordinates_relative_y;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox coordinates_relative_z;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupbox3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label resume_voxel_num;
        private System.Windows.Forms.TextBox resume_voxel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.TextBox fileInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

