namespace ChapeauUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnEditItems = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.lblLog = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 37);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(105, 33);
            this.logOffToolStripMenuItem.Text = "Log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.Transparent;
            this.btnEditEmp.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnEditEmp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditEmp.Location = new System.Drawing.Point(250, 294);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(300, 120);
            this.btnEditEmp.TabIndex = 8;
            this.btnEditEmp.Text = "Edit Employee";
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnEditItems
            // 
            this.btnEditItems.BackColor = System.Drawing.Color.Transparent;
            this.btnEditItems.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnEditItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditItems.Location = new System.Drawing.Point(250, 507);
            this.btnEditItems.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditItems.Name = "btnEditItems";
            this.btnEditItems.Size = new System.Drawing.Size(300, 120);
            this.btnEditItems.TabIndex = 10;
            this.btnEditItems.Text = "Edit Menu Items";
            this.btnEditItems.UseVisualStyleBackColor = false;
            this.btnEditItems.Click += new System.EventHandler(this.btnEditItems_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.Transparent;
            this.btnKitchen.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitchen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKitchen.Location = new System.Drawing.Point(250, 725);
            this.btnKitchen.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(300, 120);
            this.btnKitchen.TabIndex = 11;
            this.btnKitchen.Text = "Kitchen bar screen";
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click);
            // 
            // btnTable
            // 
            this.btnTable.BackColor = System.Drawing.Color.Transparent;
            this.btnTable.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.Location = new System.Drawing.Point(250, 934);
            this.btnTable.Margin = new System.Windows.Forms.Padding(2);
            this.btnTable.Name = "btnTable";
            this.btnTable.Size = new System.Drawing.Size(300, 120);
            this.btnTable.TabIndex = 12;
            this.btnTable.Text = "Table view";
            this.btnTable.UseVisualStyleBackColor = false;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.Transparent;
            this.lblLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.Location = new System.Drawing.Point(11, 59);
            this.lblLog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(155, 26);
            this.lblLog.TabIndex = 13;
            this.lblLog.Text = "Logged in as:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 190);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 37);
            this.label1.TabIndex = 14;
            this.label1.Text = "Management";
            // 
            // ManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnTable);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.btnEditItems);
            this.Controls.Add(this.btnEditEmp);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ManagerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerScreen_FormClosing);
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnEditItems;
        private System.Windows.Forms.Button btnKitchen;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.Label label1;
    }
}