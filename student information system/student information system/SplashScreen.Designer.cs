namespace student_information_system
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            customPanel1 = new CustomPanel();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label1 = new System.Windows.Forms.Label();
            timer1 = new System.Windows.Forms.Timer(components);
            customPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // customPanel1
            // 
            customPanel1.BackColor = System.Drawing.Color.White;
            customPanel1.BorderRadius = 1860;
            customPanel1.Controls.Add(progressBar1);
            customPanel1.Controls.Add(pictureBox2);
            customPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            customPanel1.ForeColor = System.Drawing.Color.Black;
            customPanel1.GradientAngle = 60F;
            customPanel1.GradientBottomColor = System.Drawing.Color.White;
            customPanel1.GradientTopColor = System.Drawing.Color.Blue;
            customPanel1.Location = new System.Drawing.Point(0, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new System.Drawing.Size(934, 611);
            customPanel1.TabIndex = 0;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = System.Drawing.SystemColors.HotTrack;
            progressBar1.Location = new System.Drawing.Point(374, 375);
            progressBar1.MarqueeAnimationSpeed = 500;
            progressBar1.Maximum = 200;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(188, 22);
            progressBar1.Step = 34;
            progressBar1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.Transparent;
            pictureBox2.Image = Properties.Resources.LoginLogoTransp;
            pictureBox2.Location = new System.Drawing.Point(374, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(188, 156);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(278, 109);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(409, 25);
            label1.TabIndex = 1;
            label1.Text = "Welcome to student information system";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(128, 128, 255);
            ClientSize = new System.Drawing.Size(934, 611);
            Controls.Add(label1);
            Controls.Add(customPanel1);
            Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.White;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            Name = "SplashScreen";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            Load += SplashScreen_Load;
            customPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomPanel customPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}