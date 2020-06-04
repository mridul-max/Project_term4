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
            this.pnlKitchenBar = new System.Windows.Forms.Panel();
            this.lblKitchenBar = new System.Windows.Forms.Label();
            this.listViewKitchenBar = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.pnlKitchenBar.SuspendLayout();
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
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.managementToolStripMenuItem.Visible = false;
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(182, 24);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click_1);
            // 
            // pnlKitchenBar
            // 
            this.pnlKitchenBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlKitchenBar.Controls.Add(this.listViewKitchenBar);
            this.pnlKitchenBar.Location = new System.Drawing.Point(22, 115);
            this.pnlKitchenBar.Name = "pnlKitchenBar";
            this.pnlKitchenBar.Size = new System.Drawing.Size(731, 365);
            this.pnlKitchenBar.TabIndex = 8;
            this.pnlKitchenBar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKitchenBar_Paint);
            // 
            // lblKitchenBar
            // 
            this.lblKitchenBar.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenBar.ForeColor = System.Drawing.Color.Black;
            this.lblKitchenBar.Location = new System.Drawing.Point(299, 70);
            this.lblKitchenBar.Name = "lblKitchenBar";
            this.lblKitchenBar.Size = new System.Drawing.Size(152, 31);
            this.lblKitchenBar.TabIndex = 9;
            // 
            // listViewKitchenBar
            // 
            this.listViewKitchenBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemAmount,
            this.OrderStatus,
            this.OrderTime,
            this.TableNumber});
            this.listViewKitchenBar.HideSelection = false;
            this.listViewKitchenBar.Location = new System.Drawing.Point(0, 3);
            this.listViewKitchenBar.Name = "listViewKitchenBar";
            this.listViewKitchenBar.Size = new System.Drawing.Size(731, 359);
            this.listViewKitchenBar.TabIndex = 0;
            this.listViewKitchenBar.UseCompatibleStateImageBehavior = false;
            this.listViewKitchenBar.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Item Name";
            this.ItemName.Width = 82;
            // 
            // ItemAmount
            // 
            this.ItemAmount.Text = "Amount";
            this.ItemAmount.Width = 83;
            // 
            // OrderStatus
            // 
            this.OrderStatus.Text = "Status";
            this.OrderStatus.Width = 70;
            // 
            // OrderTime
            // 
            this.OrderTime.Text = "Order Time";
            this.OrderTime.Width = 80;
            // 
            // TableNumber
            // 
            this.TableNumber.Text = "Table Number";
            this.TableNumber.Width = 116;
            // 
            // KitchenBarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 609);
            this.Controls.Add(this.lblKitchenBar);
            this.Controls.Add(this.pnlKitchenBar);
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
            this.pnlKitchenBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblloggedinChef;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Panel pnlKitchenBar;
        private System.Windows.Forms.Label lblKitchenBar;
        private System.Windows.Forms.ListView listViewKitchenBar;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader ItemAmount;
        private System.Windows.Forms.ColumnHeader OrderStatus;
        private System.Windows.Forms.ColumnHeader OrderTime;
        private System.Windows.Forms.ColumnHeader TableNumber;
    }
}