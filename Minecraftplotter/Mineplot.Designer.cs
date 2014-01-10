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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.minecraftTitle = new System.Windows.Forms.TextBox();
            this.filesListBox = new System.Windows.Forms.ListBox();
            this.plotButton = new System.Windows.Forms.Button();
            this.changeBinvoxDirButton = new System.Windows.Forms.Button();
            this.binvoxDirEntry = new System.Windows.Forms.FolderBrowserDialog();
            this.logBox = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(46, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(55, 13);
            label1.TabIndex = 1;
            label1.Text = "File to plot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 19);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 13);
            label2.TabIndex = 3;
            label2.Text = "Minecraft Apptitle";
            // 
            // minecraftTitle
            // 
            this.minecraftTitle.Location = new System.Drawing.Point(107, 16);
            this.minecraftTitle.Name = "minecraftTitle";
            this.minecraftTitle.Size = new System.Drawing.Size(124, 20);
            this.minecraftTitle.TabIndex = 2;
            this.minecraftTitle.Text = "Minecraft 1.7.4";
            // 
            // filesListBox
            // 
            this.filesListBox.DisplayMember = "Display";
            this.filesListBox.FormattingEnabled = true;
            this.filesListBox.Location = new System.Drawing.Point(107, 42);
            this.filesListBox.Name = "filesListBox";
            this.filesListBox.Size = new System.Drawing.Size(269, 173);
            this.filesListBox.TabIndex = 4;
            this.filesListBox.ValueMember = "FullName";
            this.filesListBox.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // plotButton
            // 
            this.plotButton.Enabled = false;
            this.plotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotButton.Location = new System.Drawing.Point(340, 424);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(52, 26);
            this.plotButton.TabIndex = 5;
            this.plotButton.Text = "Plot!";
            this.plotButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // changeBinvoxDirButton
            // 
            this.changeBinvoxDirButton.Location = new System.Drawing.Point(247, 14);
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
            this.logBox.Location = new System.Drawing.Point(15, 456);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(377, 82);
            this.logBox.TabIndex = 7;
            this.logBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(96, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Offset to player";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(107, 330);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Mineplot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 550);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.changeBinvoxDirButton);
            this.Controls.Add(this.plotButton);
            this.Controls.Add(this.filesListBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.minecraftTitle);
            this.Controls.Add(label1);
            this.Name = "Mineplot";
            this.Text = "Mineplot";
            this.Load += new System.EventHandler(this.Mineplot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

