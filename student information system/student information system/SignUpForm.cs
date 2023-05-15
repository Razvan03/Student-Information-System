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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
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
            btn_SignUp.BringToFront();
            lbl_Email.BringToFront();
            txtBox_Email.BringToFront();
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

        private async void SignUp_Click(object sender, EventArgs e)
        {
            string specialChars = "!@#$%^&*()_+{};',./";
            string numbers = "0123456789";
            int index = txtBox_Password.Text.IndexOfAny(specialChars.ToCharArray());
            int index2 = txtBox_Password.Text.IndexOfAny(numbers.ToCharArray());
            DatabaseManager d = new DatabaseManager();
            if (txtBox_Username.Text.Length < 8 || txtBox_Username.Text.Length > 20)
            {
                MessageBox.Show("User-ul trebuie sa aiba intre 8-20 caractere", "user invalid",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ((txtBox_Password.Text.Length < 8 || txtBox_Password.Text.Length > 20) || (index2 == -1 && index == -1))
            {
                MessageBox.Show("Parola trebuie sa aiba intre 8-20 caractere, un caracater special si o cifra", "Parola invalida",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (d.CheckEmail(txtBox_Email.Text) == false)
            {
                MessageBox.Show("Email Invalid", "OK",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                d.InsertCredential(txtBox_Username.Text, txtBox_Password.Text, txtBox_Email.Text);
                LoginForm login = new LoginForm();
                this.Hide();
                login.Show();
            }
        }

        private void lbl_Login_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
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
    }
}
