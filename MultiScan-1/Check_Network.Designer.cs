namespace MultiScan_1
{
    partial class Check_Network
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_Network));
            this.listBoxIP_connected = new System.Windows.Forms.ListBox();
            this.cfg = new System.Windows.Forms.GroupBox();
            this.end_ip = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.end_ip_a = new System.Windows.Forms.TextBox();
            this.begin_ip = new System.Windows.Forms.TextBox();
            this.ip_address = new System.Windows.Forms.TextBox();
            this.lblOnline = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.Begin_network_scan = new System.Windows.Forms.Button();
            this.listBoxIP_disconnected = new System.Windows.Forms.ListBox();
            this.lblOfline = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNetInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cfg.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxIP_connected
            // 
            this.listBoxIP_connected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxIP_connected.FormattingEnabled = true;
            this.listBoxIP_connected.HorizontalScrollbar = true;
            this.listBoxIP_connected.Location = new System.Drawing.Point(286, 42);
            this.listBoxIP_connected.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIP_connected.MaximumSize = new System.Drawing.Size(287, 264);
            this.listBoxIP_connected.MinimumSize = new System.Drawing.Size(287, 264);
            this.listBoxIP_connected.Name = "listBoxIP_connected";
            this.listBoxIP_connected.ScrollAlwaysVisible = true;
            this.listBoxIP_connected.Size = new System.Drawing.Size(287, 264);
            this.listBoxIP_connected.TabIndex = 0;
            // 
            // cfg
            // 
            this.cfg.Controls.Add(this.end_ip);
            this.cfg.Controls.Add(this.label2);
            this.cfg.Controls.Add(this.label1);
            this.cfg.Controls.Add(this.end_ip_a);
            this.cfg.Controls.Add(this.begin_ip);
            this.cfg.Controls.Add(this.ip_address);
            this.cfg.Location = new System.Drawing.Point(9, 37);
            this.cfg.Margin = new System.Windows.Forms.Padding(2);
            this.cfg.Name = "cfg";
            this.cfg.Padding = new System.Windows.Forms.Padding(2);
            this.cfg.Size = new System.Drawing.Size(261, 163);
            this.cfg.TabIndex = 1;
            this.cfg.TabStop = false;
            this.cfg.Text = "Configuration";
            // 
            // end_ip
            // 
            this.end_ip.AutoSize = true;
            this.end_ip.Location = new System.Drawing.Point(39, 120);
            this.end_ip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.end_ip.Name = "end_ip";
            this.end_ip.Size = new System.Drawing.Size(43, 13);
            this.end_ip.TabIndex = 5;
            this.end_ip.Text = "END IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Begin IP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP Address";
            // 
            // end_ip_a
            // 
            this.end_ip_a.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.end_ip_a.Location = new System.Drawing.Point(26, 136);
            this.end_ip_a.Margin = new System.Windows.Forms.Padding(2);
            this.end_ip_a.Name = "end_ip_a";
            this.end_ip_a.Size = new System.Drawing.Size(76, 20);
            this.end_ip_a.TabIndex = 2;
            this.end_ip_a.Text = "1";
            // 
            // begin_ip
            // 
            this.begin_ip.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.begin_ip.Location = new System.Drawing.Point(26, 89);
            this.begin_ip.Margin = new System.Windows.Forms.Padding(2);
            this.begin_ip.Name = "begin_ip";
            this.begin_ip.Size = new System.Drawing.Size(76, 20);
            this.begin_ip.TabIndex = 1;
            this.begin_ip.Text = "1";
            // 
            // ip_address
            // 
            this.ip_address.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ip_address.Location = new System.Drawing.Point(19, 40);
            this.ip_address.Margin = new System.Windows.Forms.Padding(2);
            this.ip_address.Name = "ip_address";
            this.ip_address.Size = new System.Drawing.Size(92, 20);
            this.ip_address.TabIndex = 0;
            this.ip_address.Text = "101.1.146.";
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.Location = new System.Drawing.Point(362, 26);
            this.lblOnline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(117, 13);
            this.lblOnline.TabIndex = 4;
            this.lblOnline.Text = "List of Machines Online";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMain.Image")));
            this.btnBackToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToMain.Location = new System.Drawing.Point(9, 259);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(110, 48);
            this.btnBackToMain.TabIndex = 8;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // Begin_network_scan
            // 
            this.Begin_network_scan.Image = ((System.Drawing.Image)(resources.GetObject("Begin_network_scan.Image")));
            this.Begin_network_scan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Begin_network_scan.Location = new System.Drawing.Point(9, 206);
            this.Begin_network_scan.Margin = new System.Windows.Forms.Padding(2);
            this.Begin_network_scan.Name = "Begin_network_scan";
            this.Begin_network_scan.Size = new System.Drawing.Size(110, 48);
            this.Begin_network_scan.TabIndex = 9;
            this.Begin_network_scan.Text = "Start Scan";
            this.Begin_network_scan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Begin_network_scan.UseVisualStyleBackColor = true;
            this.Begin_network_scan.Click += new System.EventHandler(this.Begin_network_scan_Click);
            // 
            // listBoxIP_disconnected
            // 
            this.listBoxIP_disconnected.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxIP_disconnected.FormattingEnabled = true;
            this.listBoxIP_disconnected.HorizontalScrollbar = true;
            this.listBoxIP_disconnected.Location = new System.Drawing.Point(592, 43);
            this.listBoxIP_disconnected.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxIP_disconnected.MaximumSize = new System.Drawing.Size(287, 264);
            this.listBoxIP_disconnected.MinimumSize = new System.Drawing.Size(287, 264);
            this.listBoxIP_disconnected.Name = "listBoxIP_disconnected";
            this.listBoxIP_disconnected.ScrollAlwaysVisible = true;
            this.listBoxIP_disconnected.Size = new System.Drawing.Size(287, 264);
            this.listBoxIP_disconnected.TabIndex = 10;
            // 
            // lblOfline
            // 
            this.lblOfline.AutoSize = true;
            this.lblOfline.Location = new System.Drawing.Point(678, 26);
            this.lblOfline.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOfline.Name = "lblOfline";
            this.lblOfline.Size = new System.Drawing.Size(114, 13);
            this.lblOfline.TabIndex = 11;
            this.lblOfline.Text = "List of Machines Ofline";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1048, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStripNetwork";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullNetInfoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // fullNetInfoToolStripMenuItem
            // 
            this.fullNetInfoToolStripMenuItem.Name = "fullNetInfoToolStripMenuItem";
            this.fullNetInfoToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.fullNetInfoToolStripMenuItem.Text = "Full Net Info";
            this.fullNetInfoToolStripMenuItem.Click += new System.EventHandler(this.fullNetInfoToolStripMenuItem_Click);
            // 
            // Check_Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 374);
            this.Controls.Add(this.lblOfline);
            this.Controls.Add(this.listBoxIP_disconnected);
            this.Controls.Add(this.Begin_network_scan);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.cfg);
            this.Controls.Add(this.listBoxIP_connected);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1064, 412);
            this.MinimumSize = new System.Drawing.Size(1064, 412);
            this.Name = "Check_Network";
            this.Text = "Check Network";
            this.cfg.ResumeLayout(false);
            this.cfg.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxIP_connected;
        private System.Windows.Forms.GroupBox cfg;
        private System.Windows.Forms.TextBox end_ip_a;
        private System.Windows.Forms.TextBox begin_ip;
        private System.Windows.Forms.TextBox ip_address;
        private System.Windows.Forms.Label end_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button Begin_network_scan;
        private System.Windows.Forms.ListBox listBoxIP_disconnected;
        private System.Windows.Forms.Label lblOfline;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullNetInfoToolStripMenuItem;
    }
}