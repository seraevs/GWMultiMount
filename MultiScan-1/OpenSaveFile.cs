using System;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Diagnostics;

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Net;
using System.Net.Sockets;
using System.Globalization;
using System.Reflection;

namespace MultiScan_1
{
    public partial class frmOpenSaveFile : Form
    {
        string txtInfo;
        public frmOpenSaveFile(string _text)
        {
            InitializeComponent();
            txtInfo = _text;
        }

        private void btnSaveFileToFolder_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            //set default file name
            savefile.FileName = "unknow.txt";
            savefile.Filter = "All files (*.*)|*.*|TXT files (*.txt)|*.txt|TXT files (*.csv)|*.csv";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(savefile.FileName))
                    sw.WriteLine(txtInfo);
            }
        }

        private void frmOpenSaveFile_Load(object sender, EventArgs e)
        {

            txtOpenSaveFile.Text = txtInfo;
        }

        private void btnCloseDialog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
