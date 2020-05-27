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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            customdesign();
            
        }

        #region SubPannel

        

      
        private void customdesign()
        {
            subpannelHausaufgaben.Visible = false;
            subpannelKlasuren.Visible = false;
            subpannelAdminHa.Visible = false;
            subpanneladminw.Visible = false;
        }

        private void hidesubpannel()
        {
            if (subpannelHausaufgaben.Visible == true)
            {
                subpannelHausaufgaben.Visible = false;
            }
            if (subpannelKlasuren.Visible == true)
            {
                subpannelKlasuren.Visible = false;
            }
            if (subpannelAdminHa.Visible == true)
            {
                subpannelAdminHa.Visible = false;
            }
            if (subpanneladminw.Visible == true)
            {
                subpanneladminw.Visible = false;
            }
        }
  

        private void showsubpannel(Panel subpannel)
        {
            if (subpannel.Visible == false)
            {
                hidesubpannel();
                subpannel.Visible = true;
            }
            else
            {
                subpannel.Visible = false;
            }
        }
        #endregion

        #region Hausaufgaben


        private void HausaufgabenButton_Click(object sender, EventArgs e)
        {
            showsubpannel(subpannelHausaufgaben);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }
        #endregion //Hausaufgaben

        #region Klasuren

        

       
        private void KlasurenButton_Click(object sender, EventArgs e)
        {
            showsubpannel(subpannelKlasuren);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }
        #endregion

        #region Infos

        

        private void InfosButton_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }
        #endregion

        #region AdminHausaufgaben

        

        
        private void AdminHausaufgabenButton_Click(object sender, EventArgs e)
        {
            showsubpannel(subpannelAdminHa);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }
        #endregion

        #region AdminWeiteres

        

       
        private void AdminWeiteresButton_Click(object sender, EventArgs e)
        {
            showsubpannel(subpanneladminw);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            //CODE
            hidesubpannel();
        }
        #endregion

        private void label2_Click(object sender, EventArgs e)
        {
            Registrieren sRegistrieren = new Registrieren();
            this.Hide();
            sRegistrieren.Show();
        }
    }
}
