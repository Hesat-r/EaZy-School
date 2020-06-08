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
    public partial class Error : Form
    {
        public Error(String message)
        {
            InitializeComponent();
            label2.Text = message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void Error_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
