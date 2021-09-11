using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net;
using System.Threading;

namespace MultiScan_1
{
    public partial class CheckNetworkStatus : Form
    {
        /// Internally holds timer
        /// </summary>
        //private System.Threading.Timer _timer;
        private delegate void DoUiWorkHandler(string str);
        public int cnt1;
        public int cnt2;

        //AppConfiguration _configuration;

        public CheckNetworkStatus()
        {
            InitializeComponent();
            lstNetworkStatus.DrawMode = DrawMode.OwnerDrawFixed;
            lstNetworkStatus.DrawItem += new DrawItemEventHandler(listBoxDrawItem);
            //_configuration = new AppConfiguration();
            PingTest();

        // create new timer and set it to raise event once in a second
        //_timer = new System.Threading.Timer(OnTimerNtp);
        //_timer.Change(0, Int32.Parse(_configuration.Server.Timer));
    }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            arr.Clear();
            if (lstNetworkStatus.InvokeRequired)
            {
                BeginInvoke(new Action(() => { lstNetworkStatus.Items.Clear(); }));
            }
            //Applications_Managment status = new Applications_Managment();
            //status._timerSystemStatus.Change(0, Convert.ToInt32(_configuration.Server.DelayStatus));
            this.Close();
        }

        List<string> arr = new List<string>();

        private void OpenStatus()
        {
            arr.Clear();
            try
            {
                string line;

                System.IO.StreamReader fLinux = new System.IO.StreamReader(@"/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/data.txt");

                while ((line = fLinux.ReadLine()) != null)
                {

                    Ping ping = new Ping();
                    PingReply reply = ping.Send(line);

                    if (reply.Status == IPStatus.Success)
                    {
                        AddGreenItem(line + " : IP address - Online Linux Machine");
                    }
                    if (reply.Status != IPStatus.Success)
                    {
                        AddRedItem(line + " : IP address - Offline Linux Machine");
                    }

                }

                string lineWindows;

                System.IO.StreamReader fWindows = new System.IO.StreamReader(@"/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/data.txt");

                while ((lineWindows = fWindows.ReadLine()) != null)
                {

                    Ping ping = new Ping();
                    PingReply reply = ping.Send(lineWindows);

                    if (reply.Status == IPStatus.Success)
                    {
                        AddGreenItem(lineWindows + " : IP address - Online Windows Machine");
                    }
                    if (reply.Status != IPStatus.Success)
                    {
                        AddRedItem(lineWindows + " : IP address - Offline Windows Machine");
                    }

                }

                string lineStorage;

                System.IO.StreamReader fStorage = new System.IO.StreamReader(@"/opt/ANTIVIRUS/MULTISCAN/scan-netapp/data.txt");

                while ((lineStorage = fStorage.ReadLine()) != null)
                {

                    Ping ping = new Ping();
                    PingReply reply = ping.Send(lineStorage);

                    if (reply.Status == IPStatus.Success)
                    {
                        AddGreenItem(lineStorage + " : IP address - Online Storage Machine");
                    }
                    if (reply.Status != IPStatus.Success)
                    {
                        AddRedItem(lineStorage + " : IP address - Offline Storage Machine");
                    }

                }

            }
            catch (Exception e)
            {

            }
            finally
            {
                AddGreenItem("================================");
            }

        }

        private void AddGreenItem(string str)
        {

                if (lstNetworkStatus.InvokeRequired)
                {

                    lstNetworkStatus.Invoke(new DoUiWorkHandler(AddGreenItem), new object[] { str });
                }
                else
                {

                    if (str == "clear")
                    { str = "\r\n"; lstNetworkStatus.Items.Clear(); }
                    else
                    {

                        arr.Add("green");
                        lstNetworkStatus.Items.Add(str);
                    }
                }
        }


        private void AddRedItem(string str)
        {


                if (lstNetworkStatus.InvokeRequired)
                {

                    lstNetworkStatus.Invoke(new DoUiWorkHandler(AddRedItem), new object[] { str });

                }
                else
                {

                    arr.Add("red");
                    lstNetworkStatus.Items.Add(str);
                }
        }
        public void PingTest()
        {
            Task.Factory.StartNew(OpenStatus);  
        }

        void listBoxDrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                int cnt = e.Index;

                if (arr[e.Index].Equals("green") && cnt >= 0)
                {
                    e.Graphics.DrawString(lstNetworkStatus.Items[e.Index].ToString(), e.Font, Brushes.Green, e.Bounds);
                }
                else
                    e.Graphics.DrawString(lstNetworkStatus.Items[e.Index].ToString(), e.Font, Brushes.Red, e.Bounds);
            }
            catch(Exception exc)
            {
                Console.WriteLine("arr size: " + arr.Count + " index:" + e.Index + " Error: " + exc.Message);
            }
        }

        private void OnTimerNtp(object state)
        {
            //ClearList("");
            //lstNetworkStatus.Refresh();

            /*if (lstNetworkStatus.InvokeRequired)
            {
            //BeginInvoke(new Action(() => { lstNetworkStatus.Items.Clear(); }));
            lstNetworkStatus.Invoke(new Action<ListBox>(clear));
            }*/
            //OpenStatus();
        }

    }
}
