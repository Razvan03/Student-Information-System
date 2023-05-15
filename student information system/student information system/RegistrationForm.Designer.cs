using System.Windows.Forms;

namespace student_information_system
{
    partial class RegistrationForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridInregistrare = new DataGridView();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label9 = new Label();
            txtEmail = new TextBox();
            btnUpdate = new Button();
            panel3 = new Panel();
            numericUpDown_Gr = new NumericUpDown();
            numericUpDown_An = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            Incarca_Poza = new Button();
            imgStdInregistrare = new PictureBox();
            txtAdresa = new TextBox();
            label5 = new Label();
            radioButtonF = new RadioButton();
            radioButtonM = new RadioButton();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            txtPreumeStd = new TextBox();
            label2 = new Label();
            txtNumeStd = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            lbl_nrStd = new Label();
            label10 = new Label();
            Box_An = new NumericUpDown();
            panel5 = new Panel();
            txtSearchInregistrare = new TextBox();
            btnSearchInregistrare = new Button();
            bindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridInregistrare).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Gr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_An).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgStdInregistrare).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Box_An).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridInregistrare
            // 
            dataGridInregistrare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridInregistrare.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridInregistrare.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridInregistrare.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridInregistrare.GridColor = System.Drawing.Color.Gainsboro;
            dataGridInregistrare.Location = new System.Drawing.Point(11, 116);
            dataGridInregistrare.MultiSelect = false;
            dataGridInregistrare.Name = "dataGridInregistrare";
            dataGridInregistrare.RowHeadersWidth = 51;
            dataGridInregistrare.RowTemplate.Height = 100;
            dataGridInregistrare.Size = new System.Drawing.Size(909, 266);
            dataGridInregistrare.TabIndex = 0;
            dataGridInregistrare.CellClick += dataGridInregistrare_CellClick;
            dataGridInregistrare.Resize += dataGridInregistrare_Resize;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(932, 54);
            panel1.TabIndex = 16;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(346, 18);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(208, 25);
            label6.TabIndex = 0;
            label6.Text = "Inregistrare Student";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(numericUpDown_Gr);
            panel2.Controls.Add(numericUpDown_An);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(Incarca_Poza);
            panel2.Controls.Add(imgStdInregistrare);
            panel2.Controls.Add(txtAdresa);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(radioButtonF);
            panel2.Controls.Add(radioButtonM);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtPreumeStd);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNumeStd);
            panel2.Controls.Add(label1);
            panel2.Location = new System.Drawing.Point(0, 381);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(932, 322);
            panel2.TabIndex = 17;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(66, 266);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(52, 19);
            label9.TabIndex = 47;
            label9.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new System.Drawing.Point(127, 257);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(156, 27);
            txtEmail.TabIndex = 46;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.None;
            btnUpdate.BackColor = System.Drawing.Color.Orange;
            btnUpdate.ForeColor = System.Drawing.Color.White;
            btnUpdate.Location = new System.Drawing.Point(527, 257);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(160, 53);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Actualizeaza";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            panel3.Location = new System.Drawing.Point(11, 0);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(909, 5);
            panel3.TabIndex = 44;
            // 
            // numericUpDown_Gr
            // 
            numericUpDown_Gr.Anchor = AnchorStyles.None;
            numericUpDown_Gr.Location = new System.Drawing.Point(501, 71);
            numericUpDown_Gr.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown_Gr.Name = "numericUpDown_Gr";
            numericUpDown_Gr.Size = new System.Drawing.Size(36, 27);
            numericUpDown_Gr.TabIndex = 43;
            // 
            // numericUpDown_An
            // 
            numericUpDown_An.Anchor = AnchorStyles.None;
            numericUpDown_An.Location = new System.Drawing.Point(132, 71);
            numericUpDown_An.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown_An.Name = "numericUpDown_An";
            numericUpDown_An.Size = new System.Drawing.Size(36, 27);
            numericUpDown_An.TabIndex = 42;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            label8.Location = new System.Drawing.Point(432, 73);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(63, 19);
            label8.TabIndex = 41;
            label8.Text = "Grupa:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            label7.Location = new System.Drawing.Point(91, 73);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(35, 19);
            label7.TabIndex = 40;
            label7.Text = "An:";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.None;
            btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            btnAdd.ForeColor = System.Drawing.Color.White;
            btnAdd.Location = new System.Drawing.Point(708, 257);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(160, 53);
            btnAdd.TabIndex = 39;
            btnAdd.Text = "Adauga";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.None;
            btnDelete.BackColor = System.Drawing.Color.Crimson;
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(341, 257);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(160, 53);
            btnDelete.TabIndex = 38;
            btnDelete.Text = "Sterge";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // Incarca_Poza
            // 
            Incarca_Poza.Anchor = AnchorStyles.None;
            Incarca_Poza.BackColor = System.Drawing.Color.Green;
            Incarca_Poza.ForeColor = System.Drawing.Color.White;
            Incarca_Poza.Location = new System.Drawing.Point(708, 190);
            Incarca_Poza.Name = "Incarca_Poza";
            Incarca_Poza.Size = new System.Drawing.Size(160, 53);
            Incarca_Poza.TabIndex = 37;
            Incarca_Poza.Text = "Incarca Poza";
            Incarca_Poza.UseVisualStyleBackColor = false;
            Incarca_Poza.Click += Incarca_Poza_Click;
            // 
            // imgStdInregistrare
            // 
            imgStdInregistrare.Anchor = AnchorStyles.None;
            imgStdInregistrare.BackColor = System.Drawing.Color.Gainsboro;
            imgStdInregistrare.Location = new System.Drawing.Point(708, 24);
            imgStdInregistrare.Name = "imgStdInregistrare";
            imgStdInregistrare.Size = new System.Drawing.Size(160, 160);
            imgStdInregistrare.SizeMode = PictureBoxSizeMode.StretchImage;
            imgStdInregistrare.TabIndex = 36;
            imgStdInregistrare.TabStop = false;
            // 
            // txtAdresa
            // 
            txtAdresa.Anchor = AnchorStyles.None;
            txtAdresa.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAdresa.Location = new System.Drawing.Point(126, 189);
            txtAdresa.Multiline = true;
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new System.Drawing.Size(525, 54);
            txtAdresa.TabIndex = 35;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            label5.Location = new System.Drawing.Point(52, 189);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(68, 19);
            label5.TabIndex = 34;
            label5.Text = "Adresa:";
            // 
            // radioButtonF
            // 
            radioButtonF.Anchor = AnchorStyles.None;
            radioButtonF.AutoSize = true;
            radioButtonF.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonF.ForeColor = System.Drawing.SystemColors.HotTrack;
            radioButtonF.Location = new System.Drawing.Point(582, 128);
            radioButtonF.Name = "radioButtonF";
            radioButtonF.Size = new System.Drawing.Size(87, 25);
            radioButtonF.TabIndex = 33;
            radioButtonF.TabStop = true;
            radioButtonF.Text = "Feminin";
            radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonM
            // 
            radioButtonM.Anchor = AnchorStyles.None;
            radioButtonM.AutoSize = true;
            radioButtonM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            radioButtonM.ForeColor = System.Drawing.SystemColors.HotTrack;
            radioButtonM.Location = new System.Drawing.Point(490, 128);
            radioButtonM.Name = "radioButtonM";
            radioButtonM.Size = new System.Drawing.Size(96, 25);
            radioButtonM.TabIndex = 32;
            radioButtonM.TabStop = true;
            radioButtonM.Text = "Masculin";
            radioButtonM.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            label4.Location = new System.Drawing.Point(444, 131);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(40, 19);
            label4.TabIndex = 31;
            label4.Text = "Sex:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.None;
            dateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker1.Location = new System.Drawing.Point(132, 125);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(290, 27);
            dateTimePicker1.TabIndex = 30;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            label3.Location = new System.Drawing.Point(16, 131);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(110, 19);
            label3.TabIndex = 29;
            label3.Text = "Data Nasterii:";
            // 
            // txtPreumeStd
            // 
            txtPreumeStd.Anchor = AnchorStyles.None;
            txtPreumeStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtPreumeStd.Location = new System.Drawing.Point(501, 24);
            txtPreumeStd.Name = "txtPreumeStd";
            txtPreumeStd.Size = new System.Drawing.Size(150, 27);
            txtPreumeStd.TabIndex = 28;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            label2.Location = new System.Drawing.Point(412, 27);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 19);
            label2.TabIndex = 27;
            label2.Text = "Prenume:";
            // 
            // txtNumeStd
            // 
            txtNumeStd.Anchor = AnchorStyles.None;
            txtNumeStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtNumeStd.Location = new System.Drawing.Point(132, 24);
            txtNumeStd.Name = "txtNumeStd";
            txtNumeStd.Size = new System.Drawing.Size(150, 27);
            txtNumeStd.TabIndex = 26;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            label1.Location = new System.Drawing.Point(65, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 19);
            label1.TabIndex = 25;
            label1.Text = "Nume:";
            // 
            // panel4
            // 
            panel4.Controls.Add(lbl_nrStd);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(Box_An);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtSearchInregistrare);
            panel4.Controls.Add(btnSearchInregistrare);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new System.Drawing.Point(0, 54);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(932, 64);
            panel4.TabIndex = 18;
            // 
            // lbl_nrStd
            // 
            lbl_nrStd.Anchor = AnchorStyles.None;
            lbl_nrStd.AutoSize = true;
            lbl_nrStd.Location = new System.Drawing.Point(26, 19);
            lbl_nrStd.Name = "lbl_nrStd";
            lbl_nrStd.Size = new System.Drawing.Size(132, 19);
            lbl_nrStd.TabIndex = 53;
            lbl_nrStd.Text = "Numar Studenti:";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(292, 19);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(118, 19);
            label10.TabIndex = 52;
            label10.Text = "Selectati Anul:";
            // 
            // Box_An
            // 
            Box_An.Anchor = AnchorStyles.None;
            Box_An.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Box_An.Location = new System.Drawing.Point(412, 17);
            Box_An.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            Box_An.Name = "Box_An";
            Box_An.Size = new System.Drawing.Size(52, 27);
            Box_An.TabIndex = 51;
            Box_An.ValueChanged += Box_An_ValueChanged;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            panel5.Location = new System.Drawing.Point(11, 59);
            panel5.Name = "panel5";
            panel5.Size = new System.Drawing.Size(909, 5);
            panel5.TabIndex = 50;
            // 
            // txtSearchInregistrare
            // 
            txtSearchInregistrare.Anchor = AnchorStyles.None;
            txtSearchInregistrare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSearchInregistrare.Location = new System.Drawing.Point(552, 15);
            txtSearchInregistrare.Name = "txtSearchInregistrare";
            txtSearchInregistrare.Size = new System.Drawing.Size(150, 27);
            txtSearchInregistrare.TabIndex = 49;
            // 
            // btnSearchInregistrare
            // 
            btnSearchInregistrare.Anchor = AnchorStyles.None;
            btnSearchInregistrare.BackColor = System.Drawing.Color.MediumSlateBlue;
            btnSearchInregistrare.ForeColor = System.Drawing.Color.White;
            btnSearchInregistrare.Location = new System.Drawing.Point(708, 2);
            btnSearchInregistrare.Name = "btnSearchInregistrare";
            btnSearchInregistrare.Size = new System.Drawing.Size(160, 53);
            btnSearchInregistrare.TabIndex = 48;
            btnSearchInregistrare.Text = "Cauta";
            btnSearchInregistrare.UseVisualStyleBackColor = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(932, 703);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridInregistrare);
            Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.SystemColors.HotTrack;
            Margin = new Padding(4);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ((System.ComponentModel.ISupportInitialize)dataGridInregistrare).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Gr).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_An).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgStdInregistrare).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Box_An).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridInregistrare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private Panel panel2;
        private Button btnUpdate;
        private Panel panel3;
        private NumericUpDown numericUpDown_Gr;
        private NumericUpDown numericUpDown_An;
        private Label label8;
        private Label label7;
        private Button btnAdd;
        private Button btnDelete;
        private Button Incarca_Poza;
        private PictureBox imgStdInregistrare;
        private TextBox txtAdresa;
        private Label label5;
        private RadioButton radioButtonF;
        private RadioButton radioButtonM;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox txtPreumeStd;
        private Label label2;
        private TextBox txtNumeStd;
        private Label label1;
        private Panel panel4;
        private TextBox txtSearchInregistrare;
        private Button btnSearchInregistrare;
        private Panel panel5;
        private Label label9;
        private TextBox txtEmail;
        private BindingSource bindingSource;
        private NumericUpDown Box_An;
        private Label lbl_nrStd;
        private Label label10;
    }
}