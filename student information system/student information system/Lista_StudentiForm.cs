using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_information_system
{
    public partial class Lista_StudentiForm : Form
    {
        public Lista_StudentiForm(string grupa)
        {
            InitializeComponent();
            lblGrupaStd.Text = $"{grupa}";
        }

        private void Lista_Studenti_Load(object sender, EventArgs e)
        {
            //labelGrupa.Text = "Grupa" + student.getGroup(); ?
        }
    }
}
