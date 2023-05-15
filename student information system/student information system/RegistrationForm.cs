using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace student_information_system
{
    public partial class RegistrationForm : Form
    {

        DatabaseManager d = new DatabaseManager();
        SqlConnection myCon = new SqlConnection();
        DataSet dsStd;
        SqlDataAdapter daStd;
        int An;
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        SqlDataAdapter dataAdapter;
        public RegistrationForm()
        {

            AllocConsole();
            InitializeComponent();

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseManager d = new DatabaseManager();
            string firstName = txtNumeStd.Text;
            string lastName = txtPreumeStd.Text;
            string adress = txtAdresa.Text;
            DateTime dateofbirth = dateTimePicker1.Value.ToUniversalTime();
            int year = Decimal.ToInt32(numericUpDown_An.Value);
            int group = Decimal.ToInt32(numericUpDown_Gr.Value);
            string sex = "";
            string email = txtEmail.Text;
            if (radioButtonM.Checked)
            {
                sex = "M";
            }
            else if (radioButtonF.Checked)
            {
                sex = "F";
            }
            byte[] photo = null;
            if (imgStdInregistrare.Image != null)
            {
                using (MemoryStream stream = new MemoryStream())
                {
                    imgStdInregistrare.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    photo = stream.ToArray();
                }
            }

            d.InsertStudent(group, firstName, lastName, dateofbirth, sex, year, adress, photo, email);
        }

        private void Incarca_Poza_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                openFileDialog.Title = "Select Photo";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imgStdInregistrare.ImageLocation = openFileDialog.FileName;
                }
            }
        }

        public void LoadDataGrid()
        {


            if (dsStd != null)
                dsStd.Tables["Students"].Clear();

            myCon = d.GetConnection();
            myCon.Open();
            dsStd = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(@"SELECT * FROM Students WHERE Year = @An;", myCon);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@An", An);
            dataAdapter.Fill(dsStd, "Students");
            myCon.Close();
            bindingSource.DataSource = dsStd.Tables["Students"];
            dataGridInregistrare.DataSource = bindingSource;

        }

        private void Box_An_ValueChanged(object sender, EventArgs e)
        {

            An = Convert.ToInt32(Box_An.Value);
            Console.WriteLine(An);
            LoadDataGrid();
        }

        private void dataGridInregistrare_Resize(object sender, EventArgs e)
        {
            if (dataGridInregistrare.Rows.Count == 0)
                return;
            int visibleColumnCount = dataGridInregistrare.Columns.GetColumnCount(DataGridViewElementStates.Visible);
            int availableWidth = dataGridInregistrare.ClientSize.Width;

            int newColumnWidth = availableWidth / visibleColumnCount;

            foreach (DataGridViewColumn column in dataGridInregistrare.Columns)
            {
                if (column.Visible)
                {
                    column.Width = newColumnWidth;
                }
            }
        }

        private void dataGridInregistrare_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridInregistrare.Rows.Count - 1) // // Check if a valid non-empty row is selected
            {
                DataGridViewRow selectedRow = dataGridInregistrare.Rows[e.RowIndex];
                txtEmail.Text = selectedRow.Cells[1].Value.ToString();
                txtNumeStd.Text = selectedRow.Cells[3].Value.ToString();
                txtPreumeStd.Text = selectedRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[5].Value.ToString();
                txtAdresa.Text = selectedRow.Cells[8].Value.ToString();
                numericUpDown_An.Value = Convert.ToDecimal(selectedRow.Cells[7].Value);
                numericUpDown_Gr.Value = Convert.ToDecimal(selectedRow.Cells[2].Value);
                if (selectedRow.Cells[9].Value != null)
                {
                    using (MemoryStream stream = new MemoryStream((byte[])selectedRow.Cells[9].Value))
                    {
                        imgStdInregistrare.Image = Image.FromStream(stream);
                    }
                }
                else
                {
                        imgStdInregistrare.Image = null;
                }
            }
        }
    }
}
