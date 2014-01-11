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
            this.logBox = new System.Windows.Forms.ListBox();
            this.player_relative = new System.Windows.Forms.RadioButton();
            this.coordinates_relative = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.coordinates_relative_group = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.coordinates_relative_x = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.coordinates_relative_z = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.coordinates_relative_y = new System.Windows.Forms.TextBox();
            this.player_relative_group = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.player_relative_x = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.player_relative_z = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.player_relative_y = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.x = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.coordinates_relative_group.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.player_relative_group.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox6.SuspendLayout();
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
            this.plotButton.Location = new System.Drawing.Point(253, 352);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(85, 59);
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
            // logBox
            // 
            this.logBox.FormattingEnabled = true;
            this.logBox.Location = new System.Drawing.Point(6, 19);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(311, 82);
            this.logBox.TabIndex = 7;
            this.logBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // player_relative
            // 
            this.player_relative.AutoSize = true;
            this.player_relative.Location = new System.Drawing.Point(6, 95);
            this.player_relative.Name = "player_relative";
            this.player_relative.Size = new System.Drawing.Size(107, 17);
            this.player_relative.TabIndex = 0;
            this.player_relative.TabStop = true;
            this.player_relative.Text = "Relative to player";
            this.player_relative.UseVisualStyleBackColor = true;
            this.player_relative.CheckedChanged += new System.EventHandler(this.player_relative_CheckedChanged);
            // 
            // coordinates_relative
            // 
            this.coordinates_relative.AutoSize = true;
            this.coordinates_relative.Checked = true;
            this.coordinates_relative.Location = new System.Drawing.Point(6, 19);
            this.coordinates_relative.Name = "coordinates_relative";
            this.coordinates_relative.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.coordinates_relative.Size = new System.Drawing.Size(134, 17);
            this.coordinates_relative.TabIndex = 1;
            this.coordinates_relative.TabStop = true;
            this.coordinates_relative.Text = "Relative to coordinates";
            this.coordinates_relative.UseVisualStyleBackColor = true;
            this.coordinates_relative.CheckedChanged += new System.EventHandler(this.coordinates_relative_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.coordinates_relative_group);
            this.groupBox1.Controls.Add(this.player_relative_group);
            this.groupBox1.Controls.Add(this.player_relative);
            this.groupBox1.Controls.Add(this.coordinates_relative);
            this.groupBox1.Location = new System.Drawing.Point(15, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 174);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // coordinates_relative_group
            // 
            this.coordinates_relative_group.Controls.Add(this.flowLayoutPanel2);
            this.coordinates_relative_group.Location = new System.Drawing.Point(6, 42);
            this.coordinates_relative_group.Name = "coordinates_relative_group";
            this.coordinates_relative_group.Size = new System.Drawing.Size(220, 50);
            this.coordinates_relative_group.TabIndex = 9;
            this.coordinates_relative_group.TabStop = false;
            this.coordinates_relative_group.Text = "Coordinates";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.coordinates_relative_x);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.coordinates_relative_y);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.coordinates_relative_z);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 18);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(208, 26);
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
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(141, 5);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "z";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coordinates_relative_z
            // 
            this.coordinates_relative_z.Location = new System.Drawing.Point(155, 3);
            this.coordinates_relative_z.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.coordinates_relative_z.Name = "coordinates_relative_z";
            this.coordinates_relative_z.Size = new System.Drawing.Size(53, 20);
            this.coordinates_relative_z.TabIndex = 1;
            this.coordinates_relative_z.Text = "0";
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
            this.coordinates_relative_y.Size = new System.Drawing.Size(57, 20);
            this.coordinates_relative_y.TabIndex = 2;
            this.coordinates_relative_y.Text = "0";
            // 
            // player_relative_group
            // 
            this.player_relative_group.Controls.Add(this.flowLayoutPanel3);
            this.player_relative_group.Enabled = false;
            this.player_relative_group.Location = new System.Drawing.Point(6, 118);
            this.player_relative_group.Name = "player_relative_group";
            this.player_relative_group.Size = new System.Drawing.Size(220, 47);
            this.player_relative_group.TabIndex = 2;
            this.player_relative_group.TabStop = false;
            this.player_relative_group.Text = "Add offset";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label11);
            this.flowLayoutPanel3.Controls.Add(this.player_relative_x);
            this.flowLayoutPanel3.Controls.Add(this.label13);
            this.flowLayoutPanel3.Controls.Add(this.player_relative_y);
            this.flowLayoutPanel3.Controls.Add(this.label12);
            this.flowLayoutPanel3.Controls.Add(this.player_relative_z);
            this.flowLayoutPanel3.Controls.Add(this.label14);
            this.flowLayoutPanel3.Controls.Add(this.label15);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(6, 15);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(208, 26);
            this.flowLayoutPanel3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "x";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_relative_x
            // 
            this.player_relative_x.Location = new System.Drawing.Point(14, 3);
            this.player_relative_x.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.player_relative_x.Name = "player_relative_x";
            this.player_relative_x.Size = new System.Drawing.Size(55, 20);
            this.player_relative_x.TabIndex = 0;
            this.player_relative_x.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(141, 5);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 4;
            this.label12.Text = "z";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_relative_z
            // 
            this.player_relative_z.Location = new System.Drawing.Point(155, 3);
            this.player_relative_z.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.player_relative_z.Name = "player_relative_z";
            this.player_relative_z.Size = new System.Drawing.Size(53, 20);
            this.player_relative_z.TabIndex = 1;
            this.player_relative_z.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(69, 5);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 16);
            this.label13.TabIndex = 7;
            this.label13.Text = "y";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player_relative_y
            // 
            this.player_relative_y.Location = new System.Drawing.Point(84, 3);
            this.player_relative_y.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.player_relative_y.Name = "player_relative_y";
            this.player_relative_y.Size = new System.Drawing.Size(57, 20);
            this.player_relative_y.TabIndex = 2;
            this.player_relative_y.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Location = new System.Drawing.Point(3, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "label14";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Location = new System.Drawing.Point(47, 31);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 5, 0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "label15";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.filesListBox);
            this.groupBox4.Controls.Add(this.changeBinvoxDirButton);
            this.groupBox4.Location = new System.Drawing.Point(15, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(323, 174);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "File to plot";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.flowLayoutPanel1);
            this.groupBox5.Enabled = false;
            this.groupBox5.Location = new System.Drawing.Point(253, 234);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(85, 112);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Translation";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.x);
            this.flowLayoutPanel1.Controls.Add(this.textBox1);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.textBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.textBox3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(48, 88);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // x
            // 
            this.x.AutoSize = true;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.x.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.x.Location = new System.Drawing.Point(0, 5);
            this.x.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(14, 16);
            this.x.TabIndex = 3;
            this.x.Text = "x";
            this.x.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 3);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(24, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "z";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 29);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(24, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "y";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(14, 55);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(24, 20);
            this.textBox3.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.logBox);
            this.groupBox6.Location = new System.Drawing.Point(15, 414);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(323, 111);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Log";
            // 
            // Mineplot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 530);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(label2);
            this.Controls.Add(this.minecraftTitle);
            this.Name = "Mineplot";
            this.Text = "Mineplot";
            this.Load += new System.EventHandler(this.Mineplot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.coordinates_relative_group.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.player_relative_group.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minecraftTitle;
        private System.Windows.Forms.ListBox filesListBox;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.Button changeBinvoxDirButton;
        public System.Windows.Forms.FolderBrowserDialog binvoxDirEntry;
        private System.Windows.Forms.ListBox logBox;
        private System.Windows.Forms.RadioButton player_relative;
        private System.Windows.Forms.RadioButton coordinates_relative;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox coordinates_relative_group;
        private System.Windows.Forms.GroupBox player_relative_group;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox coordinates_relative_x;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox coordinates_relative_z;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox coordinates_relative_y;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox player_relative_x;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox player_relative_z;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox player_relative_y;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}

