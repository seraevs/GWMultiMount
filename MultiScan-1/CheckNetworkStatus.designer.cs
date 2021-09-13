namespace MultiScan_1
{
    partial class CheckNetworkStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckNetworkStatus));
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lstNetworkStatus = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(228, 385);
            this.btn_Exit.MaximumSize = new System.Drawing.Size(316, 210);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 45);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lstNetworkStatus
            // 
            this.lstNetworkStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lstNetworkStatus.FormattingEnabled = true;
            this.lstNetworkStatus.HorizontalScrollbar = true;
            this.lstNetworkStatus.Location = new System.Drawing.Point(9, 21);
            this.lstNetworkStatus.Margin = new System.Windows.Forms.Padding(2);
            this.lstNetworkStatus.MaximumSize = new System.Drawing.Size(295, 362);
            this.lstNetworkStatus.MinimumSize = new System.Drawing.Size(295, 362);
            this.lstNetworkStatus.Name = "lstNetworkStatus";
            this.lstNetworkStatus.ScrollAlwaysVisible = true;
            this.lstNetworkStatus.Size = new System.Drawing.Size(295, 355);
            this.lstNetworkStatus.TabIndex = 4;
            // 
            // CheckNetworkStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 452);
            this.Controls.Add(this.lstNetworkStatus);
            this.Controls.Add(this.btn_Exit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 490);
            this.MinimumSize = new System.Drawing.Size(370, 490);
            this.Name = "CheckNetworkStatus";
            this.Text = "Network Status";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox lstNetworkStatus;
    }
}