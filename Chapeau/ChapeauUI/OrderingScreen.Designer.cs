namespace ChapeauUI
{
    partial class OrderingScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.flpCurrentOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTableNr = new System.Windows.Forms.Label();
            this.tabMenu = new TransparentTabControl();
            this.tabDrinks = new System.Windows.Forms.TabPage();
            this.flpDrinkItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tabDinner = new System.Windows.Forms.TabPage();
            this.flpDinnerItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tabLunch = new System.Windows.Forms.TabPage();
            this.flpLunchItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tabMenu.SuspendLayout();
            this.tabDrinks.SuspendLayout();
            this.tabDinner.SuspendLayout();
            this.tabLunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordering";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpCurrentOrderItems
            // 
            this.flpCurrentOrderItems.AutoSize = true;
            this.flpCurrentOrderItems.BackColor = System.Drawing.Color.Transparent;
            this.flpCurrentOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCurrentOrderItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCurrentOrderItems.Location = new System.Drawing.Point(395, 76);
            this.flpCurrentOrderItems.Name = "flpCurrentOrderItems";
            this.flpCurrentOrderItems.Size = new System.Drawing.Size(380, 117);
            this.flpCurrentOrderItems.TabIndex = 2;
            // 
            // lblTableNr
            // 
            this.lblTableNr.AutoSize = true;
            this.lblTableNr.BackColor = System.Drawing.Color.Transparent;
            this.lblTableNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNr.Location = new System.Drawing.Point(13, 9);
            this.lblTableNr.Name = "lblTableNr";
            this.lblTableNr.Size = new System.Drawing.Size(112, 31);
            this.lblTableNr.TabIndex = 4;
            this.lblTableNr.Text = "Table: 5";
            this.lblTableNr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabDrinks);
            this.tabMenu.Controls.Add(this.tabDinner);
            this.tabMenu.Controls.Add(this.tabLunch);
            this.tabMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabMenu.ItemSize = new System.Drawing.Size(125, 29);
            this.tabMenu.Location = new System.Drawing.Point(12, 43);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(379, 1186);
            this.tabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMenu.TabIndex = 3;
            // 
            // tabDrinks
            // 
            this.tabDrinks.BackColor = System.Drawing.Color.Transparent;
            this.tabDrinks.Controls.Add(this.flpDrinkItems);
            this.tabDrinks.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDrinks.Location = new System.Drawing.Point(4, 33);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrinks.Size = new System.Drawing.Size(371, 1149);
            this.tabDrinks.TabIndex = 0;
            this.tabDrinks.Text = "Drinks";
            this.tabDrinks.UseVisualStyleBackColor = true;
            // 
            // flpDrinkItems
            // 
            this.flpDrinkItems.AutoSize = true;
            this.flpDrinkItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDrinkItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDrinkItems.Location = new System.Drawing.Point(3, 3);
            this.flpDrinkItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpDrinkItems.Name = "flpDrinkItems";
            this.flpDrinkItems.Size = new System.Drawing.Size(362, 80);
            this.flpDrinkItems.TabIndex = 1;
            // 
            // tabDinner
            // 
            this.tabDinner.BackColor = System.Drawing.Color.Transparent;
            this.tabDinner.Controls.Add(this.flpDinnerItems);
            this.tabDinner.Location = new System.Drawing.Point(4, 33);
            this.tabDinner.Name = "tabDinner";
            this.tabDinner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinner.Size = new System.Drawing.Size(371, 1149);
            this.tabDinner.TabIndex = 1;
            this.tabDinner.Text = "Dinner";
            this.tabDinner.UseVisualStyleBackColor = true;
            // 
            // flpDinnerItems
            // 
            this.flpDinnerItems.AutoSize = true;
            this.flpDinnerItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDinnerItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDinnerItems.Location = new System.Drawing.Point(3, 3);
            this.flpDinnerItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpDinnerItems.Name = "flpDinnerItems";
            this.flpDinnerItems.Size = new System.Drawing.Size(357, 80);
            this.flpDinnerItems.TabIndex = 2;
            // 
            // tabLunch
            // 
            this.tabLunch.BackColor = System.Drawing.Color.Transparent;
            this.tabLunch.Controls.Add(this.flpLunchItems);
            this.tabLunch.Location = new System.Drawing.Point(4, 33);
            this.tabLunch.Name = "tabLunch";
            this.tabLunch.Padding = new System.Windows.Forms.Padding(3);
            this.tabLunch.Size = new System.Drawing.Size(371, 1149);
            this.tabLunch.TabIndex = 2;
            this.tabLunch.Text = "Lunch";
            this.tabLunch.UseVisualStyleBackColor = true;
            // 
            // flpLunchItems
            // 
            this.flpLunchItems.AutoSize = true;
            this.flpLunchItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpLunchItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpLunchItems.Location = new System.Drawing.Point(3, 3);
            this.flpLunchItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpLunchItems.Name = "flpLunchItems";
            this.flpLunchItems.Size = new System.Drawing.Size(357, 80);
            this.flpLunchItems.TabIndex = 2;
            // 
            // OrderingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.lblTableNr);
            this.Controls.Add(this.tabMenu);
            this.Controls.Add(this.flpCurrentOrderItems);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OrderingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderingScreen";
            this.Load += new System.EventHandler(this.OrderingScreen_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabDrinks.ResumeLayout(false);
            this.tabDrinks.PerformLayout();
            this.tabDinner.ResumeLayout(false);
            this.tabDinner.PerformLayout();
            this.tabLunch.ResumeLayout(false);
            this.tabLunch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpDrinkItems;
        private System.Windows.Forms.FlowLayoutPanel flpCurrentOrderItems;
        private TransparentTabControl tabMenu;
        private System.Windows.Forms.TabPage tabDrinks;
        private System.Windows.Forms.TabPage tabDinner;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.FlowLayoutPanel flpDinnerItems;
        private System.Windows.Forms.FlowLayoutPanel flpLunchItems;
        private System.Windows.Forms.Label lblTableNr;
    }
}