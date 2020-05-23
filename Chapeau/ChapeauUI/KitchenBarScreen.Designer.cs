namespace ChapeauUI
{
    partial class KitchenBarScreen
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
            this.lblloggedinChef = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKitchen = new System.Windows.Forms.Panel();
            this.lblKitchenScreen = new System.Windows.Forms.Label();
            this.pnlBarScreen = new System.Windows.Forms.Panel();
            this.lblBarScreen = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlKitchen.SuspendLayout();
            this.pnlBarScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblloggedinChef
            // 
            this.lblloggedinChef.AutoSize = true;
            this.lblloggedinChef.BackColor = System.Drawing.Color.Transparent;
            this.lblloggedinChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedinChef.Location = new System.Drawing.Point(18, 41);
            this.lblloggedinChef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloggedinChef.Name = "lblloggedinChef";
            this.lblloggedinChef.Size = new System.Drawing.Size(117, 20);
            this.lblloggedinChef.TabIndex = 0;
            this.lblloggedinChef.Text = "Logged in as:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click_1);
            // 
            // pnlKitchen
            // 
            this.pnlKitchen.BackColor = System.Drawing.Color.Transparent;
            this.pnlKitchen.Controls.Add(this.lblKitchenScreen);
            this.pnlKitchen.Location = new System.Drawing.Point(64, 74);
            this.pnlKitchen.Name = "pnlKitchen";
            this.pnlKitchen.Size = new System.Drawing.Size(643, 346);
            this.pnlKitchen.TabIndex = 8;
            // 
            // lblKitchenScreen
            // 
            this.lblKitchenScreen.AutoSize = true;
            this.lblKitchenScreen.Location = new System.Drawing.Point(231, 11);
            this.lblKitchenScreen.Name = "lblKitchenScreen";
            this.lblKitchenScreen.Size = new System.Drawing.Size(80, 13);
            this.lblKitchenScreen.TabIndex = 0;
            this.lblKitchenScreen.Text = "Kitchen Screen";
            // 
            // pnlBarScreen
            // 
            this.pnlBarScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarScreen.Controls.Add(this.lblBarScreen);
            this.pnlBarScreen.Location = new System.Drawing.Point(61, 74);
            this.pnlBarScreen.Name = "pnlBarScreen";
            this.pnlBarScreen.Size = new System.Drawing.Size(643, 346);
            this.pnlBarScreen.TabIndex = 1;
            // 
            // lblBarScreen
            // 
            this.lblBarScreen.AutoSize = true;
            this.lblBarScreen.Location = new System.Drawing.Point(231, 11);
            this.lblBarScreen.Name = "lblBarScreen";
            this.lblBarScreen.Size = new System.Drawing.Size(60, 13);
            this.lblBarScreen.TabIndex = 0;
            this.lblBarScreen.Text = "Bar Screen";
            // 
            // KitchenBarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.pnlBarScreen);
            this.Controls.Add(this.pnlKitchen);
            this.Controls.Add(this.lblloggedinChef);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KitchenBarScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitchenBarScreen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KitchenBarScreen_FormClosing);
            this.Load += new System.EventHandler(this.KitchenBarScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlKitchen.ResumeLayout(false);
            this.pnlKitchen.PerformLayout();
            this.pnlBarScreen.ResumeLayout(false);
            this.pnlBarScreen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloggedinChef;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Panel pnlKitchen;
        private System.Windows.Forms.Panel pnlBarScreen;
        private System.Windows.Forms.Label lblBarScreen;
        private System.Windows.Forms.Label lblKitchenScreen;
    }
}