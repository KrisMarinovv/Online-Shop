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
    public partial class jigsawForm : Form
    {
        private mainForm MainFormInstance;

        public jigsawForm(mainForm mainFormInstance)
        {
            InitializeComponent();
            MainFormInstance = mainFormInstance;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainFormInstance.items += 1;
            MainFormInstance.UpdateItemsLabel();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainFormInstance.items += 1;
            MainFormInstance.UpdateItemsLabel();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MainFormInstance.items += 1;
            MainFormInstance.UpdateItemsLabel();
        }
    }
}
