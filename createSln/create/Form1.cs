using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace create
{
    public partial class Form1 : Form
    {
        private string uname, pass, email, dob, gender, qua, depart;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(this.WindowState==FormWindowState.Normal)
                this.CenterToScreen();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            uname = textuname.Text;
            pass = textpass.Text;
            email = textemail.Text;
            dob = lbldob.Text;

            //if (lblgen.Checked)
            //    gender = "male";
            //if (lblgen.Checked)
            //    gender = "femalemale";
          
            MessageBox.Show($"Username: {uname},pass: {pass}, email: {email},dob: {dob}");
        }
    }
}
