using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EaZy_School.Notification;
using ToastNotifications;
using ToastNotifications.Lifetime;
using ToastNotifications.Position;


namespace EaZy_School
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
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
                        Succes("Willkommen Admin " + Benutzertext.Text);
                        this.Hide();
                        Admin_Main f1 = new Admin_Main();
                        f1.Show();
                    }

                    else
                    {
                       
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
            // Align the text in the center of the TextBox control.
            Passwort.TextAlign = HorizontalAlignment.Center;
        }

        private void Passworttext_OnValueChanged(object sender, EventArgs e)
        {
            Passworttext.isPassword = true;

        }

    }
}
