namespace WindowsFormPractice
{
    partial class Form1
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblpass = new System.Windows.Forms.Label();
            this.textuser = new System.Windows.Forms.TextBox();
            this.textpass = new System.Windows.Forms.TextBox();
            this.lblpassrequired = new System.Windows.Forms.Label();
            this.lblForgot = new System.Windows.Forms.Label();
            this.lbluname = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.logoPanel.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblMessage.Location = new System.Drawing.Point(131, 263);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(231, 17);
            this.lblMessage.TabIndex = 4;
            this.lblMessage.Text = "Sign in With your Organizational ID";
            this.lblMessage.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(57, 172);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(127, 28);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User Name :";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblUser.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblpass
            // 
            this.lblpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblpass.AutoSize = true;
            this.lblpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpass.Location = new System.Drawing.Point(57, 216);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(121, 28);
            this.lblpass.TabIndex = 6;
            this.lblpass.Text = "PassWord  :";
            this.lblpass.Click += new System.EventHandler(this.label2_Click);
            // 
            // textuser
            // 
            this.textuser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textuser.Location = new System.Drawing.Point(196, 173);
            this.textuser.Name = "textuser";
            this.textuser.Size = new System.Drawing.Size(191, 22);
            this.textuser.TabIndex = 7;
            // 
            // textpass
            // 
            this.textpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textpass.Location = new System.Drawing.Point(196, 217);
            this.textpass.Name = "textpass";
            this.textpass.PasswordChar = '*';
            this.textpass.Size = new System.Drawing.Size(191, 22);
            this.textpass.TabIndex = 8;
            // 
            // lblpassrequired
            // 
            this.lblpassrequired.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpassrequired.AutoSize = true;
            this.lblpassrequired.Font = new System.Drawing.Font("Times New Roman", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassrequired.ForeColor = System.Drawing.Color.Brown;
            this.lblpassrequired.Location = new System.Drawing.Point(208, 242);
            this.lblpassrequired.Name = "lblpassrequired";
            this.lblpassrequired.Size = new System.Drawing.Size(0, 15);
            this.lblpassrequired.TabIndex = 11;
            // 
            // lblForgot
            // 
            this.lblForgot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblForgot.AutoSize = true;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.Maroon;
            this.lblForgot.Location = new System.Drawing.Point(329, 417);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(150, 17);
            this.lblForgot.TabIndex = 12;
            this.lblForgot.Text = "Forgot Your PassWord?";
            // 
            // lbluname
            // 
            this.lbluname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbluname.AutoSize = true;
            this.lbluname.Font = new System.Drawing.Font("Times New Roman", 7.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluname.ForeColor = System.Drawing.Color.Brown;
            this.lbluname.Location = new System.Drawing.Point(208, 195);
            this.lbluname.Name = "lbluname";
            this.lbluname.Size = new System.Drawing.Size(0, 15);
            this.lbluname.TabIndex = 13;
            this.lbluname.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.DarkBlue;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(196, 309);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(86, 40);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPanel.BackColor = System.Drawing.Color.White;
            this.logoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoPanel.Controls.Add(this.flowLayoutPanel2);
            this.logoPanel.ForeColor = System.Drawing.Color.Transparent;
            this.logoPanel.Location = new System.Drawing.Point(3, 4);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(495, 61);
            this.logoPanel.TabIndex = 2;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.lblLogo);
            this.flowLayoutPanel2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(478, 51);
            this.flowLayoutPanel2.TabIndex = 3;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel2_Paint);
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLogo.Location = new System.Drawing.Point(3, 0);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(119, 54);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "AIUB";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLogo.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Location = new System.Drawing.Point(248, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 22);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(503, 471);
            this.Controls.Add(this.logoPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbluname);
            this.Controls.Add(this.lblForgot);
            this.Controls.Add(this.lblpassrequired);
            this.Controls.Add(this.textpass);
            this.Controls.Add(this.textuser);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnLogin);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Login Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.logoPanel.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.TextBox textuser;
        private System.Windows.Forms.TextBox textpass;
        private System.Windows.Forms.Label lblpassrequired;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label lbluname;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.FlowLayoutPanel logoPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

