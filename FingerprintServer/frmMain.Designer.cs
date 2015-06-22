namespace FingerprintNetSample
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarRotation = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBarSensibility = new System.Windows.Forms.TrackBar();
            this.lvwFPReaders = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveImageAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblThreshold2 = new System.Windows.Forms.Label();
            this.lblThreshold = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuality = new System.Windows.Forms.Label();
            this.prgbMatching = new FingerprintNetSample.ColorProgressBar();
            this.prgbQuality = new FingerprintNetSample.ColorProgressBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoExtractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identifyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.autoIdentifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.startEnrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStartServer = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStopServer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsslStatusMessages = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enrollToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.startEnrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.logToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensibility)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 360);
            this.panel1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.trackBarRotation);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.trackBarSensibility);
            this.panel5.Controls.Add(this.lvwFPReaders);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(384, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(168, 360);
            this.panel5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rotation sensibility";
            // 
            // trackBarRotation
            // 
            this.trackBarRotation.LargeChange = 25;
            this.trackBarRotation.Location = new System.Drawing.Point(3, 287);
            this.trackBarRotation.Maximum = 200;
            this.trackBarRotation.Minimum = 1;
            this.trackBarRotation.Name = "trackBarRotation";
            this.trackBarRotation.Size = new System.Drawing.Size(160, 45);
            this.trackBarRotation.SmallChange = 5;
            this.trackBarRotation.TabIndex = 10;
            this.trackBarRotation.TickFrequency = 10;
            this.trackBarRotation.Value = 35;
            this.trackBarRotation.ValueChanged += new System.EventHandler(this.trackBarSensibility_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Match sensibility";
            // 
            // trackBarSensibility
            // 
            this.trackBarSensibility.LargeChange = 25;
            this.trackBarSensibility.Location = new System.Drawing.Point(3, 223);
            this.trackBarSensibility.Maximum = 200;
            this.trackBarSensibility.Minimum = 1;
            this.trackBarSensibility.Name = "trackBarSensibility";
            this.trackBarSensibility.Size = new System.Drawing.Size(160, 45);
            this.trackBarSensibility.SmallChange = 5;
            this.trackBarSensibility.TabIndex = 8;
            this.trackBarSensibility.TickFrequency = 10;
            this.trackBarSensibility.Value = 35;
            this.trackBarSensibility.ValueChanged += new System.EventHandler(this.trackBarSensibility_ValueChanged);
            // 
            // lvwFPReaders
            // 
            this.lvwFPReaders.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lvwFPReaders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvwFPReaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFPReaders.GridLines = true;
            this.lvwFPReaders.LabelWrap = false;
            this.lvwFPReaders.LargeImageList = this.imageList1;
            this.lvwFPReaders.Location = new System.Drawing.Point(0, 0);
            this.lvwFPReaders.MultiSelect = false;
            this.lvwFPReaders.Name = "lvwFPReaders";
            this.lvwFPReaders.ShowGroups = false;
            this.lvwFPReaders.Size = new System.Drawing.Size(166, 358);
            this.lvwFPReaders.TabIndex = 0;
            this.lvwFPReaders.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "sensorFingerIn.bmp");
            this.imageList1.Images.SetKeyName(1, "sensorFingerout.bmp");
            this.imageList1.Images.SetKeyName(2, "sensorFingerImageCap.bmp");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.MinimumSize = new System.Drawing.Size(392, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(392, 357);
            this.panel4.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(390, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 362);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveImageAsToolStripMenuItem,
            this.openImageToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(68, 48);
            // 
            // saveImageAsToolStripMenuItem
            // 
            this.saveImageAsToolStripMenuItem.Name = "saveImageAsToolStripMenuItem";
            this.saveImageAsToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(68, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "bmp";
            this.saveFileDialog1.Filter = "Bitmap File (*.bmp)|*.bmp";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Bitmap Files (*.bmp)|*.bmp";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 538);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblThreshold2);
            this.panel3.Controls.Add(this.lblThreshold);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lblQuality);
            this.panel3.Controls.Add(this.prgbMatching);
            this.panel3.Controls.Add(this.prgbQuality);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 384);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 132);
            this.panel3.TabIndex = 4;
            // 
            // lblThreshold2
            // 
            this.lblThreshold2.AutoSize = true;
            this.lblThreshold2.Location = new System.Drawing.Point(12, 113);
            this.lblThreshold2.Name = "lblThreshold2";
            this.lblThreshold2.Size = new System.Drawing.Size(54, 13);
            this.lblThreshold2.TabIndex = 7;
            this.lblThreshold2.Text = "Threshold";
            // 
            // lblThreshold
            // 
            this.lblThreshold.AutoSize = true;
            this.lblThreshold.Location = new System.Drawing.Point(12, 97);
            this.lblThreshold.Name = "lblThreshold";
            this.lblThreshold.Size = new System.Drawing.Size(9, 13);
            this.lblThreshold.TabIndex = 6;
            this.lblThreshold.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Good";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Matching Score";
            // 
            // lblQuality
            // 
            this.lblQuality.AutoSize = true;
            this.lblQuality.Location = new System.Drawing.Point(3, 5);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(86, 13);
            this.lblQuality.TabIndex = 2;
            this.lblQuality.Text = "Template Quality";
            // 
            // prgbMatching
            // 
            this.prgbMatching.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prgbMatching.Location = new System.Drawing.Point(3, 87);
            this.prgbMatching.Maximum = 200;
            this.prgbMatching.Minimum = 0;
            this.prgbMatching.Name = "prgbMatching";
            this.prgbMatching.ProgressBarColor = System.Drawing.Color.Blue;
            this.prgbMatching.Size = new System.Drawing.Size(549, 23);
            this.prgbMatching.Step = 0;
            this.prgbMatching.TabIndex = 1;
            this.prgbMatching.Value = 0;
            // 
            // prgbQuality
            // 
            this.prgbQuality.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.prgbQuality.Location = new System.Drawing.Point(3, 20);
            this.prgbQuality.Maximum = 100;
            this.prgbQuality.Minimum = 0;
            this.prgbQuality.Name = "prgbQuality";
            this.prgbQuality.ProgressBarColor = System.Drawing.Color.WhiteSmoke;
            this.prgbQuality.Size = new System.Drawing.Size(549, 23);
            this.prgbQuality.Step = 0;
            this.prgbQuality.TabIndex = 0;
            this.prgbQuality.Value = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatusMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslStatusMessage
            // 
            this.tsslStatusMessage.Name = "tsslStatusMessage";
            this.tsslStatusMessage.Size = new System.Drawing.Size(118, 17);
            this.tsslStatusMessage.Text = "toolStripStatusLabel1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.preferencesToolStripMenuItem,
            this.dBToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem,
            this.identifyToolStripMenuItem,
            this.enrollToolStripMenuItem2,
            this.toolStripSeparator3,
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem1,
            this.toolStripSeparator4,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // extractToolStripMenuItem
            // 
            this.extractToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extractToolStripMenuItem1,
            this.autoExtractToolStripMenuItem});
            this.extractToolStripMenuItem.Name = "extractToolStripMenuItem";
            this.extractToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.extractToolStripMenuItem.Text = "Extract";
            this.extractToolStripMenuItem.Visible = false;
            // 
            // extractToolStripMenuItem1
            // 
            this.extractToolStripMenuItem1.Name = "extractToolStripMenuItem1";
            this.extractToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.extractToolStripMenuItem1.Text = "Extract";
            this.extractToolStripMenuItem1.Click += new System.EventHandler(this.extractToolStripMenuItem_Click);
            // 
            // autoExtractToolStripMenuItem
            // 
            this.autoExtractToolStripMenuItem.Checked = true;
            this.autoExtractToolStripMenuItem.CheckOnClick = true;
            this.autoExtractToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoExtractToolStripMenuItem.Name = "autoExtractToolStripMenuItem";
            this.autoExtractToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.autoExtractToolStripMenuItem.Text = "Auto Extract";
            // 
            // identifyToolStripMenuItem
            // 
            this.identifyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.identifyToolStripMenuItem1,
            this.autoIdentifyToolStripMenuItem});
            this.identifyToolStripMenuItem.Name = "identifyToolStripMenuItem";
            this.identifyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.identifyToolStripMenuItem.Text = "Identify";
            this.identifyToolStripMenuItem.Visible = false;
            // 
            // identifyToolStripMenuItem1
            // 
            this.identifyToolStripMenuItem1.Name = "identifyToolStripMenuItem1";
            this.identifyToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.identifyToolStripMenuItem1.Text = "Identify";
            this.identifyToolStripMenuItem1.Click += new System.EventHandler(this.identifyToolStripMenuItem_Click);
            // 
            // autoIdentifyToolStripMenuItem
            // 
            this.autoIdentifyToolStripMenuItem.Checked = true;
            this.autoIdentifyToolStripMenuItem.CheckOnClick = true;
            this.autoIdentifyToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoIdentifyToolStripMenuItem.Name = "autoIdentifyToolStripMenuItem";
            this.autoIdentifyToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.autoIdentifyToolStripMenuItem.Text = "Auto Identify";
            this.autoIdentifyToolStripMenuItem.CheckedChanged += new System.EventHandler(this.autoIdentifyToolStripMenuItem_CheckedChanged);
            // 
            // enrollToolStripMenuItem2
            // 
            this.enrollToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollToolStripMenuItem3,
            this.startEnrollToolStripMenuItem1});
            this.enrollToolStripMenuItem2.Name = "enrollToolStripMenuItem2";
            this.enrollToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.enrollToolStripMenuItem2.Text = "Enroll";
            this.enrollToolStripMenuItem2.Visible = false;
            // 
            // enrollToolStripMenuItem3
            // 
            this.enrollToolStripMenuItem3.Name = "enrollToolStripMenuItem3";
            this.enrollToolStripMenuItem3.Size = new System.Drawing.Size(132, 22);
            this.enrollToolStripMenuItem3.Text = "Enroll";
            this.enrollToolStripMenuItem3.Click += new System.EventHandler(this.enrollToolStripMenuItem1_Click);
            // 
            // startEnrollToolStripMenuItem1
            // 
            this.startEnrollToolStripMenuItem1.Name = "startEnrollToolStripMenuItem1";
            this.startEnrollToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.startEnrollToolStripMenuItem1.Text = "Scan Enroll";
            this.startEnrollToolStripMenuItem1.Click += new System.EventHandler(this.startEnrollToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // loadImageToolStripMenuItem
            // 
            this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
            this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadImageToolStripMenuItem.Text = "Load Image";
            this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageFromFileToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem1
            // 
            this.saveImageToolStripMenuItem1.Name = "saveImageToolStripMenuItem1";
            this.saveImageToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveImageToolStripMenuItem1.Text = "Save Image";
            this.saveImageToolStripMenuItem1.Visible = false;
            this.saveImageToolStripMenuItem1.Click += new System.EventHandler(this.saveImageAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.preferencesToolStripMenuItem.Text = "Preferences...";
            this.preferencesToolStripMenuItem.Visible = false;
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // dBToolStripMenuItem
            // 
            this.dBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearDatabaseToolStripMenuItem});
            this.dBToolStripMenuItem.Name = "dBToolStripMenuItem";
            this.dBToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.dBToolStripMenuItem.Text = "DB";
            // 
            // clearDatabaseToolStripMenuItem
            // 
            this.clearDatabaseToolStripMenuItem.Name = "clearDatabaseToolStripMenuItem";
            this.clearDatabaseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearDatabaseToolStripMenuItem.Text = "Clear Database";
            this.clearDatabaseToolStripMenuItem.Click += new System.EventHandler(this.clearDBToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemStartServer,
            this.menuItemStopServer,
            this.logToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // menuItemStartServer
            // 
            this.menuItemStartServer.Name = "menuItemStartServer";
            this.menuItemStartServer.Size = new System.Drawing.Size(152, 22);
            this.menuItemStartServer.Text = "Start";
            this.menuItemStartServer.Click += new System.EventHandler(this.menuItemStartServer_Click);
            // 
            // menuItemStopServer
            // 
            this.menuItemStopServer.Name = "menuItemStopServer";
            this.menuItemStopServer.Size = new System.Drawing.Size(152, 22);
            this.menuItemStopServer.Text = "Stop";
            this.menuItemStopServer.Click += new System.EventHandler(this.menuItemStopServer_Click);
            // 
            // tsslStatusMessages
            // 
            this.tsslStatusMessages.Name = "tsslStatusMessages";
            this.tsslStatusMessages.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(32, 19);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(181, 22);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(32, 19);
            // 
            // enrollToolStripMenuItem
            // 
            this.enrollToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enrollToolStripMenuItem1,
            this.startEnrollToolStripMenuItem});
            this.enrollToolStripMenuItem.Name = "enrollToolStripMenuItem";
            this.enrollToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.enrollToolStripMenuItem.Text = "Enroll";
            // 
            // enrollToolStripMenuItem1
            // 
            this.enrollToolStripMenuItem1.Name = "enrollToolStripMenuItem1";
            this.enrollToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.enrollToolStripMenuItem1.Text = "Enroll";
            this.enrollToolStripMenuItem1.Click += new System.EventHandler(this.enrollToolStripMenuItem1_Click);
            // 
            // startEnrollToolStripMenuItem
            // 
            this.startEnrollToolStripMenuItem.Name = "startEnrollToolStripMenuItem";
            this.startEnrollToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.startEnrollToolStripMenuItem.Text = "Start Enroll";
            this.startEnrollToolStripMenuItem.Click += new System.EventHandler(this.startEnrollToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image...";
            this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(178, 6);
            // 
            // logToolStripMenuItem
            // 
            this.logToolStripMenuItem.Name = "logToolStripMenuItem";
            this.logToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.logToolStripMenuItem.Text = "Log";
            this.logToolStripMenuItem.Click += new System.EventHandler(this.logToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(552, 538);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(568, 576);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(568, 576);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fingerprint";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSensibility)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem saveImageAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQuality;
//        private System.Windows.Forms.ProgressBar prgbMatching;
        private ColorProgressBar prgbMatching;
        private ColorProgressBar prgbQuality;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusMessages;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        
        
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        
        
        
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;                                
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startEnrollToolStripMenuItem;
        private System.Windows.Forms.ListView lvwFPReaders;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblThreshold;      
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extractToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoExtractToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identifyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem autoIdentifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enrollToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem startEnrollToolStripMenuItem1;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatusMessage;
        private System.Windows.Forms.Label lblThreshold2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBarSensibility;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarRotation;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemStartServer;
        private System.Windows.Forms.ToolStripMenuItem menuItemStopServer;
        private System.Windows.Forms.ToolStripMenuItem logToolStripMenuItem;

    }
}

