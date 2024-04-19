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
    public partial class UserInterface : Form
    {
        public UserInterface(string firstName, string username, string email)
        {
            InitializeComponent();

           
           lblFname.Text = $"First Name: {firstName}";
            lblUname.Text = $"Username: {username}";
            lbladdress.Text = $"Email: {email}";
        }
    }
}
