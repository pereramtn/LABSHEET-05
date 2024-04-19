using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part_B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsignup_Click(object sender, EventArgs e)
        {
            string FirstName = txtFname.Text;
            string LastName = txtLname.Text;
            string DOB = dateTimePicker1.Value.ToShortDateString();
            string Email = txtEmail.Text;
            string Username = txtUname.Text;
            string Password = txtPassword.Text;
            string ConfirmPassword = txtConfirmpassword.Text;
            bool Imnotarobbot = checkBox1.Checked;

            if (!string.IsNullOrWhiteSpace(FirstName) &&
                !string.IsNullOrWhiteSpace(LastName) &&
                !string.IsNullOrWhiteSpace(DOB) &&
                !string.IsNullOrWhiteSpace(Email) &&
                !string.IsNullOrWhiteSpace(Username) &&
                !string.IsNullOrWhiteSpace(Password) &&
                !string.IsNullOrWhiteSpace(ConfirmPassword) &&
                Password == ConfirmPassword &&
                Imnotarobbot)
            {
                if (AreAllFieldsStrings())
                {
                   
                    var userInterface = new UserInterface (FirstName, Username, Email);
                    userInterface.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("All fields should be strings.");
                }
            }
            else
            {
                MessageBox.Show("All fields are required and passwords must match.");
            }
        }
        private bool AreAllFieldsStrings()
        {
            
            return true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            dateTimePicker1.Value = DateTime.Today;
            txtEmail.Clear();
            txtUname.Clear();
            txtPassword.Clear();
            txtConfirmpassword.Clear();
        }
    }
    }

