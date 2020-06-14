using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using EaZy_School.Notification;



namespace EaZy_School
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
            Init_Data();
        }

       

        private void Label1_Paint(object sender, PaintEventArgs e)
        {
            Font myFont = new Font("ONE DAY", 40);
            Brush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            e.Graphics.TranslateTransform(80, 13);
            e.Graphics.RotateTransform(90);
            label1.BackColor = System.Drawing.Color.Transparent;
            e.Graphics.DrawString("EaZy-School", myFont, myBrush, 0, 0);
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

        
        public void bunifuFlatButton1_Click(object sender, EventArgs e)
        {


          

            SqlConnection con =
                new SqlConnection("Data Source=HESATS-PC;Initial Catalog=EaZy;Integrated Security=True");
            try
            {
                con.Open();
                string cat = null;
                SqlCommand cmd = new SqlCommand(@"SELECT Category FROM Login WHERE username=@uname and password=@pass",
                    con);
                cmd.Parameters.AddWithValue("@uname", Benutzertext.Text);
                cmd.Parameters.AddWithValue("@pass", Passworttext.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    var c = reader["Category"].ToString();
                    if (c == "admin")
                    {
                        savedata();
                        Succes("Willkommen Admin " + Benutzertext.Text);
                        this.Hide();
                        Admin_Main f1 = new Admin_Main();
                        f1.Show();


                        string datei = @"C:\Program Files\EaZy-School\firsttime.txt";
                        string ordner = @"C:\Program Files\EaZy-School";

                        if (!Directory.Exists(ordner))
                        {
                            Directory.CreateDirectory(ordner);
                        }

                        if (!File.Exists(datei))
                        {
                            File.Create(datei).Dispose();

                           Info("bei den Einstellungen muss der schulcode eingegeben werden!");

                        }

                    }

                    else
                    {
                        savedata();
                        Succes("Wilkommen " + Benutzertext.Text);
                        this.Hide();
                        Main f3 = new Main();
                        f3.Show();
                        
                    }
                    
                }
                else
                {
                   Error("Benutzername oder Passwort Falsch");
                }

               

            }
            catch (Exception ex)
            {
                Error("Unexpected error:" + ex.Message);
            }

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public void Passwortsicherhiet()
        {

            TextBox Passwort = new TextBox();
           

            Passwort.PasswordChar = '*';
            Passwort.TextAlign = HorizontalAlignment.Center;
        }

        private void Passworttext_OnValueChanged(object sender, EventArgs e)
        {
            Passworttext.isPassword = true;

        }

        #region benutzerdaten merken

        
        private void Init_Data()
        {
            if (Properties.Settings.Default.benutzer != string.Empty)
            {
                if (Properties.Settings.Default.remember == "yes")
                {
                    Benutzertext.Text = Properties.Settings.Default.benutzer;
                    Passworttext.Text = Properties.Settings.Default.passwort;
                    bunifuCheckbox1.Checked = true;
                }
                else
                {
                    Benutzertext.Text = Properties.Settings.Default.benutzer;
                }
            }
        }
        private void savedata()
        {
            if (bunifuCheckbox1.Checked)
            {
                Properties.Settings.Default.benutzer = Benutzertext.Text;
                Properties.Settings.Default.passwort = Passworttext.Text;
                Properties.Settings.Default.remember = "yes";
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.benutzer = Benutzertext.Text;
                Properties.Settings.Default.passwort = "";
                Properties.Settings.Default.remember = "no";
                Properties.Settings.Default.Save();
            }
           

        }
        #endregion

    }
}
