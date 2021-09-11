using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Xml;
using System.Net.Sockets;
using System.Globalization;
using System.Reflection;
using System.Management;

namespace MultiScan_1
{
    public partial class Check_Network : Form
    {
        private delegate void DoUiWorkHandler(string str);
        List<string> arr = new List<string>();
        List<string> arr_ip = new List<string>();
        public Check_Network()
        {
            InitializeComponent();

            listBoxIP_connected.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxIP_connected.DrawItem += new DrawItemEventHandler(listBoxDrawItem);

            listBoxIP_disconnected.DrawMode = DrawMode.OwnerDrawFixed;
            listBoxIP_disconnected.DrawItem += new DrawItemEventHandler(listBoxDrawItem);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		public void process_start1(string parameter)
		{

			//string command = "echo " + "$(nmap -O -sV " + ip_address.Text + cnt.ToString() + ") >> test.txt";
			//string command = "echo " + "$(nmap -O -sV " + ip_address.Text + cnt.ToString() + ") >> test.txt";
			ProcessStartInfo info = new ProcessStartInfo()
			{
				FileName = @"/bin/bash",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				//Arguments = string.Format("-c \" " + "echo $(nmap -O -sV " + ip_address.Text + cnt.ToString() + ") >> test.txt" + " \"")
				Arguments = string.Format("-c \" " + parameter + " \"")

			};

			Process process = new Process();
			process.StartInfo = info;
			process.Start();

			process.WaitForExit();

		}

        private void BeginNetworkScan()
        {
            arr.Clear();

            // Delete a file by using File class static method...
            if (System.IO.File.Exists(@"/opt/ANTIVIRUS/MultiScan-1/bin/Debug/net_ifo.txt"))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.

                System.IO.File.Delete(@"/opt/ANTIVIRUS/MultiScan-1/bin/Debug/net_ifo.txt");

            }

            if (string.IsNullOrWhiteSpace(this.ip_address.Text))
            {
                MessageBox.Show("Add ip address in Fields IP Address, for example 192.168.1.");
            }

            if (string.IsNullOrWhiteSpace(this.begin_ip.Text))
            {
                MessageBox.Show("Add begin IP in Fields Begin IP, for example 1");
            }

            if (string.IsNullOrWhiteSpace(this.ip_address.Text))
            {
                MessageBox.Show("Add END IP in Fields END IP, for example 254");
            }

            string NameOS = "";

            if (!string.IsNullOrWhiteSpace(this.ip_address.Text) && (!string.IsNullOrWhiteSpace(this.begin_ip.Text)) && (!string.IsNullOrWhiteSpace(this.end_ip.Text)))
            {
                int b_ip = Int32.Parse(begin_ip.Text);
                int e_ip = Int32.Parse(end_ip_a.Text);
                int cnt = b_ip;
                while (cnt <= e_ip)
                {
                    Ping ping = new Ping();
                    PingReply pingReply = ping.Send(ip_address.Text + cnt.ToString());

                    if (pingReply.Status == IPStatus.Success)
                    {

                        NameOS = "";

                        //MessageBox.Show(ip_address.Text + cnt.ToString() + " Is active");
                        string machineName = string.Empty;
                        try
                        {
                            IPHostEntry hostEntry = Dns.GetHostEntry(ip_address.Text + cnt.ToString());

                            machineName = hostEntry.HostName;
                        }
                        catch (Exception ex)
                        {
                            // Machine not found...
                        }
                        //MessageBox.Show(machineName);
                        if (machineName != "")
                        {

                            AddItemConected(ip_address.Text + cnt.ToString() + " Host name is: " + machineName);

                        }
                        else
                        {

                            AddItemConected(ip_address.Text + cnt.ToString() + " Host name is: Not Exists");

                        }

                        process_start1("echo '===========================================================================' >> net_ifo.txt");
                        process_start1("echo $(nmap -O -sV " + ip_address.Text + cnt.ToString() + ") >> net_ifo.txt");
                        process_start1("echo '===========================================================================' >> net_ifo.txt");

                    }
                    else
                    {
                        //MessageBox.Show(ip_address.Text + cnt.ToString() + " Is not active");
                        AddItemDisconected(ip_address.Text + cnt.ToString());
                    }


                    cnt++;
                }

                MessageBox.Show("Finished Netwwork scan", "Network Scan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Begin_network_scan_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(BeginNetworkScan);
        }

        private void listBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {

                if (arr[e.Index].Equals("connected"))
                {
                    e.Graphics.DrawString(listBoxIP_connected.Items[e.Index].ToString(), e.Font, Brushes.Green, e.Bounds);
                }
                else
                {
                    e.Graphics.DrawString(listBoxIP_disconnected.Items[e.Index].ToString(), e.Font, Brushes.Red, e.Bounds);
                }
            }
            catch(Exception exc)
            {
                Console.WriteLine("arr size" + arr.Count + " Index: " + e.Index + " Error: " + exc.Message);
            }

        }

        private void AddItemConected(string str)
        {

            if (listBoxIP_connected.InvokeRequired)
            {
                listBoxIP_connected.Invoke(new DoUiWorkHandler(AddItemConected), new object[] { str });
            }
            else
            {
                arr.Add("connected");
                listBoxIP_connected.Items.Add(str);
            }

        }

        private void AddItemDisconected(string str)
        {
            if (listBoxIP_disconnected.InvokeRequired)
            {

                listBoxIP_disconnected.Invoke(new DoUiWorkHandler(AddItemDisconected), new object[] { str });
            }
            else
            {
                arr.Add("disconnected");
                listBoxIP_disconnected.Items.Add(str);
            }
        }
        private void fullNetInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Net_Info net_Info_dialog = new Net_Info();
            net_Info_dialog.Show(this);
            this.Show();
        }
    }
}
