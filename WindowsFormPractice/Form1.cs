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
    public partial class Form1 : Form
    {
        string name = "23-54475-3", pass = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textuser.Text == "")
                lbluname.Text = "UserName is Required";
            if (textpass.Text == "")
                lblpassrequired.Text = "PassWord is Required";

            if (textuser.Text == name && textpass.Text == pass)
                MessageBox.Show("Login SuccesFully");
            else
                MessageBox.Show("Invalid username and password");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
