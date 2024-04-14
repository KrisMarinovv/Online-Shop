using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Online_Shop.Resources;
using System.Windows.Forms;

namespace Online_Shop
{
    public partial class drillForm : Form
    {
        private mainForm MainFormInstance;

        public drillForm(mainForm mainFormInstance)
        {
            InitializeComponent();
            MainFormInstance = mainFormInstance;

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainFormInstance.items += 1;
            MainFormInstance.UpdateItemsLabel();
            //129.99

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainFormInstance.items += 1;
            MainFormInstance.UpdateItemsLabel();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            MainFormInstance.items += 1;
            MainFormInstance.UpdateItemsLabel();
        }
    }
}
