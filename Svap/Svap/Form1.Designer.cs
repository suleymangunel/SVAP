namespace StartVM
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListVMsBTN = new System.Windows.Forms.Button();
            this.VMTV = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.StopServiceBtn = new System.Windows.Forms.Button();
            this.StartServiceBtn = new System.Windows.Forms.Button();
            this.SaveCfgBtn = new System.Windows.Forms.Button();
            this.LoadCfgBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.PingDurNUD3 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.PingCycleNUD3 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.PingTextBtn3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.NameTxt3 = new System.Windows.Forms.TextBox();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.PingDurNUD2 = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.PingCycleNUD2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PingTextBtn2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NameTxt2 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.PingDurNUD1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PingCycleNUD1 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NameTxt1 = new System.Windows.Forms.TextBox();
            this.PingTextBtn1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VMsChkLst = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ClearLogBTN = new System.Windows.Forms.Button();
            this.LogTxt = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.MsgLbl = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.StartStopCtxt = new System.Windows.Forms.ToolStripMenuItem();
            this.NameCtxt = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseCtxt = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingDurNUD3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingCycleNUD3)).BeginInit();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingDurNUD2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingCycleNUD2)).BeginInit();
            this.pnl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingDurNUD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingCycleNUD1)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListVMsBTN
            // 
            this.ListVMsBTN.Location = new System.Drawing.Point(6, 307);
            this.ListVMsBTN.Name = "ListVMsBTN";
            this.ListVMsBTN.Size = new System.Drawing.Size(607, 37);
            this.ListVMsBTN.TabIndex = 5;
            this.ListVMsBTN.Text = "List VMs";
            this.ListVMsBTN.UseVisualStyleBackColor = true;
            this.ListVMsBTN.Click += new System.EventHandler(this.ListVMsBTN_Click);
            // 
            // VMTV
            // 
            this.VMTV.Location = new System.Drawing.Point(6, 6);
            this.VMTV.Name = "VMTV";
            this.VMTV.Size = new System.Drawing.Size(607, 295);
            this.VMTV.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 380);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.linkLabel1);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "About";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(209, 332);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(140, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.cozumpark.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.LimeGreen;
            this.label11.Location = new System.Drawing.Point(185, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 36);
            this.label11.TabIndex = 6;
            this.label11.Text = "Çözüm Park";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Brown;
            this.label12.Location = new System.Drawing.Point(17, 170);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(585, 83);
            this.label12.TabIndex = 4;
            this.label12.Text = resources.GetString("label12.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Date: 26 Apr 2010";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(269, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Author: Süleyman GÜNEL (suleyman@gunelgunel.com)";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(584, 87);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Svap.Properties.Resources.cpk1;
            this.pictureBox1.Location = new System.Drawing.Point(20, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListVMsBTN);
            this.tabPage2.Controls.Add(this.VMTV);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Virtual Machines";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.StopServiceBtn);
            this.tabPage3.Controls.Add(this.StartServiceBtn);
            this.tabPage3.Controls.Add(this.SaveCfgBtn);
            this.tabPage3.Controls.Add(this.LoadCfgBtn);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(619, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuration";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // StopServiceBtn
            // 
            this.StopServiceBtn.Location = new System.Drawing.Point(506, 307);
            this.StopServiceBtn.Name = "StopServiceBtn";
            this.StopServiceBtn.Size = new System.Drawing.Size(107, 37);
            this.StopServiceBtn.TabIndex = 10;
            this.StopServiceBtn.Text = "Stop";
            this.StopServiceBtn.UseVisualStyleBackColor = true;
            this.StopServiceBtn.Click += new System.EventHandler(this.StopServiceBtn_Click);
            // 
            // StartServiceBtn
            // 
            this.StartServiceBtn.Location = new System.Drawing.Point(393, 307);
            this.StartServiceBtn.Name = "StartServiceBtn";
            this.StartServiceBtn.Size = new System.Drawing.Size(107, 37);
            this.StartServiceBtn.TabIndex = 9;
            this.StartServiceBtn.Text = "Start";
            this.StartServiceBtn.UseVisualStyleBackColor = true;
            this.StartServiceBtn.Click += new System.EventHandler(this.StartServiceBtn_Click);
            // 
            // SaveCfgBtn
            // 
            this.SaveCfgBtn.Location = new System.Drawing.Point(122, 307);
            this.SaveCfgBtn.Name = "SaveCfgBtn";
            this.SaveCfgBtn.Size = new System.Drawing.Size(107, 37);
            this.SaveCfgBtn.TabIndex = 5;
            this.SaveCfgBtn.Text = "Save Settings";
            this.SaveCfgBtn.UseVisualStyleBackColor = true;
            this.SaveCfgBtn.Click += new System.EventHandler(this.SaveCfgBtn_Click);
            // 
            // LoadCfgBtn
            // 
            this.LoadCfgBtn.Location = new System.Drawing.Point(9, 307);
            this.LoadCfgBtn.Name = "LoadCfgBtn";
            this.LoadCfgBtn.Size = new System.Drawing.Size(107, 37);
            this.LoadCfgBtn.TabIndex = 4;
            this.LoadCfgBtn.Text = "Load Settings";
            this.LoadCfgBtn.UseVisualStyleBackColor = true;
            this.LoadCfgBtn.Click += new System.EventHandler(this.LoadCfgBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.pnl3);
            this.panel1.Controls.Add(this.pnl2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.pnl1);
            this.panel1.Controls.Add(this.VMsChkLst);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(9, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 295);
            this.panel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(10, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(286, 10);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(10, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(286, 10);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(10, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 10);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.PingDurNUD3);
            this.pnl3.Controls.Add(this.label15);
            this.pnl3.Controls.Add(this.PingCycleNUD3);
            this.pnl3.Controls.Add(this.label8);
            this.pnl3.Controls.Add(this.PingTextBtn3);
            this.pnl3.Controls.Add(this.label5);
            this.pnl3.Controls.Add(this.NameTxt3);
            this.pnl3.Enabled = false;
            this.pnl3.Location = new System.Drawing.Point(31, 201);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(268, 85);
            this.pnl3.TabIndex = 32;
            // 
            // PingDurNUD3
            // 
            this.PingDurNUD3.Location = new System.Drawing.Point(152, 50);
            this.PingDurNUD3.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.PingDurNUD3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PingDurNUD3.Name = "PingDurNUD3";
            this.PingDurNUD3.Size = new System.Drawing.Size(72, 20);
            this.PingDurNUD3.TabIndex = 33;
            this.PingDurNUD3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Duration";
            // 
            // PingCycleNUD3
            // 
            this.PingCycleNUD3.Location = new System.Drawing.Point(57, 50);
            this.PingCycleNUD3.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.PingCycleNUD3.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PingCycleNUD3.Name = "PingCycleNUD3";
            this.PingCycleNUD3.Size = new System.Drawing.Size(72, 20);
            this.PingCycleNUD3.TabIndex = 31;
            this.PingCycleNUD3.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(71, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cycle";
            // 
            // PingTextBtn3
            // 
            this.PingTextBtn3.Location = new System.Drawing.Point(228, 5);
            this.PingTextBtn3.Name = "PingTextBtn3";
            this.PingTextBtn3.Size = new System.Drawing.Size(37, 65);
            this.PingTextBtn3.TabIndex = 29;
            this.PingTextBtn3.Text = "Ping";
            this.PingTextBtn3.UseVisualStyleBackColor = true;
            this.PingTextBtn3.Click += new System.EventHandler(this.PingTextBtn3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "IP/Name";
            // 
            // NameTxt3
            // 
            this.NameTxt3.Location = new System.Drawing.Point(56, 5);
            this.NameTxt3.Name = "NameTxt3";
            this.NameTxt3.Size = new System.Drawing.Size(166, 20);
            this.NameTxt3.TabIndex = 27;
            // 
            // pnl2
            // 
            this.pnl2.Controls.Add(this.PingDurNUD2);
            this.pnl2.Controls.Add(this.label14);
            this.pnl2.Controls.Add(this.PingCycleNUD2);
            this.pnl2.Controls.Add(this.label7);
            this.pnl2.Controls.Add(this.PingTextBtn2);
            this.pnl2.Controls.Add(this.label4);
            this.pnl2.Controls.Add(this.NameTxt2);
            this.pnl2.Enabled = false;
            this.pnl2.Location = new System.Drawing.Point(31, 103);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(268, 86);
            this.pnl2.TabIndex = 31;
            // 
            // PingDurNUD2
            // 
            this.PingDurNUD2.Location = new System.Drawing.Point(151, 55);
            this.PingDurNUD2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.PingDurNUD2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PingDurNUD2.Name = "PingDurNUD2";
            this.PingDurNUD2.Size = new System.Drawing.Size(72, 20);
            this.PingDurNUD2.TabIndex = 31;
            this.PingDurNUD2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(161, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Duration";
            // 
            // PingCycleNUD2
            // 
            this.PingCycleNUD2.Location = new System.Drawing.Point(56, 55);
            this.PingCycleNUD2.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.PingCycleNUD2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PingCycleNUD2.Name = "PingCycleNUD2";
            this.PingCycleNUD2.Size = new System.Drawing.Size(72, 20);
            this.PingCycleNUD2.TabIndex = 29;
            this.PingCycleNUD2.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Cycle";
            // 
            // PingTextBtn2
            // 
            this.PingTextBtn2.Location = new System.Drawing.Point(231, 5);
            this.PingTextBtn2.Name = "PingTextBtn2";
            this.PingTextBtn2.Size = new System.Drawing.Size(37, 70);
            this.PingTextBtn2.TabIndex = 27;
            this.PingTextBtn2.Text = "Ping";
            this.PingTextBtn2.UseVisualStyleBackColor = true;
            this.PingTextBtn2.Click += new System.EventHandler(this.PingTextBtn2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "IP/Name";
            // 
            // NameTxt2
            // 
            this.NameTxt2.Location = new System.Drawing.Point(56, 5);
            this.NameTxt2.Name = "NameTxt2";
            this.NameTxt2.Size = new System.Drawing.Size(166, 20);
            this.NameTxt2.TabIndex = 25;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(10, 201);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 30;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(10, 103);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 29;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(10, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 28;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.PingDurNUD1);
            this.pnl1.Controls.Add(this.label13);
            this.pnl1.Controls.Add(this.PingCycleNUD1);
            this.pnl1.Controls.Add(this.label6);
            this.pnl1.Controls.Add(this.NameTxt1);
            this.pnl1.Controls.Add(this.PingTextBtn1);
            this.pnl1.Controls.Add(this.label1);
            this.pnl1.Enabled = false;
            this.pnl1.Location = new System.Drawing.Point(31, 3);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(268, 86);
            this.pnl1.TabIndex = 27;
            // 
            // PingDurNUD1
            // 
            this.PingDurNUD1.Location = new System.Drawing.Point(152, 57);
            this.PingDurNUD1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.PingDurNUD1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PingDurNUD1.Name = "PingDurNUD1";
            this.PingDurNUD1.Size = new System.Drawing.Size(72, 20);
            this.PingDurNUD1.TabIndex = 29;
            this.PingDurNUD1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(162, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Duration";
            // 
            // PingCycleNUD1
            // 
            this.PingCycleNUD1.Location = new System.Drawing.Point(57, 57);
            this.PingCycleNUD1.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.PingCycleNUD1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PingCycleNUD1.Name = "PingCycleNUD1";
            this.PingCycleNUD1.Size = new System.Drawing.Size(72, 20);
            this.PingCycleNUD1.TabIndex = 27;
            this.PingCycleNUD1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cycle";
            // 
            // NameTxt1
            // 
            this.NameTxt1.Location = new System.Drawing.Point(57, 4);
            this.NameTxt1.Name = "NameTxt1";
            this.NameTxt1.Size = new System.Drawing.Size(165, 20);
            this.NameTxt1.TabIndex = 25;
            // 
            // PingTextBtn1
            // 
            this.PingTextBtn1.Location = new System.Drawing.Point(228, 4);
            this.PingTextBtn1.Name = "PingTextBtn1";
            this.PingTextBtn1.Size = new System.Drawing.Size(37, 73);
            this.PingTextBtn1.TabIndex = 24;
            this.PingTextBtn1.Text = "Ping";
            this.PingTextBtn1.UseVisualStyleBackColor = true;
            this.PingTextBtn1.Click += new System.EventHandler(this.PingTextBtn1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "IP/Name";
            // 
            // VMsChkLst
            // 
            this.VMsChkLst.FormattingEnabled = true;
            this.VMsChkLst.Location = new System.Drawing.Point(305, 27);
            this.VMsChkLst.Name = "VMsChkLst";
            this.VMsChkLst.Size = new System.Drawing.Size(286, 259);
            this.VMsChkLst.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Failover VMs";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.ClearLogBTN);
            this.tabPage4.Controls.Add(this.LogTxt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(619, 354);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Log";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // ClearLogBTN
            // 
            this.ClearLogBTN.Location = new System.Drawing.Point(538, 325);
            this.ClearLogBTN.Name = "ClearLogBTN";
            this.ClearLogBTN.Size = new System.Drawing.Size(75, 23);
            this.ClearLogBTN.TabIndex = 1;
            this.ClearLogBTN.Text = "Clear Log";
            this.ClearLogBTN.UseVisualStyleBackColor = true;
            this.ClearLogBTN.Click += new System.EventHandler(this.ClearLogBTN_Click);
            // 
            // LogTxt
            // 
            this.LogTxt.BackColor = System.Drawing.Color.Black;
            this.LogTxt.ForeColor = System.Drawing.Color.Lime;
            this.LogTxt.Location = new System.Drawing.Point(6, 6);
            this.LogTxt.Multiline = true;
            this.LogTxt.Name = "LogTxt";
            this.LogTxt.Size = new System.Drawing.Size(607, 313);
            this.LogTxt.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // MsgLbl
            // 
            this.MsgLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MsgLbl.Location = new System.Drawing.Point(12, 403);
            this.MsgLbl.Name = "MsgLbl";
            this.MsgLbl.Size = new System.Drawing.Size(627, 23);
            this.MsgLbl.TabIndex = 10;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Svap";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartStopCtxt,
            this.NameCtxt,
            this.CloseCtxt});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 70);
            // 
            // StartStopCtxt
            // 
            this.StartStopCtxt.Name = "StartStopCtxt";
            this.StartStopCtxt.Size = new System.Drawing.Size(155, 22);
            this.StartStopCtxt.Text = "Start";
            this.StartStopCtxt.Click += new System.EventHandler(this.StartStopCtxt_Click);
            // 
            // NameCtxt
            // 
            this.NameCtxt.Name = "NameCtxt";
            this.NameCtxt.Size = new System.Drawing.Size(155, 22);
            this.NameCtxt.Text = "Restore";
            this.NameCtxt.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // CloseCtxt
            // 
            this.CloseCtxt.Name = "CloseCtxt";
            this.CloseCtxt.Size = new System.Drawing.Size(155, 22);
            this.CloseCtxt.Text = "Close Application";
            this.CloseCtxt.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "servicerunning.ico");
            this.imageList1.Images.SetKeyName(1, "servicestopped.ico");
            this.imageList1.Images.SetKeyName(2, "servicepaused.ico");
            this.imageList1.Images.SetKeyName(3, "serviceunknown.ico");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 437);
            this.Controls.Add(this.MsgLbl);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Svap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingDurNUD3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingCycleNUD3)).EndInit();
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingDurNUD2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingCycleNUD2)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PingDurNUD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PingCycleNUD1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ListVMsBTN;
        private System.Windows.Forms.TreeView VMTV;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button LoadCfgBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveCfgBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox VMsChkLst;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.NumericUpDown PingCycleNUD3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button PingTextBtn3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameTxt3;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.NumericUpDown PingCycleNUD2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button PingTextBtn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NameTxt2;
        private System.Windows.Forms.Label MsgLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button StopServiceBtn;
        private System.Windows.Forms.Button StartServiceBtn;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem NameCtxt;
        private System.Windows.Forms.ToolStripMenuItem CloseCtxt;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem StartStopCtxt;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ClearLogBTN;
        private System.Windows.Forms.TextBox LogTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.NumericUpDown PingDurNUD2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown PingDurNUD3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.NumericUpDown PingDurNUD1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown PingCycleNUD1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox NameTxt1;
        private System.Windows.Forms.Button PingTextBtn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

