using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace student_information_system
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            DatabaseManager d = new DatabaseManager();
            d.CreateTables();
            InitializeComponent();
            d.CreateTables();
            bringToFront();
        }

        private void bringToFront()
        {
            picBox_Login.BringToFront();
            txtBox_Password.BringToFront();
            txtBox_Username.BringToFront();
            lbl_plslogin.BringToFront();
            lbl_Username.BringToFront();
            lbl_pass.BringToFront();
            btn_Login.BringToFront();
        }
        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_Exit_MouseEnter(object sender, EventArgs e)
        {
            lbl_Exit.ForeColor = Color.Red;
        }

        private void lbl_Exit_MouseLeave(object sender, EventArgs e)
        {
            lbl_Exit.ForeColor = Color.Transparent;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtBox_Username.Text == "admin" && txtBox_Password.Text == "admin")
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else if (txtBox_Username.Text == "profesor" && txtBox_Password.Text == "parolaproftodo")
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();

            }

            else
            {
                DatabaseManager d = new DatabaseManager();
                bool credentialsExist = d.CheckCredentials(txtBox_Username.Text, txtBox_Password.Text);

                if (credentialsExist)
                {
                    MainForm mainForm = new MainForm();
                    this.Hide();
                    mainForm.Show();
                }

                else
                {
                    MessageBox.Show("Wrong username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_SignUp_Click(object sender, EventArgs e)
        {
            SignUpForm signUP = new SignUpForm();
            this.Hide();
            signUP.Show();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked == true)
            {
                txtBox_Password.UseSystemPasswordChar = false;
            }

            else if (ShowPassword.Checked == false)
            {
                txtBox_Password.UseSystemPasswordChar = true;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

