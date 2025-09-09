using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;   // এটা নতুন যোগ করলাম (for ColorMatrix)
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

        private void Form1_Load(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.CenterToScreen();
            }

           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (textuser.Text == "")
            {
                lbluname.Text = "UserName is Required";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {
            lblWel.Text = ($"WelCome to, {name}");
        }

        private void lblForgot_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_4(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
           Console.Write("tisha");
           Console.Write("mahfuj");
           Console.Write("mahfuj");
        }

        
    }
}
