using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaZy_School.Admin_Hausaufgaben
{
    public partial class Admin_Freitag : Form
    {
        public Admin_Freitag()
        {
            InitializeComponent();
        }
        #region notification

        private void Succes(String Message)
        {
            Notification.Succes succes = new Notification.Succes(Message);
            succes.Show();
        }
        private void Info(String Message)
        {
            Notification.Info info = new Notification.Info(Message);
            info.Show();
        }
        private void Error(String Message)
        {
            Notification.Error error = new Notification.Error(Message);
            error.Show();
        }

        #endregion


        #region write

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\EaZy-School\SchoolCategory.txt";
            var read = File.ReadAllText(path);
            string server = "ftp://eazy-school@files.000webhost.com/" + read + "/Freitag.txt";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server);
            request.Credentials = new NetworkCredential("eazy-school", "Tonicati1");


            request.Method = WebRequestMethods.Ftp.DeleteFile;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();



            string datei = @"C:\Program Files\EaZy-School\Freitag.txt";
            string ordner = @"C:\Program Files\EaZy-School";

            if (!Directory.Exists(ordner))
            {
                Directory.CreateDirectory(ordner);
            }

            if (!File.Exists(datei))
            {
                File.Create(datei).Dispose();

                using (TextWriter tw = new StreamWriter(datei))
                {
                    tw.Write(textBox1.Text);
                    tw.Close();

                }


            }
            else
            {
                using (TextWriter tw = new StreamWriter(datei))
                {
                    tw.Write(textBox1.Text);
                    tw.Close();


                }
            }

            WebClient client = new WebClient();
            client.Credentials = new NetworkCredential("eazy-school", "Tonicati1");
            client.UploadFile(server, datei);
            Succes("Erfolgreich Bearbeitet");
        }
        #endregion

        #region read

        

        
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            string path = @"C:\Program Files\EaZy-School\SchoolCategory.txt";
            var read = File.ReadAllText(path);
            string server = "ftp://eazy-school@files.000webhost.com/" + read + "/Mittwoch.txt";
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(server);
            request.Credentials = new NetworkCredential("eazy-school", "Tonicati1");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            using (Stream stream = request.GetResponse().GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                textBox1.Text = reader.ReadToEnd();

            }
            Succes("Erfolgreich Geladen");
        }
        #endregion
    }
}
