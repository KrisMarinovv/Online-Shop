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
    public partial class productsForm : Form
    {
        private mainForm MainFormInstance;
        public productsForm(mainForm mainFormInstance)
        {
            InitializeComponent();
            MainFormInstance = mainFormInstance;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainFormInstance.ShowDrillsForm();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainFormInstance.ShowAnglesForm();
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            MainFormInstance.ShowJigsawsForm();
            this.Close();
        }
    }
}
