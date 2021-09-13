namespace MultiScan_1
{
    partial class frmOpenSaveFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenSaveFile));
            this.txtOpenSaveFile = new System.Windows.Forms.TextBox();
            this.btnCloseDialog = new System.Windows.Forms.Button();
            this.btnSaveFileToFolder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOpenSaveFile
            // 
            this.txtOpenSaveFile.Location = new System.Drawing.Point(9, 10);
            this.txtOpenSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpenSaveFile.Multiline = true;
            this.txtOpenSaveFile.Name = "txtOpenSaveFile";
            this.txtOpenSaveFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpenSaveFile.Size = new System.Drawing.Size(1011, 364);
            this.txtOpenSaveFile.TabIndex = 0;
            // 
            // btnCloseDialog
            // 
            this.btnCloseDialog.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCloseDialog.BackColor = System.Drawing.Color.Silver;
            this.btnCloseDialog.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseDialog.Image")));
            this.btnCloseDialog.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseDialog.Location = new System.Drawing.Point(161, 374);
            this.btnCloseDialog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCloseDialog.Name = "btnCloseDialog";
            this.btnCloseDialog.Size = new System.Drawing.Size(136, 38);
            this.btnCloseDialog.TabIndex = 22;
            this.btnCloseDialog.Text = "Close";
            this.btnCloseDialog.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseDialog.UseVisualStyleBackColor = false;
            this.btnCloseDialog.Click += new System.EventHandler(this.btnCloseDialog_Click);
            // 
            // btnSaveFileToFolder
            // 
            this.btnSaveFileToFolder.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnSaveFileToFolder.BackColor = System.Drawing.Color.Silver;
            this.btnSaveFileToFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFileToFolder.Image")));
            this.btnSaveFileToFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveFileToFolder.Location = new System.Drawing.Point(9, 374);
            this.btnSaveFileToFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveFileToFolder.Name = "btnSaveFileToFolder";
            this.btnSaveFileToFolder.Size = new System.Drawing.Size(136, 38);
            this.btnSaveFileToFolder.TabIndex = 23;
            this.btnSaveFileToFolder.Text = "Save file to...";
            this.btnSaveFileToFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveFileToFolder.UseVisualStyleBackColor = false;
            this.btnSaveFileToFolder.Click += new System.EventHandler(this.btnSaveFileToFolder_Click);
            // 
            // frmOpenSaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 423);
            this.Controls.Add(this.btnSaveFileToFolder);
            this.Controls.Add(this.btnCloseDialog);
            this.Controls.Add(this.txtOpenSaveFile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1046, 469);
            this.Name = "frmOpenSaveFile";
            this.Text = "Open File, Save File";
            this.Load += new System.EventHandler(this.frmOpenSaveFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOpenSaveFile;
        private System.Windows.Forms.Button btnCloseDialog;
        private System.Windows.Forms.Button btnSaveFileToFolder;
    }
}