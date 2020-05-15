﻿namespace ChapeauUI
{
    partial class ManagerScreen
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
            this.btnLogoff = new System.Windows.Forms.Button();
            this.lblLogged = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitchenbarScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogoff
            // 
            this.btnLogoff.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogoff.Location = new System.Drawing.Point(409, 36);
            this.btnLogoff.Name = "btnLogoff";
            this.btnLogoff.Size = new System.Drawing.Size(120, 35);
            this.btnLogoff.TabIndex = 0;
            this.btnLogoff.Text = "Log off";
            this.btnLogoff.UseVisualStyleBackColor = true;
            this.btnLogoff.Click += new System.EventHandler(this.btnLogoff_Click);
            // 
            // lblLogged
            // 
            this.lblLogged.AutoSize = true;
            this.lblLogged.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogged.Location = new System.Drawing.Point(12, 42);
            this.lblLogged.Name = "lblLogged";
            this.lblLogged.Size = new System.Drawing.Size(130, 22);
            this.lblLogged.TabIndex = 2;
            this.lblLogged.Text = "Logged in as:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kitchenbarScreenToolStripMenuItem,
            this.tableViewToolStripMenuItem,
            this.editAccountsToolStripMenuItem,
            this.editStockToolStripMenuItem});
            this.managementToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.managementToolStripMenuItem.Text = "Management";
            // 
            // kitchenbarScreenToolStripMenuItem
            // 
            this.kitchenbarScreenToolStripMenuItem.Name = "kitchenbarScreenToolStripMenuItem";
            this.kitchenbarScreenToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.kitchenbarScreenToolStripMenuItem.Text = "Kitchen/bar screen";
            // 
            // tableViewToolStripMenuItem
            // 
            this.tableViewToolStripMenuItem.Name = "tableViewToolStripMenuItem";
            this.tableViewToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.tableViewToolStripMenuItem.Text = "Table view";
            // 
            // editAccountsToolStripMenuItem
            // 
            this.editAccountsToolStripMenuItem.Name = "editAccountsToolStripMenuItem";
            this.editAccountsToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.editAccountsToolStripMenuItem.Text = "Edit accounts";
            // 
            // editStockToolStripMenuItem
            // 
            this.editStockToolStripMenuItem.Name = "editStockToolStripMenuItem";
            this.editStockToolStripMenuItem.Size = new System.Drawing.Size(262, 26);
            this.editStockToolStripMenuItem.Text = "Edit stock";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(91, 26);
            this.logOffToolStripMenuItem.Text = "Log off";
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 903);
            this.Controls.Add(this.lblLogged);
            this.Controls.Add(this.btnLogoff);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManagerScreen";
            this.Text = "Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerScreen_FormClosing);
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogoff;
        private System.Windows.Forms.Label lblLogged;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitchenbarScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
    }
}