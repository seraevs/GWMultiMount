namespace MultiScan_1
{
    partial class Net_Info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Net_Info));
            this.txt_Info_Net = new System.Windows.Forms.TextBox();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Info_Net
            // 
            this.txt_Info_Net.Location = new System.Drawing.Point(9, 10);
            this.txt_Info_Net.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Info_Net.MaximumSize = new System.Drawing.Size(1015, 374);
            this.txt_Info_Net.Multiline = true;
            this.txt_Info_Net.Name = "txt_Info_Net";
            this.txt_Info_Net.Size = new System.Drawing.Size(1015, 374);
            this.txt_Info_Net.TabIndex = 0;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.Image = ((System.Drawing.Image)(resources.GetObject("btnBackToMain.Image")));
            this.btnBackToMain.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackToMain.Location = new System.Drawing.Point(914, 395);
            this.btnBackToMain.Margin = new System.Windows.Forms.Padding(2);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(110, 33);
            this.btnBackToMain.TabIndex = 8;
            this.btnBackToMain.Text = "Back to Main";
            this.btnBackToMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToMain.UseVisualStyleBackColor = true;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // Net_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 438);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.txt_Info_Net);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Net_Info";
            this.Text = "Full Network Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Info_Net;
        private System.Windows.Forms.Button btnBackToMain;
    }
}