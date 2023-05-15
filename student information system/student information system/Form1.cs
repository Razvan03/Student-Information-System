using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_information_system
{
    public partial class MainForm : Form
    {
        private RegistrationForm registrationForm;
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            registrationForm = new RegistrationForm();

        }



        private void customizeDesign()
        {
            Studenti_Submenu.Visible = false;
            Optiuni_Submenu.Visible = false;
            Orar_Submenu.Visible = false;
        }

        private void hideSubmenu()
        {
            if (Studenti_Submenu.Visible == true)
                Studenti_Submenu.Visible = false;
            if (Optiuni_Submenu.Visible == true)
                Optiuni_Submenu.Visible = false;
            if (Orar_Submenu.Visible == true)
                Orar_Submenu.Visible = false;
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Panel_Top_1.Visible = false;
            Panel_Top_2.Visible = false;
            Panel_Dreapta_Fill.Controls.Add(childForm);
            Panel_Dreapta_Fill.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Studenti
        private void Button_Studenti_Click(object sender, EventArgs e)
        {
            showSubmenu(Studenti_Submenu);
        }

        private void Button_Grupa1_Click(object sender, EventArgs e)
        {
            openChildForm(new Lista_StudentiForm("Grupa 1"));
            hideSubmenu();
        }

        private void Button_Grupa2_Click(object sender, EventArgs e)
        {
            openChildForm(new Lista_StudentiForm("Grupa 2"));
            hideSubmenu();
        }

        private void Button_Grupa3_Click(object sender, EventArgs e)
        {
            openChildForm(new Lista_StudentiForm("Grupa 3"));
            hideSubmenu();
        }

        private void Button_Inregistrare_Student_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrationForm());
            hideSubmenu();
        }

        #endregion

        #region Note&Orar

        private void Button_Note_Click_1(object sender, EventArgs e)
        {
            openChildForm(new NoteForm());
        }

        private void Button_Orar_Click(object sender, EventArgs e)
        {
            showSubmenu(Orar_Submenu);
        }

        private void btnGrupa1Orar_Click(object sender, EventArgs e)
        {
            openChildForm(new OrarForm("Grupa 1"));
            hideSubmenu();
        }

        private void btnGrupa2Orar_Click(object sender, EventArgs e)
        {
            openChildForm(new OrarForm("Grupa 2"));
            hideSubmenu();
        }

        private void btnGrupa3Orar_Click(object sender, EventArgs e)
        {
            openChildForm(new OrarForm("Grupa 3"));
            hideSubmenu();
        }
        #endregion
        private void Button_Inapoi_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Panel_Top_1.Visible = true;
                Panel_Top_2.Visible = true;
            }
        }
        #region Optiuni
        private void Button_Profesori_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Button_Materii_Fac_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Button_Taxe_Click_1(object sender, EventArgs e)
        {
            hideSubmenu();
        }

        private void Button_Optiuni_Click_1(object sender, EventArgs e)
        {
            showSubmenu(Optiuni_Submenu);
        }
        #endregion

        private void btn_SignOut_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

    }
}
