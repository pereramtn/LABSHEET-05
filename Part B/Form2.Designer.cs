namespace Part_B
{
    partial class UserInterface
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblUname = new System.Windows.Forms.Label();
            this.lblhello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Maroon;
            this.pictureBox1.Location = new System.Drawing.Point(64, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 344);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Maroon;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbladdress.Location = new System.Drawing.Point(133, 405);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(0, 31);
            this.lbladdress.TabIndex = 11;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.BackColor = System.Drawing.Color.Maroon;
            this.lblFname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFname.Location = new System.Drawing.Point(133, 284);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(0, 31);
            this.lblFname.TabIndex = 12;
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Maroon;
            this.lblUname.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUname.Location = new System.Drawing.Point(133, 343);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(0, 31);
            this.lblUname.TabIndex = 13;
            // 
            // lblhello
            // 
            this.lblhello.AutoSize = true;
            this.lblhello.BackColor = System.Drawing.Color.Maroon;
            this.lblhello.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhello.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblhello.Location = new System.Drawing.Point(78, 195);
            this.lblhello.Name = "lblhello";
            this.lblhello.Size = new System.Drawing.Size(146, 39);
            this.lblhello.TabIndex = 14;
            this.lblhello.Text = "Hello...!";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Part_B.Properties.Resources.f486df6cee496b1f24839fe3ebe1f909;
            this.ClientSize = new System.Drawing.Size(724, 650);
            this.Controls.Add(this.lblhello);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lblFname);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.TransparencyKey = System.Drawing.Color.White;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.Label lblhello;
    }
}