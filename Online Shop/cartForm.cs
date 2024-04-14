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
    public partial class cartForm : Form
    {

        public cartForm()
        {
            InitializeComponent();

            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
