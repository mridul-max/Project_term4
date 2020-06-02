namespace ChapeauUI
{
    partial class ItemForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlEditMenu = new System.Windows.Forms.Panel();
            this.cmbEdit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnApplyStock = new System.Windows.Forms.Button();
            this.txtNewStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlEditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMenuItemToolStripMenuItem,
            this.editMenuItemToolStripMenuItem,
            this.returnToManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addMenuItemToolStripMenuItem
            // 
            this.addMenuItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMenuItemToolStripMenuItem.Name = "addMenuItemToolStripMenuItem";
            this.addMenuItemToolStripMenuItem.Size = new System.Drawing.Size(173, 32);
            this.addMenuItemToolStripMenuItem.Text = "Add Menu item";
            this.addMenuItemToolStripMenuItem.Click += new System.EventHandler(this.addMenuItemToolStripMenuItem_Click);
            // 
            // editMenuItemToolStripMenuItem
            // 
            this.editMenuItemToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editMenuItemToolStripMenuItem.Name = "editMenuItemToolStripMenuItem";
            this.editMenuItemToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.editMenuItemToolStripMenuItem.Text = "Edit Menu item";
            this.editMenuItemToolStripMenuItem.Click += new System.EventHandler(this.editMenuItemToolStripMenuItem_Click);
            // 
            // returnToManagementToolStripMenuItem
            // 
            this.returnToManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToManagementToolStripMenuItem.Name = "returnToManagementToolStripMenuItem";
            this.returnToManagementToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.returnToManagementToolStripMenuItem.Text = "Return to management";
            this.returnToManagementToolStripMenuItem.Click += new System.EventHandler(this.returnToManagementToolStripMenuItem_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Controls.Add(this.button1);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.txtStock);
            this.pnlAdd.Controls.Add(this.txtPrice);
            this.pnlAdd.Controls.Add(this.cmbCategory);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Location = new System.Drawing.Point(0, 156);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(1087, 846);
            this.pnlAdd.TabIndex = 1;
            this.pnlAdd.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(447, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 64);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(195, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Item Category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Item Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(194, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Item Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Name:";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(391, 198);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(329, 30);
            this.txtStock.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(391, 137);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(329, 30);
            this.txtPrice.TabIndex = 2;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(391, 259);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(329, 33);
            this.cmbCategory.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(391, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(329, 30);
            this.txtName.TabIndex = 0;
            // 
            // pnlEditMenu
            // 
            this.pnlEditMenu.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditMenu.Controls.Add(this.label6);
            this.pnlEditMenu.Controls.Add(this.txtNewStock);
            this.pnlEditMenu.Controls.Add(this.btnApplyStock);
            this.pnlEditMenu.Controls.Add(this.label5);
            this.pnlEditMenu.Controls.Add(this.cmbEdit);
            this.pnlEditMenu.Location = new System.Drawing.Point(3, 146);
            this.pnlEditMenu.Name = "pnlEditMenu";
            this.pnlEditMenu.Size = new System.Drawing.Size(1084, 800);
            this.pnlEditMenu.TabIndex = 2;
            this.pnlEditMenu.Visible = false;
            // 
            // cmbEdit
            // 
            this.cmbEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEdit.FormattingEnabled = true;
            this.cmbEdit.Location = new System.Drawing.Point(429, 98);
            this.cmbEdit.Name = "cmbEdit";
            this.cmbEdit.Size = new System.Drawing.Size(523, 33);
            this.cmbEdit.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Choose an item to adjust the stock:";
            // 
            // btnApplyStock
            // 
            this.btnApplyStock.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnApplyStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplyStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyStock.Location = new System.Drawing.Point(409, 269);
            this.btnApplyStock.Name = "btnApplyStock";
            this.btnApplyStock.Size = new System.Drawing.Size(229, 61);
            this.btnApplyStock.TabIndex = 5;
            this.btnApplyStock.Text = "Apply changes";
            this.btnApplyStock.UseVisualStyleBackColor = true;
            this.btnApplyStock.Click += new System.EventHandler(this.btnApplyStock_Click);
            // 
            // txtNewStock
            // 
            this.txtNewStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewStock.Location = new System.Drawing.Point(429, 183);
            this.txtNewStock.Name = "txtNewStock";
            this.txtNewStock.Size = new System.Drawing.Size(215, 30);
            this.txtNewStock.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(267, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "New Stock:";
            // 
            // ItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 1055);
            this.Controls.Add(this.pnlEditMenu);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ItemForm";
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlEditMenu.ResumeLayout(false);
            this.pnlEditMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addMenuItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItemToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem returnToManagementToolStripMenuItem;
        private System.Windows.Forms.Panel pnlEditMenu;
        private System.Windows.Forms.ComboBox cmbEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNewStock;
        private System.Windows.Forms.Button btnApplyStock;
        private System.Windows.Forms.Label label5;
    }
}