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
        private drillForm DrillsFormInstance;
        private anglesForm AnglesFormInstance;
        private jigsawForm JigsawsFormInstance;

        public int items { get; set; }
        public mainForm()
        {
            InitializeComponent();
            items = 0;
            label3.Text = items.ToString();
        }

        public string username { get; set; }

        public void UpdateItemsLabel()
        {
            label3.Text = items.ToString();
        }
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
        public void ShowDrillsForm()
        {
            foreach (Control control in mainPanel.Controls)
            {
                mainPanel.Controls.Remove(control);
                control.Dispose();
            }

            if (DrillsFormInstance != null && !DrillsFormInstance.IsDisposed)
            {
                DrillsFormInstance.Close();
            }

            DrillsFormInstance = new drillForm(this);
            DrillsFormInstance.TopLevel = false;
            mainPanel.Controls.Add(DrillsFormInstance);
            DrillsFormInstance.Dock = DockStyle.Fill;
            DrillsFormInstance.Show();
            DrillsFormInstance.BringToFront();
        }
        public void ShowAnglesForm()
        {
            foreach (Control control in mainPanel.Controls)
            {
                mainPanel.Controls.Remove(control);
                control.Dispose();
            }

            if (AnglesFormInstance != null && !AnglesFormInstance.IsDisposed)
            {
                AnglesFormInstance.Close();
            }

            AnglesFormInstance = new anglesForm(this);
            AnglesFormInstance.TopLevel = false;
            mainPanel.Controls.Add(AnglesFormInstance);
            AnglesFormInstance.Dock = DockStyle.Fill;
            AnglesFormInstance.Show();
            AnglesFormInstance.BringToFront();
        }
        public void ShowJigsawsForm()
        {
            foreach (Control control in mainPanel.Controls)
            {
                mainPanel.Controls.Remove(control);
                control.Dispose();
            }

            if (JigsawsFormInstance != null && !JigsawsFormInstance.IsDisposed)
            {
                JigsawsFormInstance.Close();
            }

            JigsawsFormInstance = new jigsawForm(this);
            JigsawsFormInstance.TopLevel = false;
            mainPanel.Controls.Add(JigsawsFormInstance);
            JigsawsFormInstance.Dock = DockStyle.Fill;
            JigsawsFormInstance.Show();
            JigsawsFormInstance.BringToFront();
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
            loadform(new servicesForm(this));
        }

        void productsBut_Click(object sender, EventArgs e)
        {
            loadform(new productsForm(this));
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

        private void cartBut_Click(object sender, EventArgs e)
        {
            cartForm cartFrm = new cartForm();
            cartFrm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            cartForm cartFrm = new cartForm();
            cartFrm.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            cartForm cartFrm = new cartForm();
            cartFrm.ShowDialog();
        }
    }
}
