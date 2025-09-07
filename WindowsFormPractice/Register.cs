using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormPractice
{
    public partial class Register : Form
    {
        private string Fname, lname, Nationality, dateofbirth, gender, qua;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.CenterToScreen();
            }
        }

        private void lblGen_Click(object sender, EventArgs e)
        {

        }

        private void lblQua_Click(object sender, EventArgs e)
        {

        }

        private void lblMarital_Click(object sender, EventArgs e)
        {

        }

        private void lblnation_Click(object sender, EventArgs e)
        {

        }

        private void lblDob_Click(object sender, EventArgs e)
        {

        }

        private void chkMsc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnregister_Click(object sender, EventArgs e)
        {

            Fname = textBox1.Text;
            lname = textBox2.Text;
            Nationality = textBox3.Text;
            qua = lblQua.Text;
            dateofbirth = lblDob.Text;

            if (rdbMale.Checked)
                gender = "Male";
            if (rdbFemale.Checked)
                gender = "Female";

            MessageBox.Show($"Name: {Fname} {lname}, Nationality: {Nationality}, Gender: {gender},Date Of Birth: {dateofbirth}, QuaLification: {qua}");
        }
    }
}
