using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shop
{
    public partial class loginForm : Form
    {
        private mainForm MainFormInstance;
        public static int count = 0;
        public loginForm(mainForm mainFormInstance)
        {
            InitializeComponent();
            MainFormInstance = mainFormInstance;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 != 0)
            {
                txtPassword.PasswordChar = '\0';
                pictureBox4.Image = Properties.Resources.hide;
            }
            else
            {
                txtPassword.PasswordChar = '•';
                pictureBox4.Image = Properties.Resources.view;
            }
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (true)
            {
                mainForm mainfrm = new mainForm();
                mainfrm.username = txtUsername.Text; 
                MainFormInstance.ShowProfileForm();
                this.Close();
                }
            else
            {
                MessageBox.Show("Login failed. Please try again.");
            }
        }
    }
}
