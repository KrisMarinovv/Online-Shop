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
    public partial class mainForm : Form
    {
        private profileForm ProfileFormInstance;
        public mainForm()
        {
            InitializeComponent();
        }

        public string username { get; set; }


        public void ShowProfileForm()
        {
            foreach (Control control in mainPanel.Controls)
            {
                mainPanel.Controls.Remove(control);
                control.Dispose();
            }

            if (ProfileFormInstance != null && !ProfileFormInstance.IsDisposed)
            {
                ProfileFormInstance.Close();
            }

            ProfileFormInstance = new profileForm();
            ProfileFormInstance.TopLevel = false;
            mainPanel.Controls.Add(ProfileFormInstance);
            ProfileFormInstance.Dock = DockStyle.Fill;
            ProfileFormInstance.Show();
            ProfileFormInstance.BringToFront();
        }

        private void loadform(object Form)
        {
            foreach (Control control in mainPanel.Controls)
            {
                mainPanel.Controls.Remove(control);
                control.Dispose();
            }

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(f);
            mainPanel.Tag = f;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void categoryBut_Load(object sender, EventArgs e)
        {

        }

        private void servicesBut_Click(object sender, EventArgs e)
        {
            loadform(new servicesForm());
        }

        void productsBut_Click(object sender, EventArgs e)
        {
            loadform(new productsForm());
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginForm loginFrm = new loginForm(this);
            loginFrm.ShowDialog();
        }

        private void profileBut_Click(object sender, EventArgs e)
        {
            loginForm loginFrm = new loginForm(this);
            loginFrm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
