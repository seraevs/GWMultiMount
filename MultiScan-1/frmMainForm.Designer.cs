namespace MultiScan_1
{
    partial class frmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.menuMAIN = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMultiScanToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unmountAllDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreMultiScanFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAVEssetAVGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAVEsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scanNetworkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMultiScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxViewLogs = new System.Windows.Forms.GroupBox();
            this.btnOpeLogWin = new System.Windows.Forms.Button();
            this.btnOpeLogLocal = new System.Windows.Forms.Button();
            this.btnOpeLogLin = new System.Windows.Forms.Button();
            this.btnOpeLogStorage = new System.Windows.Forms.Button();
            this.groupBoxStartScan = new System.Windows.Forms.GroupBox();
            this.btnUnMount = new System.Windows.Forms.Button();
            this.btnScanStorage = new System.Windows.Forms.Button();
            this.btnRunConfiguration = new System.Windows.Forms.Button();
            this.btnScalLocalSys = new System.Windows.Forms.Button();
            this.btnScanLinux_Windows = new System.Windows.Forms.Button();
            this.btnRunWireShark = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScanLinux = new System.Windows.Forms.Button();
            this.btnRunOrigMultiScan = new System.Windows.Forms.Button();
            this.btnScanWindows = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_AutoMail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Auto_run_Scan = new System.Windows.Forms.Label();
            this.lblAuto_run_Scan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuMAIN.SuspendLayout();
            this.groupBoxViewLogs.SuspendLayout();
            this.groupBoxStartScan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuMAIN
            // 
            this.menuMAIN.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMAIN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMAIN.Location = new System.Drawing.Point(0, 0);
            this.menuMAIN.Name = "menuMAIN";
            this.menuMAIN.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuMAIN.Size = new System.Drawing.Size(714, 24);
            this.menuMAIN.TabIndex = 22;
            this.menuMAIN.Text = "main menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveMultiScanToToolStripMenuItem,
            this.unmountAllDToolStripMenuItem,
            this.restoreMultiScanFromToolStripMenuItem,
            this.updateAVEssetAVGToolStripMenuItem,
            this.updateAVEsetToolStripMenuItem,
            this.toolStripMenuItem1,
            this.scanNetworkToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveMultiScanToToolStripMenuItem
            // 
            this.saveMultiScanToToolStripMenuItem.Name = "saveMultiScanToToolStripMenuItem";
            this.saveMultiScanToToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.saveMultiScanToToolStripMenuItem.Text = "Save MultiScan To";
            this.saveMultiScanToToolStripMenuItem.Click += new System.EventHandler(this.saveMultiScanToToolStripMenuItem_Click);
            // 
            // unmountAllDToolStripMenuItem
            // 
            this.unmountAllDToolStripMenuItem.Name = "unmountAllDToolStripMenuItem";
            this.unmountAllDToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.unmountAllDToolStripMenuItem.Text = "Unmount All devices";
            this.unmountAllDToolStripMenuItem.Click += new System.EventHandler(this.unmountAllDToolStripMenuItem_Click);
            // 
            // restoreMultiScanFromToolStripMenuItem
            // 
            this.restoreMultiScanFromToolStripMenuItem.Name = "restoreMultiScanFromToolStripMenuItem";
            this.restoreMultiScanFromToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.restoreMultiScanFromToolStripMenuItem.Text = "Restore MultiScan From";
            this.restoreMultiScanFromToolStripMenuItem.Click += new System.EventHandler(this.restoreMultiScanFromToolStripMenuItem_Click);
            // 
            // updateAVEssetAVGToolStripMenuItem
            // 
            this.updateAVEssetAVGToolStripMenuItem.Name = "updateAVEssetAVGToolStripMenuItem";
            this.updateAVEssetAVGToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.updateAVEssetAVGToolStripMenuItem.Text = "Update AV AVG";
            this.updateAVEssetAVGToolStripMenuItem.Visible = false;
            this.updateAVEssetAVGToolStripMenuItem.Click += new System.EventHandler(this.updateAVEssetAVGToolStripMenuItem_Click);
            // 
            // updateAVEsetToolStripMenuItem
            // 
            this.updateAVEsetToolStripMenuItem.Name = "updateAVEsetToolStripMenuItem";
            this.updateAVEsetToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.updateAVEsetToolStripMenuItem.Text = "Update AV Eset";
            this.updateAVEsetToolStripMenuItem.Visible = false;
            this.updateAVEsetToolStripMenuItem.Click += new System.EventHandler(this.updateAVEsetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(225, 22);
            this.toolStripMenuItem1.Text = "Check Network Connections";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // scanNetworkToolStripMenuItem
            // 
            this.scanNetworkToolStripMenuItem.Name = "scanNetworkToolStripMenuItem";
            this.scanNetworkToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.scanNetworkToolStripMenuItem.Text = "Scan Network";
            this.scanNetworkToolStripMenuItem.Click += new System.EventHandler(this.scanNetworkToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.eXITToolStripMenuItem.Text = "Exit";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMultiScanToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMultiScanToolStripMenuItem
            // 
            this.aboutMultiScanToolStripMenuItem.Name = "aboutMultiScanToolStripMenuItem";
            this.aboutMultiScanToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.aboutMultiScanToolStripMenuItem.Text = "About MultiScan";
            this.aboutMultiScanToolStripMenuItem.Click += new System.EventHandler(this.aboutMultiScanToolStripMenuItem_Click);
            // 
            // groupBoxViewLogs
            // 
            this.groupBoxViewLogs.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxViewLogs.Controls.Add(this.btnOpeLogWin);
            this.groupBoxViewLogs.Controls.Add(this.btnOpeLogLocal);
            this.groupBoxViewLogs.Controls.Add(this.btnOpeLogLin);
            this.groupBoxViewLogs.Controls.Add(this.btnOpeLogStorage);
            this.groupBoxViewLogs.Location = new System.Drawing.Point(9, 169);
            this.groupBoxViewLogs.MaximumSize = new System.Drawing.Size(700, 104);
            this.groupBoxViewLogs.Name = "groupBoxViewLogs";
            this.groupBoxViewLogs.Size = new System.Drawing.Size(700, 66);
            this.groupBoxViewLogs.TabIndex = 23;
            this.groupBoxViewLogs.TabStop = false;
            this.groupBoxViewLogs.Text = "View Logs";
            this.groupBoxViewLogs.Visible = false;
            // 
            // btnOpeLogWin
            // 
            this.btnOpeLogWin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnOpeLogWin.Image = ((System.Drawing.Image)(resources.GetObject("btnOpeLogWin.Image")));
            this.btnOpeLogWin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpeLogWin.Location = new System.Drawing.Point(21, 18);
            this.btnOpeLogWin.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpeLogWin.Name = "btnOpeLogWin";
            this.btnOpeLogWin.Size = new System.Drawing.Size(136, 38);
            this.btnOpeLogWin.TabIndex = 18;
            this.btnOpeLogWin.Text = "Log Windows";
            this.btnOpeLogWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpeLogWin.UseVisualStyleBackColor = true;
            this.btnOpeLogWin.Visible = false;
            this.btnOpeLogWin.Click += new System.EventHandler(this.btnOpeLogWin_Click);
            // 
            // btnOpeLogLocal
            // 
            this.btnOpeLogLocal.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnOpeLogLocal.Image = ((System.Drawing.Image)(resources.GetObject("btnOpeLogLocal.Image")));
            this.btnOpeLogLocal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpeLogLocal.Location = new System.Drawing.Point(441, 18);
            this.btnOpeLogLocal.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpeLogLocal.Name = "btnOpeLogLocal";
            this.btnOpeLogLocal.Size = new System.Drawing.Size(136, 38);
            this.btnOpeLogLocal.TabIndex = 21;
            this.btnOpeLogLocal.Text = "Log Local System";
            this.btnOpeLogLocal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpeLogLocal.UseVisualStyleBackColor = true;
            this.btnOpeLogLocal.Visible = false;
            this.btnOpeLogLocal.Click += new System.EventHandler(this.btnOpeLogLocal_Click);
            // 
            // btnOpeLogLin
            // 
            this.btnOpeLogLin.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnOpeLogLin.Image = ((System.Drawing.Image)(resources.GetObject("btnOpeLogLin.Image")));
            this.btnOpeLogLin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpeLogLin.Location = new System.Drawing.Point(161, 18);
            this.btnOpeLogLin.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpeLogLin.Name = "btnOpeLogLin";
            this.btnOpeLogLin.Size = new System.Drawing.Size(136, 38);
            this.btnOpeLogLin.TabIndex = 19;
            this.btnOpeLogLin.Text = "Log Linux";
            this.btnOpeLogLin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpeLogLin.UseVisualStyleBackColor = true;
            this.btnOpeLogLin.Visible = false;
            this.btnOpeLogLin.Click += new System.EventHandler(this.btnOpeLogLin_Click);
            // 
            // btnOpeLogStorage
            // 
            this.btnOpeLogStorage.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnOpeLogStorage.Image = ((System.Drawing.Image)(resources.GetObject("btnOpeLogStorage.Image")));
            this.btnOpeLogStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpeLogStorage.Location = new System.Drawing.Point(301, 18);
            this.btnOpeLogStorage.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpeLogStorage.Name = "btnOpeLogStorage";
            this.btnOpeLogStorage.Size = new System.Drawing.Size(136, 38);
            this.btnOpeLogStorage.TabIndex = 20;
            this.btnOpeLogStorage.Text = "Log Storage";
            this.btnOpeLogStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpeLogStorage.UseVisualStyleBackColor = true;
            this.btnOpeLogStorage.Visible = false;
            this.btnOpeLogStorage.Click += new System.EventHandler(this.btnOpeLogStorage_Click);
            // 
            // groupBoxStartScan
            // 
            this.groupBoxStartScan.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBoxStartScan.Controls.Add(this.btnUnMount);
            this.groupBoxStartScan.Controls.Add(this.btnScanStorage);
            this.groupBoxStartScan.Controls.Add(this.btnRunConfiguration);
            this.groupBoxStartScan.Controls.Add(this.btnScalLocalSys);
            this.groupBoxStartScan.Controls.Add(this.btnScanLinux_Windows);
            this.groupBoxStartScan.Controls.Add(this.btnRunWireShark);
            this.groupBoxStartScan.Controls.Add(this.btnExit);
            this.groupBoxStartScan.Controls.Add(this.btnScanLinux);
            this.groupBoxStartScan.Controls.Add(this.btnRunOrigMultiScan);
            this.groupBoxStartScan.Controls.Add(this.btnScanWindows);
            this.groupBoxStartScan.Location = new System.Drawing.Point(9, 48);
            this.groupBoxStartScan.MaximumSize = new System.Drawing.Size(700, 120);
            this.groupBoxStartScan.Name = "groupBoxStartScan";
            this.groupBoxStartScan.Size = new System.Drawing.Size(700, 120);
            this.groupBoxStartScan.TabIndex = 24;
            this.groupBoxStartScan.TabStop = false;
            this.groupBoxStartScan.Text = "Mount Startr";
            // 
            // btnUnMount
            // 
            this.btnUnMount.Image = global::MultiScan_1.Properties.Resources.icons8_delete_32;
            this.btnUnMount.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUnMount.Location = new System.Drawing.Point(21, 62);
            this.btnUnMount.Name = "btnUnMount";
            this.btnUnMount.Size = new System.Drawing.Size(136, 38);
            this.btnUnMount.TabIndex = 18;
            this.btnUnMount.Text = "UnMount";
            this.btnUnMount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnMount.UseVisualStyleBackColor = true;
            this.btnUnMount.Click += new System.EventHandler(this.btnUnMount_Click);
            // 
            // btnScanStorage
            // 
            this.btnScanStorage.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnScanStorage.Image = ((System.Drawing.Image)(resources.GetObject("btnScanStorage.Image")));
            this.btnScanStorage.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanStorage.Location = new System.Drawing.Point(21, 61);
            this.btnScanStorage.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanStorage.Name = "btnScanStorage";
            this.btnScanStorage.Size = new System.Drawing.Size(136, 38);
            this.btnScanStorage.TabIndex = 12;
            this.btnScanStorage.Text = "Mount Storage";
            this.btnScanStorage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanStorage.UseVisualStyleBackColor = true;
            this.btnScanStorage.Visible = false;
            this.btnScanStorage.Click += new System.EventHandler(this.btnScanStorage_Click);
            // 
            // btnRunConfiguration
            // 
            this.btnRunConfiguration.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnRunConfiguration.Image = ((System.Drawing.Image)(resources.GetObject("btnRunConfiguration.Image")));
            this.btnRunConfiguration.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunConfiguration.Location = new System.Drawing.Point(21, 19);
            this.btnRunConfiguration.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunConfiguration.Name = "btnRunConfiguration";
            this.btnRunConfiguration.Size = new System.Drawing.Size(136, 38);
            this.btnRunConfiguration.TabIndex = 13;
            this.btnRunConfiguration.Text = "Run Configuration";
            this.btnRunConfiguration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunConfiguration.UseVisualStyleBackColor = true;
            this.btnRunConfiguration.Click += new System.EventHandler(this.btnRunConfiguration_Click);
            // 
            // btnScalLocalSys
            // 
            this.btnScalLocalSys.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnScalLocalSys.Image = ((System.Drawing.Image)(resources.GetObject("btnScalLocalSys.Image")));
            this.btnScalLocalSys.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScalLocalSys.Location = new System.Drawing.Point(161, 61);
            this.btnScalLocalSys.Margin = new System.Windows.Forms.Padding(2);
            this.btnScalLocalSys.Name = "btnScalLocalSys";
            this.btnScalLocalSys.Size = new System.Drawing.Size(136, 38);
            this.btnScalLocalSys.TabIndex = 15;
            this.btnScalLocalSys.Text = "Scan Local System";
            this.btnScalLocalSys.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScalLocalSys.UseVisualStyleBackColor = true;
            this.btnScalLocalSys.Visible = false;
            this.btnScalLocalSys.Click += new System.EventHandler(this.btnScalLocalSys_Click);
            // 
            // btnScanLinux_Windows
            // 
            this.btnScanLinux_Windows.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnScanLinux_Windows.Image = ((System.Drawing.Image)(resources.GetObject("btnScanLinux_Windows.Image")));
            this.btnScanLinux_Windows.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanLinux_Windows.Location = new System.Drawing.Point(558, 61);
            this.btnScanLinux_Windows.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanLinux_Windows.Name = "btnScanLinux_Windows";
            this.btnScanLinux_Windows.Size = new System.Drawing.Size(136, 38);
            this.btnScanLinux_Windows.TabIndex = 11;
            this.btnScanLinux_Windows.Text = "Mount Linux + Windows";
            this.btnScanLinux_Windows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanLinux_Windows.UseVisualStyleBackColor = true;
            this.btnScanLinux_Windows.Visible = false;
            this.btnScanLinux_Windows.Click += new System.EventHandler(this.btnScanLinux_Windows_Click);
            // 
            // btnRunWireShark
            // 
            this.btnRunWireShark.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnRunWireShark.Image = ((System.Drawing.Image)(resources.GetObject("btnRunWireShark.Image")));
            this.btnRunWireShark.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunWireShark.Location = new System.Drawing.Point(441, 60);
            this.btnRunWireShark.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunWireShark.Name = "btnRunWireShark";
            this.btnRunWireShark.Size = new System.Drawing.Size(136, 38);
            this.btnRunWireShark.TabIndex = 16;
            this.btnRunWireShark.Text = "Run WireShark";
            this.btnRunWireShark.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunWireShark.UseVisualStyleBackColor = true;
            this.btnRunWireShark.Visible = false;
            this.btnRunWireShark.Click += new System.EventHandler(this.btnRunWireShark_Click);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Location = new System.Drawing.Point(441, 19);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 38);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScanLinux
            // 
            this.btnScanLinux.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnScanLinux.Image = ((System.Drawing.Image)(resources.GetObject("btnScanLinux.Image")));
            this.btnScanLinux.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanLinux.Location = new System.Drawing.Point(161, 18);
            this.btnScanLinux.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanLinux.Name = "btnScanLinux";
            this.btnScanLinux.Size = new System.Drawing.Size(136, 38);
            this.btnScanLinux.TabIndex = 9;
            this.btnScanLinux.Text = "Mount Linux";
            this.btnScanLinux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanLinux.UseVisualStyleBackColor = true;
            this.btnScanLinux.Click += new System.EventHandler(this.btnScanLinux_Click);
            // 
            // btnRunOrigMultiScan
            // 
            this.btnRunOrigMultiScan.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnRunOrigMultiScan.Image = ((System.Drawing.Image)(resources.GetObject("btnRunOrigMultiScan.Image")));
            this.btnRunOrigMultiScan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRunOrigMultiScan.Location = new System.Drawing.Point(301, 60);
            this.btnRunOrigMultiScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnRunOrigMultiScan.Name = "btnRunOrigMultiScan";
            this.btnRunOrigMultiScan.Size = new System.Drawing.Size(136, 38);
            this.btnRunOrigMultiScan.TabIndex = 14;
            this.btnRunOrigMultiScan.Text = "Run Original Multiscan";
            this.btnRunOrigMultiScan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRunOrigMultiScan.UseVisualStyleBackColor = true;
            this.btnRunOrigMultiScan.Visible = false;
            this.btnRunOrigMultiScan.Click += new System.EventHandler(this.btnRunOrigMultiScan_Click);
            // 
            // btnScanWindows
            // 
            this.btnScanWindows.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnScanWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnScanWindows.Image")));
            this.btnScanWindows.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScanWindows.Location = new System.Drawing.Point(301, 18);
            this.btnScanWindows.Margin = new System.Windows.Forms.Padding(2);
            this.btnScanWindows.Name = "btnScanWindows";
            this.btnScanWindows.Size = new System.Drawing.Size(136, 38);
            this.btnScanWindows.TabIndex = 10;
            this.btnScanWindows.Text = "Mount Windows";
            this.btnScanWindows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScanWindows.UseVisualStyleBackColor = true;
            this.btnScanWindows.Click += new System.EventHandler(this.btnScanWindows_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.lbl_AutoMail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Auto_run_Scan);
            this.groupBox1.Controls.Add(this.lblAuto_run_Scan);
            this.groupBox1.Location = new System.Drawing.Point(9, 257);
            this.groupBox1.MaximumSize = new System.Drawing.Size(315, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 90);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status Auto  Mount";
            // 
            // lbl_AutoMail
            // 
            this.lbl_AutoMail.AutoSize = true;
            this.lbl_AutoMail.Location = new System.Drawing.Point(81, 56);
            this.lbl_AutoMail.Name = "lbl_AutoMail";
            this.lbl_AutoMail.Size = new System.Drawing.Size(60, 13);
            this.lbl_AutoMail.TabIndex = 28;
            this.lbl_AutoMail.Text = "DISABLED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Auto Mail    = ";
            // 
            // Auto_run_Scan
            // 
            this.Auto_run_Scan.AutoSize = true;
            this.Auto_run_Scan.Location = new System.Drawing.Point(81, 25);
            this.Auto_run_Scan.Name = "Auto_run_Scan";
            this.Auto_run_Scan.Size = new System.Drawing.Size(60, 13);
            this.Auto_run_Scan.TabIndex = 26;
            this.Auto_run_Scan.Text = "DISABLED";
            // 
            // lblAuto_run_Scan
            // 
            this.lblAuto_run_Scan.AutoSize = true;
            this.lblAuto_run_Scan.Location = new System.Drawing.Point(6, 25);
            this.lblAuto_run_Scan.Name = "lblAuto_run_Scan";
            this.lblAuto_run_Scan.Size = new System.Drawing.Size(74, 13);
            this.lblAuto_run_Scan.TabIndex = 0;
            this.lblAuto_run_Scan.Text = "Auto Mount = ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(9, 349);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 50);
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 50);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImage = global::MultiScan_1.Properties.Resources.fire;
            this.ClientSize = new System.Drawing.Size(714, 421);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxStartScan);
            this.Controls.Add(this.groupBoxViewLogs);
            this.Controls.Add(this.menuMAIN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMAIN;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(730, 460);
            this.Name = "frmMainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Multi Mount Connections";
            this.menuMAIN.ResumeLayout(false);
            this.menuMAIN.PerformLayout();
            this.groupBoxViewLogs.ResumeLayout(false);
            this.groupBoxStartScan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRunWireShark;
        private System.Windows.Forms.Button btnScalLocalSys;
        private System.Windows.Forms.Button btnRunOrigMultiScan;
        private System.Windows.Forms.Button btnRunConfiguration;
        private System.Windows.Forms.Button btnScanStorage;
        private System.Windows.Forms.Button btnScanLinux_Windows;
        private System.Windows.Forms.Button btnScanWindows;
        private System.Windows.Forms.Button btnScanLinux;
        private System.Windows.Forms.Button btnOpeLogWin;
        private System.Windows.Forms.Button btnOpeLogLin;
        private System.Windows.Forms.Button btnOpeLogStorage;
        private System.Windows.Forms.Button btnOpeLogLocal;
        private System.Windows.Forms.MenuStrip menuMAIN;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMultiScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAVEssetAVGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAVEsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMultiScanToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreMultiScanFromToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBoxViewLogs;
        private System.Windows.Forms.GroupBox groupBoxStartScan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Auto_run_Scan;
        private System.Windows.Forms.Label lblAuto_run_Scan;
        private System.Windows.Forms.ToolStripMenuItem scanNetworkToolStripMenuItem;
        private System.Windows.Forms.Label lbl_AutoMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem unmountAllDToolStripMenuItem;
        private System.Windows.Forms.Button btnUnMount;
    }
}