
namespace Online_Shop.Resources
{
    partial class ItemPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.itemPic = new System.Windows.Forms.PictureBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).BeginInit();
            this.SuspendLayout();
            // 
            // itemPic
            // 
            this.itemPic.Location = new System.Drawing.Point(3, 3);
            this.itemPic.Name = "itemPic";
            this.itemPic.Size = new System.Drawing.Size(153, 94);
            this.itemPic.TabIndex = 0;
            this.itemPic.TabStop = false;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.nameLbl.Location = new System.Drawing.Point(162, 36);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(75, 19);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "item name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(832, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 94);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(864, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цена:";
            // 
            // priceLbl
            // 
            this.priceLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLbl.Location = new System.Drawing.Point(835, 32);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(107, 33);
            this.priceLbl.TabIndex = 4;
            this.priceLbl.Text = "price";
            this.priceLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ItemPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.itemPic);
            this.Name = "ItemPanel";
            this.Size = new System.Drawing.Size(942, 100);
            this.Load += new System.EventHandler(this.ItemPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox itemPic;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label priceLbl;
    }
}
