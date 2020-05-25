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
            this.ListViewKitchen = new System.Windows.Forms.ListView();
            this.FName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FOrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FOrderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FTableNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKitchenScreen = new System.Windows.Forms.Label();
            this.pnlBarScreen = new System.Windows.Forms.Panel();
            this.listViewBar = new System.Windows.Forms.ListView();
            this.DrinkName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinkAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinkOrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DrinkStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DTableNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.lblloggedinChef.Location = new System.Drawing.Point(24, 50);
            this.lblloggedinChef.Name = "lblloggedinChef";
            this.lblloggedinChef.Size = new System.Drawing.Size(143, 25);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1045, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(80, 29);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Visible = false;
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(224, 30);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click_1);
            // 
            // pnlKitchen
            // 
            this.pnlKitchen.BackColor = System.Drawing.Color.Transparent;
            this.pnlKitchen.Controls.Add(this.ListViewKitchen);
            this.pnlKitchen.Controls.Add(this.lblKitchenScreen);
            this.pnlKitchen.Location = new System.Drawing.Point(63, 100);
            this.pnlKitchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlKitchen.Name = "pnlKitchen";
            this.pnlKitchen.Size = new System.Drawing.Size(857, 426);
            this.pnlKitchen.TabIndex = 8;
            // 
            // ListViewKitchen
            // 
            this.ListViewKitchen.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ListViewKitchen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FName,
            this.FAmount,
            this.FOrderTime,
            this.FOrderStatus,
            this.FTableNumber});
            this.ListViewKitchen.HideSelection = false;
            this.ListViewKitchen.Location = new System.Drawing.Point(4, 37);
            this.ListViewKitchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListViewKitchen.Name = "ListViewKitchen";
            this.ListViewKitchen.Size = new System.Drawing.Size(852, 384);
            this.ListViewKitchen.TabIndex = 2;
            this.ListViewKitchen.UseCompatibleStateImageBehavior = false;
            this.ListViewKitchen.View = System.Windows.Forms.View.Details;
            // 
            // FName
            // 
            this.FName.Text = "Item Name";
            this.FName.Width = 116;
            // 
            // FAmount
            // 
            this.FAmount.Text = "Amount";
            this.FAmount.Width = 162;
            // 
            // FOrderTime
            // 
            this.FOrderTime.Text = "Order Time";
            this.FOrderTime.Width = 133;
            // 
            // FOrderStatus
            // 
            this.FOrderStatus.Text = "Status";
            this.FOrderStatus.Width = 78;
            // 
            // FTableNumber
            // 
            this.FTableNumber.Text = "Table Number";
            this.FTableNumber.Width = 112;
            // 
            // lblKitchenScreen
            // 
            this.lblKitchenScreen.AutoSize = true;
            this.lblKitchenScreen.Location = new System.Drawing.Point(308, 14);
            this.lblKitchenScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKitchenScreen.Name = "lblKitchenScreen";
            this.lblKitchenScreen.Size = new System.Drawing.Size(104, 17);
            this.lblKitchenScreen.TabIndex = 0;
            this.lblKitchenScreen.Text = "Kitchen Screen";
            // 
            // pnlBarScreen
            // 
            this.pnlBarScreen.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarScreen.Controls.Add(this.listViewBar);
            this.pnlBarScreen.Controls.Add(this.lblBarScreen);
            this.pnlBarScreen.Location = new System.Drawing.Point(71, 119);
            this.pnlBarScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlBarScreen.Name = "pnlBarScreen";
            this.pnlBarScreen.Size = new System.Drawing.Size(849, 422);
            this.pnlBarScreen.TabIndex = 1;
            // 
            // listViewBar
            // 
            this.listViewBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DrinkName,
            this.DrinkAmount,
            this.DrinkOrderTime,
            this.DrinkStatus,
            this.DTableNumber});
            this.listViewBar.HideSelection = false;
            this.listViewBar.Location = new System.Drawing.Point(0, 47);
            this.listViewBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listViewBar.Name = "listViewBar";
            this.listViewBar.Size = new System.Drawing.Size(852, 374);
            this.listViewBar.TabIndex = 1;
            this.listViewBar.UseCompatibleStateImageBehavior = false;
            this.listViewBar.View = System.Windows.Forms.View.Details;
            // 
            // DrinkName
            // 
            this.DrinkName.Text = "Item Name";
            // 
            // DrinkAmount
            // 
            this.DrinkAmount.Text = "Amount";
            // 
            // DrinkOrderTime
            // 
            this.DrinkOrderTime.Text = "Order Time";
            // 
            // DrinkStatus
            // 
            this.DrinkStatus.Text = "Status";
            // 
            // DTableNumber
            // 
            this.DTableNumber.Text = "Table Number";
            // 
            // lblBarScreen
            // 
            this.lblBarScreen.AutoSize = true;
            this.lblBarScreen.Location = new System.Drawing.Point(308, 14);
            this.lblBarScreen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarScreen.Name = "lblBarScreen";
            this.lblBarScreen.Size = new System.Drawing.Size(79, 17);
            this.lblBarScreen.TabIndex = 0;
            this.lblBarScreen.Text = "Bar Screen";
            // 
            // KitchenBarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 922);
            this.Controls.Add(this.pnlKitchen);
            this.Controls.Add(this.pnlBarScreen);
            this.Controls.Add(this.lblloggedinChef);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListView listViewBar;
        private System.Windows.Forms.ColumnHeader DrinkName;
        private System.Windows.Forms.ColumnHeader DrinkAmount;
        private System.Windows.Forms.ColumnHeader DrinkOrderTime;
        private System.Windows.Forms.ColumnHeader DrinkStatus;
        private System.Windows.Forms.ListView ListViewKitchen;
        private System.Windows.Forms.ColumnHeader FName;
        private System.Windows.Forms.ColumnHeader FAmount;
        private System.Windows.Forms.ColumnHeader FOrderTime;
        private System.Windows.Forms.ColumnHeader FOrderStatus;
        private System.Windows.Forms.ColumnHeader FTableNumber;
        private System.Windows.Forms.ColumnHeader DTableNumber;
    }
}