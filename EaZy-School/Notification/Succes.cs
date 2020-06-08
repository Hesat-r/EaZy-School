using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaZy_School.Notification
{
    public partial class Succes : Form
    {
        public Succes(String message)
        {
            InitializeComponent();

            label1.Text = message;
        }

        private void Succes_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
