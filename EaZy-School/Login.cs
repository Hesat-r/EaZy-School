using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            e.Graphics.TranslateTransform(80,13);
            e.Graphics.RotateTransform(90);
            label1.BackColor = System.Drawing.Color.Transparent;
            e.Graphics.DrawString("EaZy-School",myFont,myBrush,0,0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
