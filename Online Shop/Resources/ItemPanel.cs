using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Online_Shop.Resources
{
    public partial class ItemPanel : UserControl
    {
        public ItemPanel(string itemName, decimal itemPrice)
        {
            InitializeComponent();
            nameLbl.Text = itemName;
            priceLbl.Text = itemPrice.ToString("C");
        }

        private void ItemPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
