
namespace Online_Shop
{
    partial class cartForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.closeBut = new Online_Shop.Resources.RoundControl();
            this.botPanel = new System.Windows.Forms.Panel();
            this.buyBut = new Online_Shop.Resources.RoundControl();
            this.topPanel.SuspendLayout();
            this.botPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.topPanel.Controls.Add(this.flowLayoutPanel1);
            this.topPanel.Controls.Add(this.closeBut);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(966, 43);
            this.topPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(966, 469);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // closeBut
            // 
            this.closeBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.closeBut.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.closeBut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.closeBut.BorderSize = 0;
            this.closeBut.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.closeBut.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBut.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBut.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.closeBut.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBut.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBut.ButtonPressedForeColor = System.Drawing.Color.White;
            this.closeBut.ButtonRoundRadius = 15;
            this.closeBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBut.FlatAppearance.BorderSize = 0;
            this.closeBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBut.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeBut.ForeColor = System.Drawing.Color.White;
            this.closeBut.Location = new System.Drawing.Point(921, 1);
            this.closeBut.Name = "closeBut";
            this.closeBut.Size = new System.Drawing.Size(45, 42);
            this.closeBut.TabIndex = 7;
            this.closeBut.Text = "X";
            this.closeBut.UseVisualStyleBackColor = false;
            this.closeBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // botPanel
            // 
            this.botPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.botPanel.Controls.Add(this.buyBut);
            this.botPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.botPanel.Location = new System.Drawing.Point(0, 524);
            this.botPanel.Name = "botPanel";
            this.botPanel.Size = new System.Drawing.Size(966, 78);
            this.botPanel.TabIndex = 2;
            // 
            // buyBut
            // 
            this.buyBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.buyBut.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.buyBut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.buyBut.BorderSize = 0;
            this.buyBut.ButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(162)))), ((int)(((byte)(227)))));
            this.buyBut.ButtonHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(209)))), ((int)(((byte)(222)))));
            this.buyBut.ButtonHighlightColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(209)))), ((int)(((byte)(222)))));
            this.buyBut.ButtonHighlightForeColor = System.Drawing.Color.White;
            this.buyBut.ButtonPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(209)))), ((int)(((byte)(222)))));
            this.buyBut.ButtonPressedColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(209)))), ((int)(((byte)(222)))));
            this.buyBut.ButtonPressedForeColor = System.Drawing.Color.White;
            this.buyBut.ButtonRoundRadius = 15;
            this.buyBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buyBut.FlatAppearance.BorderSize = 0;
            this.buyBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyBut.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buyBut.ForeColor = System.Drawing.Color.White;
            this.buyBut.Location = new System.Drawing.Point(803, 16);
            this.buyBut.Name = "buyBut";
            this.buyBut.Size = new System.Drawing.Size(160, 44);
            this.buyBut.TabIndex = 8;
            this.buyBut.Text = "Поръчай";
            this.buyBut.UseVisualStyleBackColor = false;
            // 
            // cartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(246)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(966, 602);
            this.Controls.Add(this.botPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cartForm";
            this.Text = "cartForm";
            this.Load += new System.EventHandler(this.cartForm_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.botPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel topPanel;
        private Resources.RoundControl closeBut;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel botPanel;
        private Resources.RoundControl buyBut;
    }
}