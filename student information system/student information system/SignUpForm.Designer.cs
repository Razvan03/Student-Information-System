namespace student_information_system
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_SignUp = new System.Windows.Forms.Button();
            txtBox_Password = new System.Windows.Forms.TextBox();
            lbl_pass = new System.Windows.Forms.Label();
            txtBox_Username = new System.Windows.Forms.TextBox();
            lbl_Username = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lbl_Exit = new System.Windows.Forms.Label();
            lbl_Titu = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lbl_Email = new System.Windows.Forms.Label();
            txtBox_Email = new System.Windows.Forms.TextBox();
            customPanel1 = new CustomPanel();
            ShowPassword = new System.Windows.Forms.CheckBox();
            lbl_Login = new System.Windows.Forms.Label();
            lbl_plslogin = new System.Windows.Forms.Label();
            picBox_Login = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Login).BeginInit();
            SuspendLayout();
            // 
            // btn_SignUp
            // 
            btn_SignUp.BackColor = System.Drawing.SystemColors.HotTrack;
            btn_SignUp.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_SignUp.ForeColor = System.Drawing.Color.White;
            btn_SignUp.Location = new System.Drawing.Point(307, 492);
            btn_SignUp.Name = "btn_SignUp";
            btn_SignUp.Size = new System.Drawing.Size(317, 45);
            btn_SignUp.TabIndex = 29;
            btn_SignUp.Text = "Sign Up";
            btn_SignUp.UseVisualStyleBackColor = false;
            btn_SignUp.Click += SignUp_Click;
            // 
            // txtBox_Password
            // 
            txtBox_Password.Location = new System.Drawing.Point(307, 360);
            txtBox_Password.Name = "txtBox_Password";
            txtBox_Password.Size = new System.Drawing.Size(317, 27);
            txtBox_Password.TabIndex = 28;
            txtBox_Password.UseSystemPasswordChar = true;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.BackColor = System.Drawing.Color.Transparent;
            lbl_pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_pass.Location = new System.Drawing.Point(307, 326);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new System.Drawing.Size(100, 22);
            lbl_pass.TabIndex = 27;
            lbl_pass.Text = "Password:";
            // 
            // txtBox_Username
            // 
            txtBox_Username.Location = new System.Drawing.Point(307, 285);
            txtBox_Username.Name = "txtBox_Username";
            txtBox_Username.Size = new System.Drawing.Size(317, 27);
            txtBox_Username.TabIndex = 26;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.BackColor = System.Drawing.Color.Transparent;
            lbl_Username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Username.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_Username.Location = new System.Drawing.Point(307, 251);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new System.Drawing.Size(106, 22);
            lbl_Username.TabIndex = 25;
            lbl_Username.Text = "Username:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.Controls.Add(lbl_Exit);
            panel1.Controls.Add(lbl_Titu);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(934, 55);
            panel1.TabIndex = 24;
            // 
            // lbl_Exit
            // 
            lbl_Exit.AutoSize = true;
            lbl_Exit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Exit.ForeColor = System.Drawing.Color.White;
            lbl_Exit.Location = new System.Drawing.Point(906, 0);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new System.Drawing.Size(28, 28);
            lbl_Exit.TabIndex = 2;
            lbl_Exit.Text = "X";
            lbl_Exit.Click += lbl_Exit_Click;
            lbl_Exit.MouseEnter += lbl_Exit_MouseEnter;
            lbl_Exit.MouseLeave += lbl_Exit_MouseLeave;
            // 
            // lbl_Titu
            // 
            lbl_Titu.AutoSize = true;
            lbl_Titu.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Titu.ForeColor = System.Drawing.Color.White;
            lbl_Titu.Location = new System.Drawing.Point(100, 21);
            lbl_Titu.Name = "lbl_Titu";
            lbl_Titu.Size = new System.Drawing.Size(288, 24);
            lbl_Titu.TabIndex = 1;
            lbl_Titu.Text = "Student Information System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_site;
            pictureBox1.Location = new System.Drawing.Point(-10, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(104, 77);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_Email
            // 
            lbl_Email.AutoSize = true;
            lbl_Email.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Email.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_Email.Location = new System.Drawing.Point(307, 401);
            lbl_Email.Name = "lbl_Email";
            lbl_Email.Size = new System.Drawing.Size(61, 22);
            lbl_Email.TabIndex = 30;
            lbl_Email.Text = "Email:";
            // 
            // txtBox_Email
            // 
            txtBox_Email.Location = new System.Drawing.Point(307, 435);
            txtBox_Email.Name = "txtBox_Email";
            txtBox_Email.Size = new System.Drawing.Size(317, 27);
            txtBox_Email.TabIndex = 31;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = System.Drawing.Color.White;
            customPanel1.BorderRadius = 2600;
            customPanel1.Controls.Add(ShowPassword);
            customPanel1.Controls.Add(lbl_Login);
            customPanel1.Controls.Add(lbl_plslogin);
            customPanel1.Controls.Add(picBox_Login);
            customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            customPanel1.ForeColor = System.Drawing.Color.Black;
            customPanel1.GradientAngle = 120F;
            customPanel1.GradientBottomColor = System.Drawing.Color.White;
            customPanel1.GradientTopColor = System.Drawing.Color.Blue;
            customPanel1.Location = new System.Drawing.Point(0, 55);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new System.Drawing.Size(934, 556);
            customPanel1.TabIndex = 32;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.BackColor = System.Drawing.Color.Transparent;
            ShowPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ShowPassword.ForeColor = System.Drawing.Color.White;
            ShowPassword.Location = new System.Drawing.Point(641, 308);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new System.Drawing.Size(142, 24);
            ShowPassword.TabIndex = 26;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = false;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.BackColor = System.Drawing.Color.Transparent;
            lbl_Login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Login.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_Login.Location = new System.Drawing.Point(309, 506);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new System.Drawing.Size(207, 21);
            lbl_Login.TabIndex = 25;
            lbl_Login.Text = "Have an account? Login.";
            lbl_Login.Click += lbl_Login_Click;
            // 
            // lbl_plslogin
            // 
            lbl_plslogin.AutoSize = true;
            lbl_plslogin.BackColor = System.Drawing.Color.Transparent;
            lbl_plslogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_plslogin.ForeColor = System.Drawing.Color.White;
            lbl_plslogin.Location = new System.Drawing.Point(387, 165);
            lbl_plslogin.Name = "lbl_plslogin";
            lbl_plslogin.Size = new System.Drawing.Size(161, 25);
            lbl_plslogin.TabIndex = 24;
            lbl_plslogin.Text = "Please Sign Up";
            // 
            // picBox_Login
            // 
            picBox_Login.BackColor = System.Drawing.Color.Transparent;
            picBox_Login.Image = Properties.Resources.LoginLogoTransp;
            picBox_Login.Location = new System.Drawing.Point(375, 6);
            picBox_Login.Name = "picBox_Login";
            picBox_Login.Size = new System.Drawing.Size(188, 156);
            picBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBox_Login.TabIndex = 23;
            picBox_Login.TabStop = false;
            // 
            // SignUpForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 611);
            Controls.Add(customPanel1);
            Controls.Add(txtBox_Email);
            Controls.Add(lbl_Email);
            Controls.Add(btn_SignUp);
            Controls.Add(txtBox_Password);
            Controls.Add(lbl_pass);
            Controls.Add(txtBox_Username);
            Controls.Add(lbl_Username);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4);
            Name = "SignUpForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SignUpForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            customPanel1.ResumeLayout(false);
            customPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Login).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_Titu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.TextBox txtBox_Email;
        public CustomPanel customPanel1;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label lbl_plslogin;
        private System.Windows.Forms.PictureBox picBox_Login;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}