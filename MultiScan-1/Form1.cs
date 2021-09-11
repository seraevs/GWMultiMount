using System;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MultiScan_1
{
    //public event System.Windows.Forms.TabControlEventHandler Selected;
    public partial class Form1 : Form
    {
        string filePathLin = "/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/data.txt";
        string fileRootPass = "/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/config.txt";
        string filexcludedLinux = "/opt/ANTIVIRUS/MULTISCAN/scan-comp-linux/excluded_files.txt";

        string filePathWin = "/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/data.txt";
        string filePathWinPart = "/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/partitions.txt";
        string filePathWinConfig = "/opt/ANTIVIRUS/MULTISCAN/scan-comp-windows/config.txt";

        string filePathStorage = "/opt/ANTIVIRUS/MULTISCAN/scan-netapp/data.txt";
        string filePathStoragePart = "/opt/ANTIVIRUS/MULTISCAN/scan-netapp/partitions.txt";
        string filePathStorageConfig = "/opt/ANTIVIRUS/MULTISCAN/scan-netapp/config.txt";

        string filePathrootOSFiles = "/opt/ANTIVIRUS/MULTISCAN/root.txt";

        public Form1()
        {
            InitializeComponent();
            ReadFileConfiguration();

            //OpenFileEdit(txtRootConf, fileRootPass);

            ViewIPaddress(filePathLin);
            ViewIPaddress(filePathWin);
            ViewIPaddress(filePathStorage);

            ViewInfoText(filexcludedLinux);
            ViewInfoText(filePathWinPart);
            ViewInfoText(filePathStoragePart);

        }

        private void OpenFileEdit(TextBox txt_dialog, string path_to_file)
        {

            StreamReader sr;
            sr = new StreamReader(@path_to_file);
            String line = sr.ReadToEnd();
            txt_dialog.Text = line;
            sr.Close();
            sr.Dispose();

        }

        private void SaveFile(TextBox txt_dialog, string path_to_save_file)
        {
            StreamWriter sw = new StreamWriter(@path_to_save_file);
            sw.Write(txt_dialog.Text);
            sw.Close();

        }

        private void RestoreFiles(string sourcePath, string targetPath)
        {

            string sourcePaths = sourcePath;
            string targetPaths = targetPath;
            if (!Directory.Exists(targetPath))
            {
                Directory.CreateDirectory(targetPath);
            }
            foreach (var srcPath in Directory.GetFiles(sourcePaths))
            {
                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path
                File.Copy(srcPath, srcPath.Replace(sourcePaths, targetPaths), true);
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ////////////// Begin Linux files Editing ///////////////////////////

        private void BtnAddNewIP_Click(object sender, EventArgs e)
        {
            AddNewIP(textBoxIP1.Text.ToString(), textBoxIP2.Text.ToString(), textBoxIP3.Text.ToString(), textBoxIP4.Text.ToString(), filePathLin);
        }

        private void BtnDeleteCheckedIP_Click(object sender, EventArgs e)
        {

            while (chkLstIPAddress.CheckedItems.Count > 0)
            {
                chkLstIPAddress.Items.RemoveAt(chkLstIPAddress.CheckedIndices[0]);
            }
            File.Delete(filePathLin);



            foreach (var item in chkLstIPAddress.Items)
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                writeData.WriteToTextFile(filePathLin, item.ToString());
            }

            //ViewIPaddress();
        }

        private void BtnSaveRoot_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => btnLNXsaveFileConfTask());
        }

        private void CloseUsedFile()
        {
            System.IO.FileStream fs;
            try
            {
                fs = System.IO.File.Open(fileRootPass, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Read, System.IO.FileShare.None);
                fs.Close();
            }
            catch (System.IO.IOException ex)
            {
                //MessageBox.Show("File " + fileRootPass + " in use", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CloseUsedFile();
            }
        }

        private void btnLNXsaveFileConfTask()
        {
            CloseUsedFile();

            if (txtRootConf.Text != "")
            {
                StreamWriter sw = new StreamWriter(fileRootPass);
                sw.Write("PASSWORDIK=" + txtRootConf.Text);
                sw.Close();

                MessageBox.Show("Pasword for root saved succefull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReadFileConfiguration();
                MessageBox.Show("Field 'Linux root password is empty'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstIPAddress.Items.Count; i++)
            {
                chkLstIPAddress.SetItemChecked(i, true);
            }
        }

        private void RestratRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstIPAddress.Items.Count; i++)
            {
                chkLstIPAddress.SetItemChecked(i, false);
            }
        }

        // begin config exlude linux files //

        private void ViewExcludedLinux()
        {
            OpenFileEdit(txtLNXexistingsFiles, filePathrootOSFiles);
            ReadFileConfiguration();

            if (!File.Exists(filexcludedLinux))
            {
                File.Create(filexcludedLinux).Dispose();
            }
            else
            {
                chkListExcludedLinux.Items.Clear();
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(filexcludedLinux);

                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        chkListExcludedLinux.Items.Add(line);
                    }

                }
                file.Close();
            }
        }
        private void BtnADDnewEexludeLinuxFile_Click(object sender, EventArgs e)
        {
            ADDnewText(txtExcludedLinux.Text.ToString(), filexcludedLinux);
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListExcludedLinux.Items.Count; i++)
            {
                chkListExcludedLinux.SetItemChecked(i, true);
            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListExcludedLinux.Items.Count; i++)
            {
                chkListExcludedLinux.SetItemChecked(i, false);
            }
        }

        private void BtnDeleteExcludedFilesLinux_Click(object sender, EventArgs e)
        {

            while (chkListExcludedLinux.CheckedItems.Count > 0)
            {
                chkListExcludedLinux.Items.RemoveAt(chkListExcludedLinux.CheckedIndices[0]);
            }
            File.Delete(filexcludedLinux);


            foreach (var item in chkListExcludedLinux.Items)
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                writeData.WriteToTextFile(filexcludedLinux, item.ToString());
            }
            ViewInfoText(filexcludedLinux);
        }
        // end config exlude linux files //
        ////////////// END Linux files Editing ///////////////////////////

        ////////////// Begin Windows files Editing ///////////////////////////

        private void BtnSaveWindows_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != "" && textBoxAdminPass.Text != "" && textBoxDomainName.Text != "")
            {
                string[] lines = { "USERNAME=" + textBoxUserName.Text, "PASSWORDIK=" + textBoxAdminPass.Text, "DOMANIK=" + textBoxDomainName.Text };
                System.IO.File.WriteAllLines(filePathWinConfig, lines);
                MessageBox.Show("Data saved succefull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ReadFileConfiguration();
                MessageBox.Show("One from fields is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // IP address configuration //
        private void AddnewIPWin_Click(object sender, EventArgs e)
        {
            AddNewIP(textBoxIPWin1.Text.ToString(), textBoxIPWin2.Text.ToString(), textBoxIPWin3.Text.ToString(), textBoxIPWin4.Text.ToString(), filePathWin);
        }

        private void DeleteCheckedIPWin_Click(object sender, EventArgs e)
        {
            while (chkLstIPAddressWin.CheckedItems.Count > 0)
            {
                chkLstIPAddressWin.Items.RemoveAt(chkLstIPAddressWin.CheckedIndices[0]);
            }
            File.Delete(filePathWin);



            foreach (var item in chkLstIPAddressWin.Items)
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                writeData.WriteToTextFile(filePathWin, item.ToString());
            }

            ViewIPaddress(filePathWin);
        }

        private void CheckAllWin_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstIPAddressWin.Items.Count; i++)
            {
                chkLstIPAddressWin.SetItemChecked(i, true);
            }
        }

        private void Uncheck_ALLWin_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstIPAddressWin.Items.Count; i++)
            {
                chkLstIPAddressWin.SetItemChecked(i, false);
            }
        }
        // partition configuration //

        private void ViewPartitionWin()
        {
            if (!File.Exists(filePathWinPart))
            {
                File.Create(filePathWinPart).Dispose();
            }
            else
            {
                chkListPartitionWin.Items.Clear();
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(filePathWinPart);

                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        chkListPartitionWin.Items.Add(line);
                    }

                }
                file.Close();
            }
        }
        private void AddNewparttionWin_Click(object sender, EventArgs e)
        {
            ADDnewText(txtPartitionsWin.Text.ToString(), filePathWinPart);
        }

        private void DelChecPartitionWin_Click(object sender, EventArgs e)
        {
            while (chkListPartitionWin.CheckedItems.Count > 0)
            {
                chkListPartitionWin.Items.RemoveAt(chkListPartitionWin.CheckedIndices[0]);
            }
            File.Delete(filePathWinPart);

            foreach (var item in chkListPartitionWin.Items)
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                writeData.WriteToTextFile(filePathWinPart, item.ToString());
            }

            ViewPartitionWin();
        }

        private void CheckAllWinPart_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListPartitionWin.Items.Count; i++)
            {
                chkListPartitionWin.SetItemChecked(i, true);
            }
        }

        private void UnCheckAllWinPart_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListPartitionWin.Items.Count; i++)
            {
                chkListPartitionWin.SetItemChecked(i, false);
            }
        }
        ////////////// END Windows files Editing ///////////////////////////

        ////////////// Begin Storage files Editing /////////////////////////
        private void ViewIPaddressStorage()
        {
            if (!File.Exists(filePathStorage))
            {
                File.Create(filePathStorage).Dispose();
            }
            else
            {
                chkLstIPAddressStorage.Items.Clear();
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(filePathStorage);

                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        chkLstIPAddressStorage.Items.Add(line);
                    }

                }
                file.Close();
            }
        }

        private void BtnSavceStoreage_Click(object sender, EventArgs e)
        {
            if (textBoxUserNameStorage.Text != "" && textBoxPassStorage.Text != "" && textBoxDomainStorage.Text != "")
            {
                if (File.Exists(filePathStorageConfig))
                {
                    string[] lines = { "USERNAME=" + textBoxUserNameStorage.Text, "PASSWORDIK=" + textBoxPassStorage.Text, "DOMANIK=" + textBoxDomainStorage.Text };
                    System.IO.File.WriteAllLines(filePathStorageConfig, lines);
                    MessageBox.Show("Data saved succefull", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                ReadFileConfiguration();
                MessageBox.Show("One from fields is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // ip address configuration //
        private void AddnewIPStorage_Click(object sender, EventArgs e)
        {
            AddNewIP(textBoxStoreIP1.Text.ToString(), textBoxStoreIP1.Text.ToString(), textBoxStoreIP1.Text.ToString(), textBoxStoreIP1.Text.ToString(), filePathStorage);
        }

        private void DeleteCheckedIPStorage_Click(object sender, EventArgs e)
        {
            while (chkLstIPAddressStorage.CheckedItems.Count > 0)
            {
                chkLstIPAddressStorage.Items.RemoveAt(chkLstIPAddressStorage.CheckedIndices[0]);
            }
            File.Delete(filePathStorage);



            foreach (var item in chkLstIPAddressStorage.Items)
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                writeData.WriteToTextFile(filePathStorage, item.ToString());
            }

            ViewIPaddressStorage();
        }

        private void CheckAllStorage_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstIPAddressStorage.Items.Count; i++)
            {
                chkLstIPAddressStorage.SetItemChecked(i, true);
            }
        }

        private void UncheckAllStorage_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkLstIPAddressStorage.Items.Count; i++)
            {
                chkLstIPAddressStorage.SetItemChecked(i, false);
            }
        }

        // end ip address configuration //

        // partition configuration //
        private void AddNewparttionStorage_Click(object sender, EventArgs e)
        {
            ADDnewText(txtPartitionsStorage.Text.ToString(), filePathStoragePart);
        }

        private void DelChecPartitionStorage_Click(object sender, EventArgs e)
        {
            while (chkListPartitionStorage.CheckedItems.Count > 0)
            {
                chkListPartitionStorage.Items.RemoveAt(chkListPartitionStorage.CheckedIndices[0]);
            }
            File.Delete(filePathStoragePart);

            foreach (var item in chkListPartitionStorage.Items)
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                writeData.WriteToTextFile(filePathStoragePart, item.ToString());
            }

            ViewPartitionStorage();
        }

        private void CheckAllStoragePartition_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListPartitionStorage.Items.Count; i++)
            {
                chkListPartitionStorage.SetItemChecked(i, true);
            }
        }

        private void UncheckAllStoragePartition_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < chkListPartitionStorage.Items.Count; i++)
            {
                chkListPartitionStorage.SetItemChecked(i, false);
            }
        }

        private void ViewPartitionStorage()
        {
            if (!File.Exists(filePathStoragePart))
            {
                File.Create(filePathStoragePart).Dispose();
            }
            else
            {
                chkListPartitionStorage.Items.Clear();
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(filePathStoragePart);

                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        chkListPartitionStorage.Items.Add(line);
                    }

                }
                file.Close();
            }
        }

        ////////////// END Storage files Editing ///////////////////////////

        ////////////// Begin XML files Editing /////////////////////////////

        bool checkStateAutoScan = true;
        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            int result;
            checkStateAutoScan = true;
            //path to XML document 
            XDocument docScan = XDocument.Load("config.xml");

            var listsScan = docScan.Descendants("Time");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("Hour") != null)
                {
                    if ((int.TryParse(txtHour.Text.ToString(), out result)) && txtHour.Text.ToString().Length <=2)
                    {
                        list.Attribute("Hour").Value = txtHour.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current numeric parameters: '0,1,2,3,4,5,6,7,8,9' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtHour.Text = list.Attribute("Hour").Value;
                        checkStateAutoScan = false;
                    }
                }                


                if ((string)list.Attribute("Minutes") != null)
                {
                    if ((string)list.Attribute("Seconds") != null)
                    {
                        if ((int.TryParse(txtMinutes.Text.ToString(), out result)) && txtMinutes.Text.ToString().Length <= 2)
                        {
                            list.Attribute("Minutes").Value = txtMinutes.Text;
                        }
                        else
                        {
                            MessageBox.Show("Please insert current numeric parameters: '0,1,2,3,4,5,6,7,8,9' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtMinutes.Text = list.Attribute("Minutes").Value;
                            checkStateAutoScan = false;
                        }
                    }
                }
                

                if ((string)list.Attribute("Seconds") != null)
                {
                    if ((int.TryParse(txtSeconds.Text.ToString(), out result)) && txtSeconds.Text.ToString().Length <= 2)
                    {
                        list.Attribute("Seconds").Value = txtSeconds.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current numeric parameters: '0,1,2,3,4,5,6,7,8,9' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSeconds.Text = list.Attribute("Seconds").Value;
                        checkStateAutoScan = false;
                    }                   
                }
                
            }

            listsScan = docScan.Descendants("Day_of_month");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("day1") != null)
                {
                    if ((int.TryParse(txtDay1.Text.ToString(), out result)) && txtDay1.Text.ToString().Length <= 2)
                    {
                        list.Attribute("day1").Value = txtDay1.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current numeric parameters: '0,1,2,3,4,5,6,7,8,9' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDay1.Text = list.Attribute("day1").Value;
                        checkStateAutoScan = false;
                    }
                }
                

                if ((string)list.Attribute("day2") != null)
                {
                    if ((int.TryParse(txtDay2.Text.ToString(), out result)) && txtDay2.Text.ToString().Length <= 2)
                    {
                        list.Attribute("day2").Value = txtDay2.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current numeric parameters: '0,1,2,3,4,5,6,7,8,9' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtDay2.Text = list.Attribute("day2").Value;
                        checkStateAutoScan = false;
                    }
                }
            }

            listsScan = docScan.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("disable_enable") != null)
                {
                    if (txtAuthoscan.Text.ToUpper() == "DISABLED" || txtAuthoscan.Text.ToUpper() == "ENABLED")
                    {
                        list.Attribute("disable_enable").Value = txtAuthoscan.Text.ToUpper();
                        txtAuthoscan.Text = list.Attribute("disable_enable").Value;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current parameters: 'DISABLED / ENABLED' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAuthoscan.Text = list.Attribute("disable_enable").Value;
                        checkStateAutoScan = false;
                    }
                }
                
            }

            listsScan = docScan.Descendants("OS_Scans");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("linux_scan") != null)
                {
                    if (txtLinuxScan.Text.ToUpper() == "DISABLED" || txtLinuxScan.Text.ToUpper() == "ENABLED")
                    {
                        list.Attribute("linux_scan").Value = txtLinuxScan.Text.ToUpper();
                        txtLinuxScan.Text = list.Attribute("linux_scan").Value;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current parameters: 'DISABLED / ENABLED' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLinuxScan.Text = list.Attribute("linux_scan").Value;
                        checkStateAutoScan = false;
                    }
                    
                }
                

                if ((string)list.Attribute("windows_scan") != null)
                {
                    if (txtWindowsScan.Text.ToUpper() == "DISABLED" || txtWindowsScan.Text.ToUpper() == "ENABLED")
                    {
                        list.Attribute("windows_scan").Value = txtWindowsScan.Text.ToUpper();
                        txtWindowsScan.Text = list.Attribute("windows_scan").Value;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current parameters: 'DISABLED / ENABLED' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtWindowsScan.Text = list.Attribute("windows_scan").Value;
                        checkStateAutoScan = false;
                    }                   
                }
                

                if ((string)list.Attribute("linux_windows_scan") != null)
                {
                    if (txtWindowsLinuxScan.Text.ToUpper() == "DISABLED" || txtWindowsLinuxScan.Text.ToUpper() == "ENABLED")
                    {
                        list.Attribute("linux_windows_scan").Value = txtWindowsLinuxScan.Text.ToUpper();
                        txtWindowsLinuxScan.Text = list.Attribute("linux_windows_scan").Value;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current parameters: 'DISABLED / ENABLED' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtWindowsLinuxScan.Text = list.Attribute("linux_windows_scan").Value;
                        checkStateAutoScan = false;
                    }
                }
                

                if ((string)list.Attribute("storage_scan") != null)
                {
                    if (txtStorageScan.Text.ToUpper() == "DISABLED" || txtStorageScan.Text.ToUpper() == "ENABLED")
                    {
                        list.Attribute("storage_scan").Value = txtStorageScan.Text.ToUpper();
                        txtStorageScan.Text = list.Attribute("storage_scan").Value;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current parameters: 'DISABLED / ENABLED' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtStorageScan.Text = list.Attribute("storage_scan").Value;
                        checkStateAutoScan = false;
                    }
                }
                
            }

            docScan.Save("config.xml");

            if (checkStateAutoScan)
            {
                MessageBox.Show("Data currently changed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        ////////////// END XML files Editing ///////////////////////////

        /////////// BEGIN XML mail files Editing ///////////////////////

        bool checkmailConfig = true;
        private void btn_Save_File_Click(object sender, EventArgs e)
        {
            bool checkmailConfig = true;
            //path to XML document 
            XDocument doc = XDocument.Load("mail_config.xml");

            var lists = doc.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
             

                if ((string)list.Attribute("disable_enable") != null)
                {
                    if (txtAuthoMail.Text.ToUpper() == "DISABLED" || txtAuthoMail.Text.ToUpper() == "ENABLED")
                    {
                        list.Attribute("disable_enable").Value = txtAuthoMail.Text.ToUpper();
                        txtAuthoMail.Text = list.Attribute("disable_enable").Value;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current parameters: 'DISABLED / ENABLED' ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtAuthoMail.Text = list.Attribute("disable_enable").Value;
                        checkmailConfig = false;
                    }
                }

            }

            lists = doc.Descendants("mail_conf");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                if ((string)list.Attribute("smtp_client") != null)
                {
                    if (txtSMTPconf.Text != "")
                    {
                        list.Attribute("smtp_client").Value = txtSMTPconf.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSMTPconf.Text = list.Attribute("smtp_client").Value;
                        checkmailConfig = false;
                    }
                }
                    

                if ((string)list.Attribute("my_address") != null)
                {
                    if (txtMyEmail.Text != "")
                    {
                        list.Attribute("my_address").Value = txtMyEmail.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMyEmail.Text = list.Attribute("my_address").Value;
                        checkmailConfig = false;
                    }                   
                }

                if ((string)list.Attribute("to_send_address") != null)
                {
                    if (txtEmail1.Text != "")
                    {
                        list.Attribute("to_send_address").Value = txtEmail1.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail1.Text = list.Attribute("to_send_address").Value;
                        checkmailConfig = false;
                    } 
                }

                if ((string)list.Attribute("to_send_address1") != null)
                {
                    if (txtEmail2.Text != "")
                    {
                        list.Attribute("to_send_address1").Value = txtEmail2.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail2.Text = list.Attribute("to_send_address1").Value;
                        checkmailConfig = false;
                    }
                }

                if ((string)list.Attribute("to_send_address2") != null)
                {
                    if (txtEmail3.Text != "")
                    {
                        list.Attribute("to_send_address2").Value = txtEmail3.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtEmail3.Text = list.Attribute("to_send_address2").Value;
                        checkmailConfig = false;
                    }
                }

                if ((string)list.Attribute("mail_subject") != null)
                {
                    if (txtMailSubject.Text != "")
                    {
                        list.Attribute("mail_subject").Value = txtMailSubject.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMailSubject.Text = list.Attribute("mail_subject").Value;
                        checkmailConfig = false;
                    }
                }

                if ((string)list.Attribute("mail_body") != null)
                {
                    if (txtMailBody.Text != "")
                    {
                        list.Attribute("mail_body").Value = txtMailBody.Text;
                    }
                    else
                    {
                        MessageBox.Show("Please insert current not empty parameter!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtMailBody.Text = list.Attribute("mail_body").Value;
                        checkmailConfig = false;
                    }
                }
            }
            doc.Save("mail_config.xml");

            if (checkmailConfig)
            {
                MessageBox.Show("Data currently changed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /////////// END XML mail files Editing ///////////////////////
        }


        ///
        private void ReadFileConfiguration()
        {

            if (File.Exists(fileRootPass))
            {
                TextReader srLinux = new StreamReader(fileRootPass);
                string linuxPass = srLinux.ReadLine();
                if (!String.IsNullOrEmpty(linuxPass))
                    txtRootConf.Text = linuxPass.Substring(linuxPass.IndexOf('=') + 1);

            }
            /////////////////////////////////////// Windows configuration //////////////////////////////////////////
            if (File.Exists(filePathWinConfig))
            {
                TextReader srWindows = new StreamReader(filePathWinConfig);
                string winUserName = srWindows.ReadLine();
                if (!String.IsNullOrEmpty(winUserName))
                    textBoxUserName.Text = winUserName.Substring(winUserName.IndexOf('=') + 1);

                string winPass = srWindows.ReadLine();
                if (!String.IsNullOrEmpty(winPass))
                    textBoxAdminPass.Text = winPass.Substring(winPass.IndexOf('=') + 1);

                string winDomain = srWindows.ReadLine();
                if (!String.IsNullOrEmpty(winDomain))
                    textBoxDomainName.Text = winDomain.Substring(winDomain.IndexOf('=') + 1);

                srWindows.Close();
                srWindows.Dispose();
            }
            /////////////////////////////////// The END windows configuration //////////////////////////////////////
            ///
            /////////////////////////////////////// Storage configuration //////////////////////////////////////////
            if (File.Exists(filePathStorageConfig))
            {
                TextReader srWindowsST = new StreamReader(filePathStorageConfig);
                string winUserNameST = srWindowsST.ReadLine();
                if (!String.IsNullOrEmpty(winUserNameST))
                    textBoxUserNameStorage.Text = winUserNameST.Substring(winUserNameST.IndexOf('=') + 1);

                string winPassST = srWindowsST.ReadLine();
                if (!String.IsNullOrEmpty(winPassST))
                    textBoxPassStorage.Text = winPassST.Substring(winPassST.IndexOf('=') + 1);

                string winDomainST = srWindowsST.ReadLine();
                if (!String.IsNullOrEmpty(winDomainST))
                    textBoxDomainStorage.Text = winDomainST.Substring(winDomainST.IndexOf('=') + 1);

                srWindowsST.Close();
                srWindowsST.Dispose();
            }
            ////////////////////////////////// The END Storage configuration ///////////////////////////////////////

            ///////////////////////////////////// Autho Scan configuration //////////////////////////////////////////
            //path to XML document 
            XDocument docScan = XDocument.Load("config.xml");

            var listsScan = docScan.Descendants("Time");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("Hour") != null)
                { txtHour.Text = list.Attribute("Hour").Value; }

                if ((string)list.Attribute("Minutes") != null)
                { txtMinutes.Text = list.Attribute("Minutes").Value; }

                if ((string)list.Attribute("Seconds") != null)
                { txtSeconds.Text = list.Attribute("Seconds").Value; }
            }

            listsScan = docScan.Descendants("Day_of_month");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("day1") != null)
                { txtDay1.Text = list.Attribute("day1").Value; }

                if ((string)list.Attribute("day2") != null)
                { txtDay2.Text = list.Attribute("day2").Value; }
            }

            listsScan = docScan.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("disable_enable") != null)
                { txtAuthoscan.Text = list.Attribute("disable_enable").Value; }
            }

            listsScan = docScan.Descendants("OS_Scans");
            //go to read name of the element is in lists
            foreach (var list in listsScan)
            {
                if ((string)list.Attribute("linux_scan") != null)
                { txtLinuxScan.Text = list.Attribute("linux_scan").Value; }

                if ((string)list.Attribute("windows_scan") != null)
                { txtWindowsScan.Text = list.Attribute("windows_scan").Value; }

                if ((string)list.Attribute("linux_windows_scan") != null)
                { txtWindowsLinuxScan.Text = list.Attribute("linux_windows_scan").Value; }

                if ((string)list.Attribute("storage_scan") != null)
                { txtStorageScan.Text = list.Attribute("storage_scan").Value; }
            }
            ///////////////////////////////// The END Atho Scan configuration //////////////////////////////////////

            ////////////////////////////////// Atho Send Mail configuration ////////////////////////////////////////  

            //path to XML document 
            XDocument doc = XDocument.Load("mail_config.xml");

            var lists = doc.Descendants("Disabled_tasks");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                if ((string)list.Attribute("disable_enable") != null)
                { txtAuthoMail.Text = list.Attribute("disable_enable").Value; }               
            }

            lists = doc.Descendants("mail_conf");
            //go to read name of the element is in lists
            foreach (var list in lists)
            {
                if ((string)list.Attribute("smtp_client") != null)
                { txtSMTPconf.Text = list.Attribute("smtp_client").Value; }

                if ((string)list.Attribute("my_address") != null)
                { txtMyEmail.Text = list.Attribute("my_address").Value; }

                if ((string)list.Attribute("to_send_address") != null)
                { txtEmail1.Text = list.Attribute("to_send_address").Value; }

                if ((string)list.Attribute("to_send_address1") != null)
                { txtEmail2.Text = list.Attribute("to_send_address1").Value; }

                if ((string)list.Attribute("to_send_address2") != null)
                { txtEmail3.Text = list.Attribute("to_send_address2").Value; }

                if ((string)list.Attribute("mail_subject") != null)
                { txtMailSubject.Text = list.Attribute("mail_subject").Value; }

                if ((string)list.Attribute("mail_body") != null)
                { txtMailBody.Text = list.Attribute("mail_body").Value; }
            }
            ///////////////////////////////  The END Atho Send Mail configuration //////////////////////////////////
        }
            /////////////////////////////////  Begin Ip addresses configuration ////////////////////////////////////
        private void ViewIPaddress(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            else
            {
                if (filePath == filePathLin)
                {
                    chkLstIPAddress.Items.Clear();
                    textBoxIP1.Text = String.Empty;
                    textBoxIP2.Text = String.Empty;
                    textBoxIP3.Text = String.Empty;
                    textBoxIP4.Text = String.Empty;
                }

                if (filePath == filePathWin)
                {
                    chkLstIPAddressWin.Items.Clear();
                    textBoxIPWin1.Text = String.Empty;
                    textBoxIPWin2.Text = String.Empty;
                    textBoxIPWin3.Text = String.Empty;
                    textBoxIPWin4.Text = String.Empty;
                }

                if (filePath == filePathStorage)
                {
                    chkLstIPAddressStorage.Items.Clear();
                    textBoxStoreIP1.Text = String.Empty;
                    textBoxStoreIP2.Text = String.Empty;
                    textBoxStoreIP3.Text = String.Empty;
                    textBoxStoreIP4.Text = String.Empty;
                }

                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(filePath);

                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        if (filePath == filePathLin)
                        {
                            chkLstIPAddress.Items.Add(line);
                        }

                        if (filePath == filePathWin)
                        {
                            chkLstIPAddressWin.Items.Add(line);
                        }

                        if (filePath == filePathStorage)
                        {
                            chkLstIPAddressStorage.Items.Add(line);
                        }
                    }

                }
                file.Close();
            }
        }
        public void AddNewIP(string ip1, string ip2, string ip3, string ip4, string filePaths)
        {

            if (ip1.Length <= 3 && ip2.Length <= 3 && ip3.Length <= 3 && ip4.Length <= 3)
            {

                if (ip1 != "" && ip2 != "" && ip3 != "" && ip4 != "")
                {
                    int n1;
                    bool isNumeric1 = int.TryParse(ip1, out n1);
                    int n2;
                    bool isNumeric2 = int.TryParse(ip2, out n2);
                    int n3;
                    bool isNumeric3 = int.TryParse(ip3, out n3);
                    int n4;
                    bool isNumeric4 = int.TryParse(ip4, out n4);

                    if (isNumeric1 && isNumeric2 && isNumeric3 && isNumeric4)
                    {
                        ClassAddToTextFile writeData = new ClassAddToTextFile();
                        writeData.WriteToTextFile(filePaths, ip1 + "." + ip2 + "." + ip3 + "." + ip4); ;

                        ViewIPaddress(filePaths);
                        ip1 = String.Empty;
                        ip2 = String.Empty;
                        ip3 = String.Empty;
                        ip4 = String.Empty;
                    }
                    else MessageBox.Show("Your IP address need only numrtic parameters");
                }
                else MessageBox.Show("Your IP address is not currently");
            }
            else MessageBox.Show("Your IP address is not currently");
        }
        /////////////////////////////////  END Ip addresses configuration ///////////////////////////////////////

        /////////////////////////////////  Begin partitions configuration ///////////////////////////////////////

        private void ViewInfoText(string filePath)
        {
            if (filexcludedLinux == filePath)
                ViewExcludedLinux();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
            else
            {
                if (filexcludedLinux == filePath)
                {
                    chkListExcludedLinux.Items.Clear();
                    txtExcludedLinux.Text = String.Empty;
                }
                    
                if (filePathWinPart == filePath)
                {
                    chkListPartitionWin.Items.Clear();
                    txtPartitionsWin.Text = String.Empty;
                }
                    

                if (filePathStoragePart == filePath)
                {
                    chkListPartitionStorage.Items.Clear();
                    txtPartitionsStorage.Text = String.Empty;
                }
                    
                string line;
                // Read the file and display it line by line.
                System.IO.StreamReader file = new System.IO.StreamReader(filePath);

                while ((line = file.ReadLine()) != null)
                {
                    if (line != "")
                    {
                        if (filexcludedLinux == filePath)
                            chkListExcludedLinux.Items.Add(line);

                        if (filePathWinPart == filePath)
                            chkListPartitionWin.Items.Add(line);

                        if (filePathStoragePart == filePath)
                            chkListPartitionStorage.Items.Add(line);
                    }
                }
                file.Close();
            }
        }
        private void ADDnewText(string data, string filePath)
        {
            if (data != "")
            {
                ClassAddToTextFile writeData = new ClassAddToTextFile();
                if (filexcludedLinux == filePath)
                {
                    writeData.WriteToTextFile(filePath, "./" + data);
                }
                else writeData.WriteToTextFile(filePath, data);

                ViewInfoText(filePath);               
            }
            else MessageBox.Show("Empty parameter");
        }

        //////////////////////////////////  END partitions configuration ////////////////////////////////////////
    }
}
