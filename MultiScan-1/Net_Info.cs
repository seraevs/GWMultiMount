using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiScan_1
{
    public partial class Net_Info : Form
    {
        public Net_Info()
        {
            InitializeComponent();
            ViewInfoNet();
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewInfoNet()
        {
            // Add vertical scroll bars to the TextBox control.
            txt_Info_Net.ScrollBars = ScrollBars.Vertical;

            if (File.Exists(@"net_ifo.txt"))
            {
                string text = System.IO.File.ReadAllText(@"net_ifo.txt");

                // Display the file contents. Variable text is a string.
                txt_Info_Net.Text = text;
            }
            else MessageBox.Show("File " + @"net_ifo.txt" + " not exists");
        }
    }
}
