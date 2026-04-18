using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentNamespace;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void btnConf_Click(object sender, EventArgs e)
        {
            StudentInfo st = new StudentInfo(txbxFirstN.Text, txbxLastN.Text, txbxStudentNo.Text);
            if (string.IsNullOrWhiteSpace(txbxFirstN.Text) || string.IsNullOrWhiteSpace(txbxLastN.Text) && !string.IsNullOrWhiteSpace(txbxStudentNo.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            lsbxFirstN.Items.Add(st.firstName);
            lsbxLastN.Items.Add(st.lastName);
            lsbxStNo.Items.Add(st.studentNo);

            txbxFirstN.Clear();
            txbxLastN.Clear();
            txbxStudentNo.Clear();
        }
    }
}
