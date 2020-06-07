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
    public partial class Admin_Montag : Form
    {
        public Admin_Montag()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenWrite("https://villaitalia.000webhostapp.com/Textbox.txt");
            StreamWriter write = new StreamWriter(stream);
            



        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://villaitalia.000webhostapp.com/" + "Textbox.txt");
            StreamReader reader = new StreamReader(stream);
            textBox1.Text = reader.ReadToEnd();
        }

       
    }
}
