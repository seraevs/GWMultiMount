using System;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace MultiScan_1
{
    public partial class frmMainForm : Form
    {
        public string text;
        public string savePath;

        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        private static string _disable_enable;
        private static string _disable_enable_mail;
        public string _linux_scan;
        public static string _windows_scan;
        public static string _linux_windows_scan;
        public static string _storage_scan;

        private static string _day_of_month;
        private static string check_day;
        private static int _min;
        private static int _sec;
        private static int _hour;

        public frmMainForm()
        {
            InitializeComponent();
            start_config();
        }

        private void start_timer()
        {

            t.Interval = 1000; // specify interval time as you want
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            check_day = now.Day.ToString(); 
            
            XmlDocument xmlDoc = new XmlDocument();
            //path to XML document 
            XDocument doc = XDocument.Load("config.xml");
            //go to read name of the element is in lists
            var lists = doc.Descendants("Day_of_month");
            foreach (var list in lists)
            {
                if ((string)list.Attribute("day1") != null && (string)list.Attribute("day1") == check_day)
                {
                    _day_of_month = (string)list.Attribute("day1");
                    start_scan();
                }

                if ((string)list.Attribute("day2") != null && (string)list.Attribute("day2") == check_day)
                {
                    _day_of_month = (string)list.Attribute("day2");
                    start_scan();
                }

            }

        }

        private void start_scan()
        {
            //MessageBox.Show(_day_of_month);
            DateTime now = DateTime.Now; 

            XmlDocument xmlDoc = new XmlDocument();
            //path to XML document 
            XDocument doc = XDocument.Load("config.xml");
            // variable for init fame of the paragraph
            string temp = "ENABLED";
            //go to read name of the element is in lists
            var lists = doc.Descendants("Day_of_month");

                //Scheduled Task Started
                if (_day_of_month == check_day && _hour == now.Hour && _min == now.Minute && _sec == now.Second)
                {

                    this.Hide();
                    StartStopScan cls = new StartStopScan();
                    if (_linux_scan == temp)
                    { cls.linux_start_scan(); }

                    if (_windows_scan == temp)
                    { cls.windows_start_scan(); }

                    if (_linux_windows_scan == temp)
                    { cls.windows_linux_start_scan(); }

                    if (_storage_scan == temp)
                    { cls.storage_start_scan(); }
                    this.Show();
               }

        }

        private void start_config()
        {
            XmlDocument xmlDoc = new XmlDocument();
            //path to XML document 
            XDocument doc = XDocument.Load("config.xml");
            // variable for init fame of the paragraph
            var lists = doc.Descendants("OS_Scans");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                if ((string)list.Attribute("linux_scan") != null)
                { _linux_scan = (string)list.Attribute("linux_scan"); }

                if ((string)list.Attribute("windows_scan") != null)
                { _windows_scan = (string)list.Attribute("windows_scan"); }

                if ((string)list.Attribute("linux_windows_scan") != null)
                { _linux_windows_scan = (string)list.Attribute("linux_windows_scan"); }

                if ((string)list.Attribute("storage_scan") != null)
                { _storage_scan = (string)list.Attribute("storage_scan"); }
            }

           lists = doc.Descendants("Time");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                if ((string)list.Attribute("Hour") != null)
                { _hour = (int)list.Attribute("Hour"); }

                if ((string)list.Attribute("Minutes") != null)
                { _min = (int)list.Attribute("Minutes"); }

                if ((string)list.Attribute("Seconds") != null)
                { _sec = (int)list.Attribute("Seconds"); }
                               
            }

            lists = doc.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                _disable_enable = (string)list.Attribute("disable_enable");
                Auto_run_Scan.Text = _disable_enable;

                if (_disable_enable == "ENABLED")
                {
                    start_timer();
                    t.Start();
                }
                else
                {
                    t.Stop();
                }
            }

            XDocument doc1 = XDocument.Load("mail_config.xml");

            lists = doc1.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                _disable_enable_mail = (string)list.Attribute("disable_enable");
                lbl_AutoMail.Text = _disable_enable_mail;
            }

        }

        private void reboot_system()
		{
			// Variable
			string MessageBoxTitle = "Reboot system";
			string MessageBoxContent = "After finished scan recomended reboot";

			DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(dialogResult == DialogResult.Yes)
			{
                StartStopScan cls = new StartStopScan();
                cls.process_start("reboot");
			}
			else if (dialogResult == DialogResult.No)
			{
				//do something else
			}
		}

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();
            // If the destination directory doesn't exist, create it.
            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        public void disable_buttons()
        {

            btnScanLinux_Windows.Enabled = false;
            btnExit.Enabled= false;
            btnOpeLogLin.Enabled = false;
            btnOpeLogLocal.Enabled = false;
            btnOpeLogStorage.Enabled = false;
            btnOpeLogWin.Enabled = false;
            btnRunConfiguration.Enabled = false;
            btnRunOrigMultiScan.Enabled = false;
            btnRunWireShark.Enabled = false;
            btnScalLocalSys.Enabled = false;
            btnScanLinux.Enabled = false;
            btnScanStorage.Enabled = false;
            btnScanWindows.Enabled = false;

        }

        public void enable_buttons()
        {

            btnScanLinux_Windows.Enabled = true;
            btnExit.Enabled = true;
            btnOpeLogLin.Enabled = true;
            btnOpeLogLocal.Enabled = true;
            btnOpeLogStorage.Enabled= true;
            btnOpeLogWin.Enabled= true;
            btnRunConfiguration.Enabled = true;
            btnRunOrigMultiScan.Enabled = true;
            btnRunWireShark.Enabled = true;
            btnScalLocalSys.Enabled = true;
            btnScanLinux.Enabled = true;
            btnScanStorage.Enabled = true;
            btnScanWindows.Enabled = true;

        }

        private void btnRunConfiguration_Click(object sender, EventArgs e)
        {
			this.Hide();
            Form1 config_window = new Form1();
            config_window.ShowDialog();
			this.Show();
        }



        static void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
        {
            if (!destination.Exists)
            {
                destination.Create();
            }

            // Copy all files.
            FileInfo[] files = source.GetFiles();
            foreach (FileInfo file in files)
            {
                if (File.Exists(Path.Combine(destination.FullName,file.Name)))
                    File.Delete(Path.Combine(destination.FullName, file.Name));

                file.CopyTo(Path.Combine(destination.FullName,
                    file.Name));
            }

            // Process subdirectories.
            DirectoryInfo[] dirs = source.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                // Get destination directory.
                string destinationDir = Path.Combine(destination.FullName, dir.Name);

                if (Directory.Exists(Path.Combine(destination.FullName, dir.Name)))
                    Directory.Delete(Path.Combine(destination.FullName, dir.Name));
                // Call CopyDirectory() recursively.
                CopyDirectory(dir, new DirectoryInfo(destinationDir));
            }
        }

        public void open_log_file(string file_path, string file_title)
        {

            string MessageBoxTitle = "Save log file";
            string MessageBoxContent = "Save log file to another location";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Prepare a dummy string, thos would appear in the dialog
                    string dummyFileName = "Save Log Here";

                    SaveFileDialog sf = new SaveFileDialog();
                    // Feed the dummy name to the save dialog
                    sf.FileName = dummyFileName;

                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        // Now here's our save folder
                        savePath = Path.GetDirectoryName(sf.FileName);
                    }
                    DirectoryInfo src = new DirectoryInfo(@file_path);
                    DirectoryInfo dest = new DirectoryInfo(@savePath);
                    CopyDirectory(src, dest);
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }

            } 
			else if (dialogResult == DialogResult.No) 
			{
                try
                {
                Stream myStream = null;
                OpenFileDialog theDialog = new OpenFileDialog();
                theDialog.Title = file_title;
                theDialog.Filter = "All files (*.*)|*.*|TXT files (*.txt)|*.txt|TXT files (*.csv)|*.csv";
                theDialog.InitialDirectory = file_path;
                if (theDialog.ShowDialog() == DialogResult.OK)
                {
                        if ((myStream = theDialog.OpenFile()) != null)
                        {
                            using (myStream)
                            {


                                var fileStream = new FileStream(theDialog.FileName.ToString(), FileMode.Open, FileAccess.Read);
                                using (var streamReader = new StreamReader(fileStream, UTF8Encoding.UTF8))
                                {
                                    text = streamReader.ReadToEnd();
                                    
                                    frmOpenSaveFile formSave = new frmOpenSaveFile(text);
                                    formSave.Show();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }



          }

        private void exit_prog()
        {

            //System.Environment.Exit(0);
            System.Windows.Forms.Application.Exit();

        }

        private void aboutMultiScanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about_window = new AboutBox1();
            about_window.ShowDialog();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit_prog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //SendMail snd_ml = new SendMail();
            //snd_ml.send_mail("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/logs/log_multiscan_linux.txt");
            exit_prog();
        }

        public void btnScanLinux_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartStopScan cls = new StartStopScan();          
            cls.linux_start_scan();
            this.Show();
        }

        private void btnScanWindows_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartStopScan cls = new StartStopScan();
            cls.windows_start_scan();
            this.Show();
        }

        private void btnScanLinux_Windows_Click(object sender, EventArgs e)
        {
            StartStopScan cls = new StartStopScan();
            cls.windows_linux_start_scan();
        }

        private void btnScanStorage_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartStopScan cls = new StartStopScan();
            cls.storage_start_scan();
            this.Show();
        }

        private void btnScalLocalSys_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartStopScan cls = new StartStopScan();
            cls.local_start_scan();
            this.Show();
        }



        private void btnRunOrigMultiScan_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartStopScan cls = new StartStopScan();
            cls.original_start_scan();
            this.Show();
        }

        private void btnRunWireShark_Click(object sender, EventArgs e)
        {
			ProcessStartInfo info = new ProcessStartInfo()
			{
				FileName = @"/bin/bash",
				UseShellExecute = false,
				RedirectStandardOutput = true,
				CreateNoWindow =false,
				WindowStyle = ProcessWindowStyle.Normal,			

				Arguments = string.Format("-c \" " + "wireshark" + " \"")

			};

			Process process = new Process();
			process.StartInfo = info;
			process.Start();

        }

        private void btnOpeLogWin_Click(object sender, EventArgs e)
        {
			open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/logs", "Windows Log Files");
        }

        private void btnOpeLogLin_Click(object sender, EventArgs e)
        {
            open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/logs", "Select a Linux Log Files");
        }

        private void btnOpeLogStorage_Click(object sender, EventArgs e)
        {
            open_log_file("/opt/ANTIVIRUS/MULTISCAN/scan-netapp/logs", "Select a Storage Log Files");
        }

        private void btnOpeLogLocal_Click(object sender, EventArgs e)
        {
            open_log_file("/opt/ANTIVIRUS/MULTISCAN/LOCAL_MACHINE_MULTISCAN", "Select a Local System Log Files");
        }

        private void updateAVEssetAVGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disable_buttons();
            this.Hide();
			MessageBox.Show("Now begin update AVG AV", "Update AVG AV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            StartStopScan cls = new StartStopScan();
            cls.process_start("avgupdate");
            this.Show();
            enable_buttons();
        }

        private void updateAVEsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            disable_buttons();
            this.Hide();
			MessageBox.Show("Now begin update Eset AV", "Update Eset AV", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            StartStopScan cls = new StartStopScan();
            cls.process_start("esets_update");
            this.Show();
            enable_buttons();
        }

        private void saveMultiScanToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog brwsr = new FolderBrowserDialog();

            //Check to see if the user clicked the cancel button
            if (brwsr.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {

                string newDirectoryPath = brwsr.SelectedPath;
				MessageBox.Show("Folder Saved from: /opt/ANTIVIRUS/MULTISCAN" + " to: " + newDirectoryPath + "/MULTISCAN");
                // Copy from the current directory, include subdirectories.
				DirectoryCopy(@"/opt/ANTIVIRUS/MULTISCAN", @newDirectoryPath + @"/MULTISCAN", true);

            }
        }

        private void restoreMultiScanFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog brwsr = new FolderBrowserDialog();

            //Check to see if the user clicked the cancel button
            if (brwsr.ShowDialog() == DialogResult.Cancel)
                return;
            else
            {

                string newDirectoryPath = brwsr.SelectedPath;
				MessageBox.Show("Folder Restored fom " + newDirectoryPath + " to: /opt/ANTIVIRUS/MULTISCAN");
                // Copy from the current directory, include subdirectories.
				DirectoryCopy(@newDirectoryPath, @"/opt/ANTIVIRUS/MULTISCAN", true);
                StartStopScan cls = new StartStopScan();
                cls.process_start("/opt/grant_full_permissions.sh");

            }

        }

        private void scanNetworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Check_Network check_networks = new Check_Network();
            check_networks.Show(this);
            //this.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CheckNetworkStatus checkNet = new CheckNetworkStatus();
            checkNet.Show(this);
        }

        private void unmountAllDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unmountAllDevices();
        }

        private void btnUnMount_Click(object sender, EventArgs e)
        {
            unmountAllDevices();
        }

        private void unmountAllDevices()
        {
            StartStopScan cls = new StartStopScan();
            cls.linux_unmount();
        }
    }
}

