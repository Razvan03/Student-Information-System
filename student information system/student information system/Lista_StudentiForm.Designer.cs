namespace student_information_system
{
    partial class Lista_StudentiForm
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
            label6 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblGrupaStd = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            lbl_nrStd = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            Box_An = new System.Windows.Forms.NumericUpDown();
            textBox4 = new System.Windows.Forms.TextBox();
            Search_Gr = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Box_An).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(385, 9);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(142, 25);
            label6.TabIndex = 0;
            label6.Text = "Lista Studenti";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            panel1.Controls.Add(lblGrupaStd);
            panel1.Controls.Add(label6);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(934, 70);
            panel1.TabIndex = 17;
            // 
            // lblGrupaStd
            // 
            lblGrupaStd.Anchor = System.Windows.Forms.AnchorStyles.None;
            lblGrupaStd.AutoSize = true;
            lblGrupaStd.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblGrupaStd.ForeColor = System.Drawing.Color.White;
            lblGrupaStd.Location = new System.Drawing.Point(407, 34);
            lblGrupaStd.Name = "lblGrupaStd";
            lblGrupaStd.Size = new System.Drawing.Size(96, 25);
            lblGrupaStd.TabIndex = 2;
            lblGrupaStd.Text = "Grupa x";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.White;
            panel2.Controls.Add(lbl_nrStd);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(Box_An);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(Search_Gr);
            panel2.Dock = System.Windows.Forms.DockStyle.Top;
            panel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            panel2.Location = new System.Drawing.Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(934, 70);
            panel2.TabIndex = 18;
            // 
            // lbl_nrStd
            // 
            lbl_nrStd.Anchor = System.Windows.Forms.AnchorStyles.None;
            lbl_nrStd.AutoSize = true;
            lbl_nrStd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_nrStd.ForeColor = System.Drawing.SystemColors.HotTrack;
            lbl_nrStd.Location = new System.Drawing.Point(32, 27);
            lbl_nrStd.Name = "lbl_nrStd";
            lbl_nrStd.Size = new System.Drawing.Size(132, 19);
            lbl_nrStd.TabIndex = 56;
            lbl_nrStd.Text = "Numar Studenti:";
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            label10.Location = new System.Drawing.Point(298, 27);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(118, 19);
            label10.TabIndex = 55;
            label10.Text = "Selectati Anul:";
            // 
            // Box_An
            // 
            Box_An.Anchor = System.Windows.Forms.AnchorStyles.None;
            Box_An.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Box_An.Location = new System.Drawing.Point(418, 25);
            Box_An.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            Box_An.Name = "Box_An";
            Box_An.Size = new System.Drawing.Size(52, 27);
            Box_An.TabIndex = 54;
            // 
            // textBox4
            // 
            textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            textBox4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBox4.Location = new System.Drawing.Point(606, 19);
            textBox4.Name = "textBox4";
            textBox4.Size = new System.Drawing.Size(150, 27);
            textBox4.TabIndex = 51;
            // 
            // Search_Gr
            // 
            Search_Gr.Anchor = System.Windows.Forms.AnchorStyles.None;
            Search_Gr.BackColor = System.Drawing.Color.MediumSlateBlue;
            Search_Gr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Search_Gr.ForeColor = System.Drawing.Color.White;
            Search_Gr.Location = new System.Drawing.Point(762, 6);
            Search_Gr.Name = "Search_Gr";
            Search_Gr.Size = new System.Drawing.Size(160, 53);
            Search_Gr.TabIndex = 50;
            Search_Gr.Text = "Cauta";
            Search_Gr.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.GridColor = System.Drawing.Color.Gainsboro;
            dataGridView1.Location = new System.Drawing.Point(0, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(934, 571);
            dataGridView1.TabIndex = 19;
            // 
            // Lista_StudentiForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(934, 711);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Lista_StudentiForm";
            Text = "Lista_Studenti";
            Load += Lista_Studenti_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Box_An).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button Search_Gr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblGrupaStd;
        private System.Windows.Forms.Label lbl_nrStd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Box_An;
    }
}