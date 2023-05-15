namespace student_information_system
{
    partial class LoginForm
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
            panel1 = new System.Windows.Forms.Panel();
            lbl_Exit = new System.Windows.Forms.Label();
            lbl_Login = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btn_Login = new System.Windows.Forms.Button();
            txtBox_Password = new System.Windows.Forms.TextBox();
            lbl_pass = new System.Windows.Forms.Label();
            txtBox_Username = new System.Windows.Forms.TextBox();
            lbl_Username = new System.Windows.Forms.Label();
            customPanel1 = new CustomPanel();
            ShowPassword = new System.Windows.Forms.CheckBox();
            lbl_SignUp = new System.Windows.Forms.Label();
            lbl_plslogin = new System.Windows.Forms.Label();
            picBox_Login = new System.Windows.Forms.PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBox_Login).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.Controls.Add(lbl_Exit);
            panel1.Controls.Add(lbl_Login);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(934, 55);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_Exit
            // 
            lbl_Exit.AutoSize = true;
            lbl_Exit.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_Exit.ForeColor = System.Drawing.Color.White;
            lbl_Exit.Location = new System.Drawing.Point(906, 0);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new System.Drawing.Size(37, 37);
            lbl_Exit.TabIndex = 2;
            lbl_Exit.Text = "X";
            lbl_Exit.Click += lbl_Exit_Click;
            lbl_Exit.MouseEnter += lbl_Exit_MouseEnter;
            lbl_Exit.MouseLeave += lbl_Exit_MouseLeave;
            // 
            // lbl_Login
            // 
            lbl_Login.AutoSize = true;
            lbl_Login.ForeColor = System.Drawing.Color.White;
            lbl_Login.Location = new System.Drawing.Point(100, 21);
            lbl_Login.Name = "lbl_Login";
            lbl_Login.Size = new System.Drawing.Size(373, 33);
            lbl_Login.TabIndex = 1;
            lbl_Login.Text = "Student Information System";
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
            // btn_Login
            // 
            btn_Login.BackColor = System.Drawing.SystemColors.HotTrack;
            btn_Login.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btn_Login.ForeColor = System.Drawing.Color.White;
            btn_Login.Location = new System.Drawing.Point(309, 494);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(317, 45);
            btn_Login.TabIndex = 21;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += btn_Login_Click;
            // 
            // txtBox_Password
            // 
            txtBox_Password.Location = new System.Drawing.Point(309, 418);
            txtBox_Password.Name = "txtBox_Password";
            txtBox_Password.Size = new System.Drawing.Size(317, 40);
            txtBox_Password.TabIndex = 20;
            txtBox_Password.UseSystemPasswordChar = true;
            // 
            // lbl_pass
            // 
            lbl_pass.AutoSize = true;
            lbl_pass.BackColor = System.Drawing.Color.Transparent;
            lbl_pass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_pass.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_pass.Location = new System.Drawing.Point(309, 384);
            lbl_pass.Name = "lbl_pass";
            lbl_pass.Size = new System.Drawing.Size(129, 30);
            lbl_pass.TabIndex = 19;
            lbl_pass.Text = "Password:";
            // 
            // txtBox_Username
            // 
            txtBox_Username.Location = new System.Drawing.Point(309, 325);
            txtBox_Username.Name = "txtBox_Username";
            txtBox_Username.Size = new System.Drawing.Size(317, 40);
            txtBox_Username.TabIndex = 18;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.BackColor = System.Drawing.Color.Transparent;
            lbl_Username.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_Username.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_Username.Location = new System.Drawing.Point(309, 291);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new System.Drawing.Size(140, 30);
            lbl_Username.TabIndex = 16;
            lbl_Username.Text = "Username:";
            // 
            // customPanel1
            // 
            customPanel1.BackColor = System.Drawing.Color.White;
            customPanel1.BorderRadius = 2600;
            customPanel1.Controls.Add(ShowPassword);
            customPanel1.Controls.Add(lbl_SignUp);
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
            customPanel1.TabIndex = 23;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.BackColor = System.Drawing.Color.Transparent;
            ShowPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ShowPassword.ForeColor = System.Drawing.Color.White;
            ShowPassword.Location = new System.Drawing.Point(666, 369);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new System.Drawing.Size(171, 26);
            ShowPassword.TabIndex = 27;
            ShowPassword.Text = "Show Password";
            ShowPassword.UseVisualStyleBackColor = false;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // lbl_SignUp
            // 
            lbl_SignUp.AutoSize = true;
            lbl_SignUp.BackColor = System.Drawing.Color.Transparent;
            lbl_SignUp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_SignUp.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_SignUp.Location = new System.Drawing.Point(309, 506);
            lbl_SignUp.Name = "lbl_SignUp";
            lbl_SignUp.Size = new System.Drawing.Size(334, 23);
            lbl_SignUp.TabIndex = 25;
            lbl_SignUp.Text = "Don't have an account? Sign up.";
            lbl_SignUp.Click += lbl_SignUp_Click;
            // 
            // lbl_plslogin
            // 
            lbl_plslogin.AutoSize = true;
            lbl_plslogin.BackColor = System.Drawing.Color.Transparent;
            lbl_plslogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_plslogin.ForeColor = System.Drawing.Color.White;
            lbl_plslogin.Location = new System.Drawing.Point(399, 172);
            lbl_plslogin.Name = "lbl_plslogin";
            lbl_plslogin.Size = new System.Drawing.Size(176, 32);
            lbl_plslogin.TabIndex = 24;
            lbl_plslogin.Text = "Please Login";
            // 
            // picBox_Login
            // 
            picBox_Login.BackColor = System.Drawing.Color.Transparent;
            picBox_Login.Image = Properties.Resources.LoginLogoTransp;
            picBox_Login.Location = new System.Drawing.Point(373, 13);
            picBox_Login.Name = "picBox_Login";
            picBox_Login.Size = new System.Drawing.Size(188, 156);
            picBox_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            picBox_Login.TabIndex = 23;
            picBox_Login.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Azure;
            ClientSize = new System.Drawing.Size(934, 611);
            Controls.Add(customPanel1);
            Controls.Add(btn_Login);
            Controls.Add(txtBox_Password);
            Controls.Add(lbl_pass);
            Controls.Add(txtBox_Username);
            Controls.Add(lbl_Username);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(5);
            Name = "LoginForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "LoginForm";
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

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Exit;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox txtBox_Password;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txtBox_Username;
        private System.Windows.Forms.Label lbl_Username;
        public CustomPanel customPanel1;
        private System.Windows.Forms.PictureBox picBox_Login;
        private System.Windows.Forms.Label lbl_plslogin;
        private System.Windows.Forms.Label lbl_SignUp;
        private System.Windows.Forms.CheckBox ShowPassword;
    }
}