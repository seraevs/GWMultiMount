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
using System.Xml.Linq;
using System.Xml;

using System.Net;
using System.Net.Sockets;
using System.Globalization;
using System.Reflection;

namespace MultiScan_1
{
    public class StartStopScan
    {
        public string _disable_enable;
        public void start_send_mail(string path_to_log)
        {
            SendMail snd_ml = new SendMail();

            //path to XML document 
            XDocument doc = XDocument.Load("mail_config.xml");

            var lists = doc.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                _disable_enable = (string)list.Attribute("disable_enable");
                //Auto_run_Scan.Text = _disable_enable;

                if (_disable_enable == "ENABLED")
                {
                    snd_ml.send_mail(path_to_log);
                }

            }

        }

        public void linux_unmount()
        {
            process_start("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/unmount_all.sh");
        }

        public void linux_start_scan()
        {
            frmMainForm frml = new frmMainForm();
            frml.disable_buttons();
            //MessageBox.Show("Now begin Linux scan", "Run MultiScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            process_start("/opt/ANTIVIRUS/MULTISCAN/linux_start_scan.sh");
            process_start("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/check_infected_files.sh");
            start_send_mail("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/logs/log_multiscan_linux.txt");
            MessageBox.Show("Finished Mount Linux Machines");
            //frml.open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/logs", "Select a Linux Log Files");
            frml.enable_buttons();
            frml.Close();
        }

        public void windows_start_scan()
        {

            frmMainForm frmw = new frmMainForm();
            frmw.disable_buttons();
            //MessageBox.Show("Now begin Windows scan", "Run MultiScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            process_start("/opt/ANTIVIRUS/MULTISCAN/windows_start_scan.sh");
            process_start("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/check_infected_files.sh");
            start_send_mail("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/logs/log_multiscan_windows.txt");
            MessageBox.Show("Finished Mount Windows Machines");
            //frmw.open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/logs", "Windows Log Files");
            frmw.enable_buttons();
            frmw.Close();
            
        }

        public void windows_linux_start_scan()
        {

            frmMainForm frm = new frmMainForm();
            frm.disable_buttons();
            //MessageBox.Show("Now begin Linux & Windows scan", "Run MultiScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            process_start("/opt/ANTIVIRUS/MULTISCAN/linux_start_scan.sh");
            process_start("/opt/ANTIVIRUS/MULTISCAN/windows_start_scan.sh");
            process_start("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/check_infected_files.sh");
            start_send_mail("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/logs/log_multiscan_linux.txt");
            start_send_mail("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/logs/log_multiscan_windows.txt");
            MessageBox.Show("Finished Scan Linux Machines");
            frm.open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/logs", "Select a Linux Log Files");
            process_start("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/check_infected_files.sh");
            MessageBox.Show("Finished Scan Windows Machines");
            frm.open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/logs", "Windows Log Files");
            frm.enable_buttons();
            frm.Close();
        }

        public void storage_start_scan()
        {

            frmMainForm frms = new frmMainForm();
            frms.disable_buttons();
            //MessageBox.Show("Now begin storage machine scan", "Run MultiScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            process_start("/opt/ANTIVIRUS/MULTISCAN/netapp_start_scan.sh");
            process_start("/opt/ANTIVIRUS/MULTISCAN/scan-netapp/check_infected_files.sh");
            start_send_mail("/opt/ANTIVIRUS/MULTISCAN/scan-netapp/logs/log_multiscan_storage.txt");
            MessageBox.Show("Finished Scan Storage Machines");
            frms.open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-netapp/logs", "Select a Storage Log Files");
            frms.enable_buttons();
            frms.Close();
        }

        public void local_start_scan()
        {
            frmMainForm frml = new frmMainForm();
            frml.disable_buttons();
            MessageBox.Show("Now begin local machine scan", "Run MultiScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            process_start("/opt/ANTIVIRUS/MULTISCAN/locamacine_start_scan.sh");
            frml.enable_buttons();
            frml.Close();
        }

        public void original_start_scan()
        {
            frmMainForm frmo = new frmMainForm();
            frmo.disable_buttons();
            MessageBox.Show("Now begin original MultiScan", "Run MultiScan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //process_start("/opt/ANTIVIRUS/MULTISCAN/create_txt_menu.sh");
            process_start("menu");
            frmo.enable_buttons();
            frmo.Close();
        }

        public void process_start(string pr_parameter)
        {

            ProcessStartInfo info = new ProcessStartInfo()
            {
                FileName = @"/bin/bash",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                //CreateNoWindow =false,
                //WindowStyle = ProcessWindowStyle.Normal,

                Arguments = string.Format("-c \" " + "gnome-terminal -x bash -ic " + pr_parameter + " \"")

            };

            Process process = new Process();
            process.StartInfo = info;
            process.Start();

            process.WaitForExit();


        }

    }

}