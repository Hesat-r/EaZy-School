using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EaZy_School.Admin_Hausaufgaben;
using EaZy_School.Admin_Klasuren_und_Infos;

namespace EaZy_School
{
    public partial class Admin_Main : Form
    {
        public Admin_Main()
        {
            InitializeComponent();
            customdesign();
            Datum.Text = DateTime.Now.ToLongDateString();
            Zeit.Text = DateTime.Now.ToLongTimeString();
        }

        #region customdesign

        

            private void customdesign()
        {
            adminsubpannelHausaufgaben.Visible = false;
            AdminSubpannelKlasuren.Visible = false;
            #endregion
        }
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

        #region showsubpanel




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

        #region hidesubpannel

        

        
        private void hidesubpannel()
        {
            
            if (adminsubpannelHausaufgaben.Visible == true)
            {
                adminsubpannelHausaufgaben.Visible = false;
            }
            if (AdminSubpannelKlasuren.Visible == true)
            {
                AdminSubpannelKlasuren.Visible = false;
            }
        }
        #endregion

        #region AdminHausaufgaben

        

        
        private void Admin_HausaufgabenButton_Click(object sender, EventArgs e)
        {
            showsubpannel(adminsubpannelHausaufgaben);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showsubpannel(AdminSubpannelKlasuren);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Montag());
            //CODE
            hidesubpannel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Dienstag());
            //CODE
            hidesubpannel();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Mittwoch());
            //CODE
            hidesubpannel();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Donnerstag());
            //CODE
            hidesubpannel();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Freitag());
            //CODE
            hidesubpannel();
        }
        #endregion

        #region adminKlasuren

        

        
        private void button11_Click(object sender, EventArgs e)
        {

            openchildForm(new Admin_Klasuren_Montag());
            //CODE
            hidesubpannel();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            openchildForm(new Admin_Klasuren_Dienstag());
            //CODE
            hidesubpannel();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            openchildForm(new Admin_Klasuren_Mittwoch());
            //CODE
            hidesubpannel();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            openchildForm(new Admin_Klasuren_Donnerstag());
            //CODE
            hidesubpannel();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Klasuren_Freitag());
            //CODE
            hidesubpannel();
        }
        #endregion

        #region admininfo

        private void button12_Click(object sender, EventArgs e)
        {
            openchildForm(new Admin_Infos());
            //CODE
            hidesubpannel();
        }
        #endregion

        #region Einstellungen

        

       

        private void button13_Click(object sender, EventArgs e)
        {
            openchildForm(new Einstellung());
            //CODE
            hidesubpannel();
        }
        #endregion

       
    }
}
