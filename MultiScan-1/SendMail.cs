using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;
using System.Timers;
using System.IO;
using System.Diagnostics;
using System.Management;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Globalization;
using System.Reflection;
using System.Net.Mail;

namespace MultiScan_1
{
    public class SendMail
    {
        public string _smtp_client;
        public string _my_address;
        public string _to_send_address;
        public string _to_send_address1;
        public string _to_send_address2;
        public string _mail_subject;
        public string _mail_body;
        public void send_mail(string path_to_attach)
        {
            //MessageBox.Show(path_to_attach);

            XmlDocument xmlDoc = new XmlDocument();
            //path to XML document 
            XDocument doc = XDocument.Load("mail_config.xml");
            //go to read name of the element is in lists
            var lists = doc.Descendants("mail_conf");

            //Scheduled Task Started
            foreach (var list in lists)
            {
                if ((string)list.Attribute("smtp_client") != null)
                { _smtp_client = (string)list.Attribute("smtp_client"); }

                if ((string)list.Attribute("my_address") != null)
                { _my_address = (string)list.Attribute("my_address"); }

                if ((string)list.Attribute("to_send_address") != null)
                { _to_send_address = (string)list.Attribute("to_send_address"); }

                if ((string)list.Attribute("to_send_address1") != null)
                { _to_send_address1 = (string)list.Attribute("to_send_address1"); }

                if ((string)list.Attribute("to_send_address2") != null)
                { _to_send_address2 = (string)list.Attribute("to_send_address2"); }

                if ((string)list.Attribute("mail_subject") != null)
                { _mail_subject = (string)list.Attribute("mail_subject"); }

                if ((string)list.Attribute("mail_body") != null)
                { _mail_body = (string)list.Attribute("mail_body"); }
            }
      

            ///////////////////////////////////////////////////////////////////////

            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(_smtp_client);

                mail.From = new MailAddress(_my_address);           
                mail.To.Add(_to_send_address);
                if (_to_send_address1 != null && _to_send_address2 != null)
                { mail.CC.Add(new MailAddress(_to_send_address1)); mail.CC.Add(new MailAddress(_to_send_address2)); }
                if (_to_send_address1 != null && _to_send_address2 == null)
                { mail.CC.Add(new MailAddress(_to_send_address1)); }
                if (_to_send_address1 == null && _to_send_address2 != null)
                { mail.CC.Add(new MailAddress(_to_send_address2)); }
                mail.Subject = _mail_subject;
                mail.Body = _mail_body;

                System.Net.Mail.Attachment attachment;
                attachment = new System.Net.Mail.Attachment(path_to_attach);
                mail.Attachments.Add(attachment);

                SmtpServer.Port = 25;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("serakuz51", "sera1970");
                SmtpServer.EnableSsl = false;

                SmtpServer.Send(mail);
                //MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }

            ///////////////////////////////////////////////////////////////////////

        }
    }
}
