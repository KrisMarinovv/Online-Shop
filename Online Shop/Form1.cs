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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            menuBut.Text = "Меню";
            categoryBut.Text = "Категории";
            roundControl3.Text = "Hoome";
            cartBut.Text = "Количка";
            profileBut.Text = "Профил";
        }

        private void loadform(object Form)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(f);
            this.mainPanel.Tag = f;
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

        private void menuBut_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void categoryBut_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show("sss");
        }
    }
}
