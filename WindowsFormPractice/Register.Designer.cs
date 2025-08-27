namespace WindowsFormPractice
{
    partial class Register
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
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.lblnation = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblMarital = new System.Windows.Forms.Label();
            this.lblQua = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdbUnmarried = new System.Windows.Forms.RadioButton();
            this.rdbMarried = new System.Windows.Forms.RadioButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.chkbsc = new System.Windows.Forms.CheckBox();
            this.chkPhd = new System.Windows.Forms.CheckBox();
            this.chkMsc = new System.Windows.Forms.CheckBox();
            this.lblregisterNow = new System.Windows.Forms.Label();
            this.btnregister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFN.Location = new System.Drawing.Point(116, 89);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(113, 25);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "First Name: ";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLN.Location = new System.Drawing.Point(117, 125);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(106, 25);
            this.lblLN.TabIndex = 1;
            this.lblLN.Text = "Last Name:";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGen.Location = new System.Drawing.Point(119, 185);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(80, 25);
            this.lblGen.TabIndex = 2;
            this.lblGen.Text = "Gender:";
            this.lblGen.Click += new System.EventHandler(this.lblGen_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(118, 255);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(128, 25);
            this.lblDob.TabIndex = 3;
            this.lblDob.Text = "Date of Birth:";
            this.lblDob.Click += new System.EventHandler(this.lblDob_Click);
            // 
            // lblnation
            // 
            this.lblnation.AutoSize = true;
            this.lblnation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnation.Location = new System.Drawing.Point(120, 308);
            this.lblnation.Name = "lblnation";
            this.lblnation.Size = new System.Drawing.Size(112, 25);
            this.lblnation.TabIndex = 4;
            this.lblnation.Text = "Nationality:";
            this.lblnation.Click += new System.EventHandler(this.lblnation_Click);
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(119, 345);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(126, 25);
            this.lblDepart.TabIndex = 5;
            this.lblDepart.Text = "DepartMent: ";
            // 
            // lblMarital
            // 
            this.lblMarital.AutoSize = true;
            this.lblMarital.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarital.Location = new System.Drawing.Point(120, 411);
            this.lblMarital.Name = "lblMarital";
            this.lblMarital.Size = new System.Drawing.Size(128, 23);
            this.lblMarital.TabIndex = 6;
            this.lblMarital.Text = "Marital Status:";
            this.lblMarital.Click += new System.EventHandler(this.lblMarital_Click);
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQua.Location = new System.Drawing.Point(115, 514);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(140, 25);
            this.lblQua.TabIndex = 7;
            this.lblQua.Text = "Qualifications: ";
            this.lblQua.Click += new System.EventHandler(this.lblQua_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(119, 465);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 25);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbFemale);
            this.panel1.Controls.Add(this.rdbMale);
            this.panel1.Location = new System.Drawing.Point(248, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 49);
            this.panel1.TabIndex = 9;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(19, 15);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(58, 20);
            this.rdbMale.TabIndex = 0;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(118, 15);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(74, 20);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "FeMale";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(251, 257);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(243, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(248, 129);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(249, 312);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(199, 22);
            this.textBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "CNCS",
            "DS",
            "ENGLISH"});
            this.comboBox1.Location = new System.Drawing.Point(249, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(199, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdbUnmarried);
            this.panel2.Controls.Add(this.rdbMarried);
            this.panel2.Location = new System.Drawing.Point(249, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 49);
            this.panel2.TabIndex = 10;
            // 
            // rdbUnmarried
            // 
            this.rdbUnmarried.AutoSize = true;
            this.rdbUnmarried.Location = new System.Drawing.Point(118, 15);
            this.rdbUnmarried.Name = "rdbUnmarried";
            this.rdbUnmarried.Size = new System.Drawing.Size(91, 20);
            this.rdbUnmarried.TabIndex = 1;
            this.rdbUnmarried.TabStop = true;
            this.rdbUnmarried.Text = "UnMarried";
            this.rdbUnmarried.UseVisualStyleBackColor = true;
            // 
            // rdbMarried
            // 
            this.rdbMarried.AutoSize = true;
            this.rdbMarried.Location = new System.Drawing.Point(19, 15);
            this.rdbMarried.Name = "rdbMarried";
            this.rdbMarried.Size = new System.Drawing.Size(74, 20);
            this.rdbMarried.TabIndex = 0;
            this.rdbMarried.TabStop = true;
            this.rdbMarried.Text = "Married";
            this.rdbMarried.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(248, 469);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(209, 22);
            this.textBox4.TabIndex = 15;
            // 
            // chkbsc
            // 
            this.chkbsc.AutoSize = true;
            this.chkbsc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbsc.Location = new System.Drawing.Point(255, 516);
            this.chkbsc.Name = "chkbsc";
            this.chkbsc.Size = new System.Drawing.Size(55, 24);
            this.chkbsc.TabIndex = 16;
            this.chkbsc.Text = "Bsc";
            this.chkbsc.UseVisualStyleBackColor = true;
            // 
            // chkPhd
            // 
            this.chkPhd.AutoSize = true;
            this.chkPhd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkPhd.Location = new System.Drawing.Point(390, 516);
            this.chkPhd.Name = "chkPhd";
            this.chkPhd.Size = new System.Drawing.Size(58, 24);
            this.chkPhd.TabIndex = 17;
            this.chkPhd.Text = "Phd";
            this.chkPhd.UseVisualStyleBackColor = true;
            // 
            // chkMsc
            // 
            this.chkMsc.AutoSize = true;
            this.chkMsc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMsc.Location = new System.Drawing.Point(319, 517);
            this.chkMsc.Name = "chkMsc";
            this.chkMsc.Size = new System.Drawing.Size(59, 24);
            this.chkMsc.TabIndex = 18;
            this.chkMsc.Text = "Msc";
            this.chkMsc.UseVisualStyleBackColor = true;
            this.chkMsc.CheckedChanged += new System.EventHandler(this.chkMsc_CheckedChanged);
            // 
            // lblregisterNow
            // 
            this.lblregisterNow.AutoSize = true;
            this.lblregisterNow.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregisterNow.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblregisterNow.Location = new System.Drawing.Point(245, 33);
            this.lblregisterNow.Name = "lblregisterNow";
            this.lblregisterNow.Size = new System.Drawing.Size(157, 31);
            this.lblregisterNow.TabIndex = 19;
            this.lblregisterNow.Text = "Register Now";
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Navy;
            this.btnregister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnregister.Location = new System.Drawing.Point(267, 564);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(88, 38);
            this.btnregister.TabIndex = 20;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(651, 638);
            this.Controls.Add(this.btnregister);
            this.Controls.Add(this.lblregisterNow);
            this.Controls.Add(this.chkMsc);
            this.Controls.Add(this.chkPhd);
            this.Controls.Add(this.chkbsc);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblQua);
            this.Controls.Add(this.lblMarital);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblnation);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblGen);
            this.Controls.Add(this.lblLN);
            this.Controls.Add(this.lblFN);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblnation;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblMarital;
        private System.Windows.Forms.Label lblQua;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdbUnmarried;
        private System.Windows.Forms.RadioButton rdbMarried;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.CheckBox chkbsc;
        private System.Windows.Forms.CheckBox chkPhd;
        private System.Windows.Forms.CheckBox chkMsc;
        private System.Windows.Forms.Label lblregisterNow;
        private System.Windows.Forms.Button btnregister;
    }
}