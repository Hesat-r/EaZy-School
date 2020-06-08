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

        
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {



            string path = @"C:\Program Files\EaZy-School\SchoolCategory.txt";
           

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
