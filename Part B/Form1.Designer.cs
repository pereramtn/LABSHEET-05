namespace Part_B
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
            this.btnsignup = new System.Windows.Forms.Button();
            this.lBLSIGNUP = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblconfirmpassword = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUname = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmpassword = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsignup
            // 
            this.btnsignup.BackColor = System.Drawing.Color.MistyRose;
            this.btnsignup.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignup.ForeColor = System.Drawing.Color.Maroon;
            this.btnsignup.Location = new System.Drawing.Point(453, 602);
            this.btnsignup.Name = "btnsignup";
            this.btnsignup.Size = new System.Drawing.Size(183, 50);
            this.btnsignup.TabIndex = 1;
            this.btnsignup.Text = "SIGN UP";
            this.btnsignup.UseVisualStyleBackColor = false;
            this.btnsignup.Click += new System.EventHandler(this.btnsignup_Click);
            // 
            // lBLSIGNUP
            // 
            this.lBLSIGNUP.AutoSize = true;
            this.lBLSIGNUP.BackColor = System.Drawing.Color.Maroon;
            this.lBLSIGNUP.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLSIGNUP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lBLSIGNUP.Location = new System.Drawing.Point(368, 67);
            this.lBLSIGNUP.Name = "lBLSIGNUP";
            this.lBLSIGNUP.Size = new System.Drawing.Size(327, 46);
            this.lBLSIGNUP.TabIndex = 2;
            this.lBLSIGNUP.Text = "SIGN UP HERE";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.Maroon;
            this.lblFname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFname.Location = new System.Drawing.Point(215, 169);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(141, 31);
            this.lblFname.TabIndex = 3;
            this.lblFname.Text = "First Name";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.BackColor = System.Drawing.Color.Maroon;
            this.lblLname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLname.Location = new System.Drawing.Point(215, 217);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(137, 31);
            this.lblLname.TabIndex = 4;
            this.lblLname.Text = "Last Name";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.BackColor = System.Drawing.Color.Maroon;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDOB.Location = new System.Drawing.Point(215, 269);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(164, 31);
            this.lblDOB.TabIndex = 5;
            this.lblDOB.Text = "Date of Birth";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Maroon;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbladdress.Location = new System.Drawing.Point(215, 323);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(176, 31);
            this.lbladdress.TabIndex = 6;
            this.lbladdress.Text = "Email Address";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(192, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(697, 700);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Maroon;
            this.lblUname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUname.Location = new System.Drawing.Point(215, 389);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(130, 31);
            this.lblUname.TabIndex = 7;
            this.lblUname.Text = "Username";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Maroon;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblpassword.Location = new System.Drawing.Point(221, 440);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(124, 31);
            this.lblpassword.TabIndex = 8;
            this.lblpassword.Text = "Password";
            // 
            // lblconfirmpassword
            // 
            this.lblconfirmpassword.AutoSize = true;
            this.lblconfirmpassword.BackColor = System.Drawing.Color.Maroon;
            this.lblconfirmpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfirmpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblconfirmpassword.Location = new System.Drawing.Point(215, 495);
            this.lblconfirmpassword.Name = "lblconfirmpassword";
            this.lblconfirmpassword.Size = new System.Drawing.Size(232, 31);
            this.lblconfirmpassword.TabIndex = 9;
            this.lblconfirmpassword.Text = "Confirm Password ";
            // 
            // txtFname
            // 
            this.txtFname.BackColor = System.Drawing.Color.MistyRose;
            this.txtFname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtFname.Location = new System.Drawing.Point(453, 163);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(398, 37);
            this.txtFname.TabIndex = 10;
            // 
            // txtLname
            // 
            this.txtLname.BackColor = System.Drawing.Color.MistyRose;
            this.txtLname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtLname.Location = new System.Drawing.Point(453, 211);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(398, 37);
            this.txtLname.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.MistyRose;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.DarkRed;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(453, 267);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(398, 33);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.MistyRose;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtEmail.Location = new System.Drawing.Point(453, 317);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(398, 37);
            this.txtEmail.TabIndex = 13;
            // 
            // txtUname
            // 
            this.txtUname.BackColor = System.Drawing.Color.MistyRose;
            this.txtUname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUname.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtUname.Location = new System.Drawing.Point(453, 383);
            this.txtUname.Name = "txtUname";
            this.txtUname.Size = new System.Drawing.Size(308, 37);
            this.txtUname.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtPassword.Location = new System.Drawing.Point(453, 438);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(308, 37);
            this.txtPassword.TabIndex = 15;
            // 
            // txtConfirmpassword
            // 
            this.txtConfirmpassword.BackColor = System.Drawing.Color.MistyRose;
            this.txtConfirmpassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmpassword.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txtConfirmpassword.Location = new System.Drawing.Point(453, 489);
            this.txtConfirmpassword.Name = "txtConfirmpassword";
            this.txtConfirmpassword.Size = new System.Drawing.Size(308, 37);
            this.txtConfirmpassword.TabIndex = 16;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.MistyRose;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(453, 553);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(183, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "I\'m not a robbot";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LightCoral;
            this.btnReset.Font = new System.Drawing.Font("Cooper Black", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(486, 678);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(113, 34);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Part_B.Properties.Resources.f486df6cee496b1f24839fe3ebe1f909;
            this.ClientSize = new System.Drawing.Size(1052, 744);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtConfirmpassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.lblconfirmpassword);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblDOB);
            this.Controls.Add(this.lblLname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lBLSIGNUP);
            this.Controls.Add(this.btnsignup);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Sign Up Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnsignup;
        private System.Windows.Forms.Label lBLSIGNUP;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblconfirmpassword;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUname;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtConfirmpassword;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnReset;
    }
}

