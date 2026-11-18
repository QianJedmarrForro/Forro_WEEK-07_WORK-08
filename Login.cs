using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forro_Practice
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private readonly Users users;

        public Login(Users registeredUser)
        {
            InitializeComponent();
            users = registeredUser;
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbHidepassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !cbHidepassword.Checked;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
              if (txtUsername.Text == "Qian" && txtPassword.Text == "1234")
                {
                    Inventory inventory = new Inventory();
                    inventory.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please sign up if you don't have an account.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            
        }

        private void linkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup signup = new Signup();
            signup.Show();
            this.Hide();
        }
    }
}
