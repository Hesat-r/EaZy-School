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

namespace EaZy_School
{
    public partial class Einstellung : Form
    {
        public Einstellung()
        {
            InitializeComponent();
        }

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
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {



            string path = @"C:\Program Files\EaZy-School\SchoolCategory.txt";
            string ordner = @"C:\Program Files\EaZy-School";


            if (!Directory.Exists(ordner))
            {
                Directory.CreateDirectory(ordner);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Dispose();

                using (TextWriter tw = new StreamWriter(path))
                {
                    tw.Write(schulcodetextbox.Text);
                }

            }
            else
            {
                 using (TextWriter tw = new StreamWriter(path))
                {
                    tw.Write(schulcodetextbox.Text);
                }
            }
            


        }

  
    }
}
