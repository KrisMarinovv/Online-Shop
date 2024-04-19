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
            AddItemPanel();
        }

        public void AddItemPanel()
        {
            try
            {
                // Create an ItemPanel instance
                ItemPanel itemPanel = new ItemPanel("Item Name", 123.45m); // Example values

                // Add the ItemPanel to the UI
                flowLayoutPanel1.Controls.Add(itemPanel);

                // Get the index of the ItemPanel within the flowLayoutPanel1.Controls collection
                int index = flowLayoutPanel1.Controls.IndexOf(itemPanel);

                // Display the index using MessageBox (you can also use Console.WriteLine for debugging)
                MessageBox.Show("ItemPanel index: " + index);

                // Check if the ItemPanel is added to the flowLayoutPanel1.Controls collection
                if (flowLayoutPanel1.Controls.Contains(itemPanel))
                {
                    // ItemPanel is added successfully
                    MessageBox.Show("ItemPanel added successfully!");
                }
                else
                {
                    // ItemPanel is not added
                    MessageBox.Show("Failed to add ItemPanel to flowLayoutPanel1!");
                }

                // Refresh the layout
                flowLayoutPanel1.Refresh();
            }
            catch (Exception ex)
            {
                // Handle any exceptions
                MessageBox.Show("Error adding ItemPanel: " + ex.Message);
            }
        }

        private void closeBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cartForm_Load(object sender, EventArgs e)
        {
            AddItemPanel();
        }
    }
}
