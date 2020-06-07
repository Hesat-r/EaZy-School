using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EaZy_School.Admin_Hausaufgaben;
using EaZy_School.Admin_Klasuren_und_Infos;
using EaZy_School.Nutzer;
using EaZy_School.Nutzer_Klasuren___Info;

namespace EaZy_School
{

    public partial class Main : Form
    {

       
        public Main()
        {
            InitializeComponent();
            customdesign();
            Datum.Text = DateTime.Now.ToLongDateString();
            Zeit.Text = DateTime.Now.ToLongTimeString();

        }



        #region SubPannel




        private void customdesign()
        {
            subpannelHausaufgaben.Visible = false;
            subpannelKlasuren.Visible = false;
          
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
            openchildForm(new Montag());
            //CODE
            hidesubpannel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildForm(new Dienstag());
            //CODE
            hidesubpannel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildForm(new Mittwoch());
            //CODE
            hidesubpannel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchildForm(new Donnerstag());
            //CODE
            hidesubpannel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openchildForm(new Freitag());
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
            openchildForm(new Klasuren_Montag());
            hidesubpannel();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            openchildForm(new Klasuren_Dienstag());
            //CODE
            hidesubpannel();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            openchildForm(new Klasuren_Mittwoch());
            //CODE
            hidesubpannel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openchildForm(new Klasuren_Donnerstag());
            //CODE
            hidesubpannel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openchildForm(new Klasuren_Freitag());
            //CODE
            hidesubpannel();
        }
        #endregion

        #region Infos

        

        private void InfosButton_Click(object sender, EventArgs e)
        {
            openchildForm(new Infos());
            //CODE
            hidesubpannel();
        }
        #endregion

        #region AdminHausaufgaben

        

        
      

        private void button19_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Montag());
            //CODE
            hidesubpannel();
        }

        private void button18_Click(object sender, EventArgs e)
        {

                openchildForm(new Admin_Dienstag());
                //CODE
                hidesubpannel();

        }

        private void button17_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Mittwoch());
            //CODE
            hidesubpannel();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Donnerstag());
            //CODE
            hidesubpannel();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Freitag());
            //CODE
            hidesubpannel();
        }
        #endregion

        #region AdminWeiteres

        

       
      
        private void button20_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Klasuren_Montag());
            hidesubpannel();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Klasuren_Dienstag());
            hidesubpannel();
        }

        private void button13_Click(object sender, EventArgs e)
        {
           openchildForm(new Admin_Klasuren_Mittwoch());
           hidesubpannel();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Klasuren_Donnerstag());
            hidesubpannel();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Klasuren_Freitag());
            hidesubpannel();
        }

        #endregion

        #region Main

        private void label2_Click(object sender, EventArgs e)
        {
            Main sMain = new Main();
            this.Hide();
            sMain.Show();
        }

        #endregion

        #region Forms

        private Form activeForm = null;

        private void openchildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        #endregion


        #region Einstellungen


        private void button22_Click(object sender, EventArgs e)
        {
            openchildForm(new Einstellung());
        }
        #endregion

       
        
    }
}
