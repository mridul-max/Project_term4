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
            this.kitchenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlKitchenBar = new System.Windows.Forms.Panel();
            this.listViewKitchenBar = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TableNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblKitchenBar = new System.Windows.Forms.Label();
            this.btnReady = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblSelectInstruction = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlKitchenBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblloggedinChef
            // 
            this.lblloggedinChef.BackColor = System.Drawing.Color.Transparent;
            this.lblloggedinChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloggedinChef.Location = new System.Drawing.Point(18, 41);
            this.lblloggedinChef.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloggedinChef.Name = "lblloggedinChef";
            this.lblloggedinChef.Size = new System.Drawing.Size(264, 29);
            this.lblloggedinChef.TabIndex = 0;
            this.lblloggedinChef.Text = "Logged in as:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.kitchenToolStripMenuItem,
            this.barToolStripMenuItem});
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
            // kitchenToolStripMenuItem
            // 
            this.kitchenToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenToolStripMenuItem.Name = "kitchenToolStripMenuItem";
            this.kitchenToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.kitchenToolStripMenuItem.Text = "Kitchen";
            this.kitchenToolStripMenuItem.Visible = false;
            this.kitchenToolStripMenuItem.Click += new System.EventHandler(this.kitchenToolStripMenuItem_Click);
            // 
            // barToolStripMenuItem
            // 
            this.barToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barToolStripMenuItem.Name = "barToolStripMenuItem";
            this.barToolStripMenuItem.Size = new System.Drawing.Size(47, 25);
            this.barToolStripMenuItem.Text = "Bar";
            this.barToolStripMenuItem.Visible = false;
            this.barToolStripMenuItem.Click += new System.EventHandler(this.barToolStripMenuItem_Click);
            // 
            // pnlKitchenBar
            // 
            this.pnlKitchenBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlKitchenBar.Controls.Add(this.listViewKitchenBar);
            this.pnlKitchenBar.Location = new System.Drawing.Point(31, 187);
            this.pnlKitchenBar.Name = "pnlKitchenBar";
            this.pnlKitchenBar.Size = new System.Drawing.Size(731, 1009);
            this.pnlKitchenBar.TabIndex = 8;
            // 
            // listViewKitchenBar
            // 
            this.listViewKitchenBar.CheckBoxes = true;
            this.listViewKitchenBar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.ItemAmount,
            this.OrderStatus,
            this.OrderTime,
            this.TableNumber});
            this.listViewKitchenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewKitchenBar.HideSelection = false;
            this.listViewKitchenBar.Location = new System.Drawing.Point(0, 0);
            this.listViewKitchenBar.Name = "listViewKitchenBar";
            this.listViewKitchenBar.Size = new System.Drawing.Size(731, 1006);
            this.listViewKitchenBar.TabIndex = 0;
            this.listViewKitchenBar.UseCompatibleStateImageBehavior = false;
            this.listViewKitchenBar.View = System.Windows.Forms.View.Details;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 128;
            // 
            // ItemAmount
            // 
            this.ItemAmount.Text = "Amount";
            this.ItemAmount.Width = 119;
            // 
            // OrderStatus
            // 
            this.OrderStatus.Text = "Status";
            this.OrderStatus.Width = 106;
            // 
            // OrderTime
            // 
            this.OrderTime.Text = "Order Time";
            this.OrderTime.Width = 89;
            // 
            // TableNumber
            // 
            this.TableNumber.Text = "Table";
            this.TableNumber.Width = 159;
            // 
            // lblKitchenBar
            // 
            this.lblKitchenBar.BackColor = System.Drawing.Color.Transparent;
            this.lblKitchenBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKitchenBar.ForeColor = System.Drawing.Color.Black;
            this.lblKitchenBar.Location = new System.Drawing.Point(299, 70);
            this.lblKitchenBar.Name = "lblKitchenBar";
            this.lblKitchenBar.Size = new System.Drawing.Size(205, 45);
            this.lblKitchenBar.TabIndex = 9;
            // 
            // btnReady
            // 
            this.btnReady.BackColor = System.Drawing.Color.LimeGreen;
            this.btnReady.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReady.Location = new System.Drawing.Point(31, 114);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(182, 57);
            this.btnReady.TabIndex = 10;
            this.btnReady.Text = "Mark As Ready";
            this.btnReady.UseVisualStyleBackColor = false;
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DimGray;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRefresh.Location = new System.Drawing.Point(596, 114);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(166, 57);
            this.btnRefresh.TabIndex = 11;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblSelectInstruction
            // 
            this.lblSelectInstruction.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectInstruction.Location = new System.Drawing.Point(28, 78);
            this.lblSelectInstruction.Name = "lblSelectInstruction";
            this.lblSelectInstruction.Size = new System.Drawing.Size(254, 23);
            this.lblSelectInstruction.TabIndex = 12;
            // 
            // KitchenBarScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.lblSelectInstruction);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.lblKitchenBar);
            this.Controls.Add(this.pnlKitchenBar);
            this.Controls.Add(this.lblloggedinChef);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblSelectInstruction;
        private System.Windows.Forms.ToolStripMenuItem kitchenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barToolStripMenuItem;
    }
}