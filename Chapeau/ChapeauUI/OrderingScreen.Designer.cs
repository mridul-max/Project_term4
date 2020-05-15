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
            this.flpDrinkItems = new System.Windows.Forms.FlowLayoutPanel();
            this.flpCurrentOrderItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tabAllItems = new System.Windows.Forms.TabControl();
            this.tabDrinks = new System.Windows.Forms.TabPage();
            this.tabDinner = new System.Windows.Forms.TabPage();
            this.tabLunch = new System.Windows.Forms.TabPage();
            this.flpDinnerItems = new System.Windows.Forms.FlowLayoutPanel();
            this.flpLunchItems = new System.Windows.Forms.FlowLayoutPanel();
            this.tabAllItems.SuspendLayout();
            this.tabDrinks.SuspendLayout();
            this.tabDinner.SuspendLayout();
            this.tabLunch.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordering";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpDrinkItems
            // 
            this.flpDrinkItems.AutoSize = true;
            this.flpDrinkItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpDrinkItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDrinkItems.Location = new System.Drawing.Point(3, 3);
            this.flpDrinkItems.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.flpDrinkItems.Name = "flpDrinkItems";
            this.flpDrinkItems.Size = new System.Drawing.Size(357, 80);
            this.flpDrinkItems.TabIndex = 1;
            // 
            // flpCurrentOrderItems
            // 
            this.flpCurrentOrderItems.AutoSize = true;
            this.flpCurrentOrderItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpCurrentOrderItems.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpCurrentOrderItems.Location = new System.Drawing.Point(395, 113);
            this.flpCurrentOrderItems.Name = "flpCurrentOrderItems";
            this.flpCurrentOrderItems.Size = new System.Drawing.Size(380, 80);
            this.flpCurrentOrderItems.TabIndex = 2;
            // 
            // tabAllItems
            // 
            this.tabAllItems.Controls.Add(this.tabDrinks);
            this.tabAllItems.Controls.Add(this.tabDinner);
            this.tabAllItems.Controls.Add(this.tabLunch);
            this.tabAllItems.Location = new System.Drawing.Point(12, 88);
            this.tabAllItems.Name = "tabAllItems";
            this.tabAllItems.SelectedIndex = 0;
            this.tabAllItems.Size = new System.Drawing.Size(377, 816);
            this.tabAllItems.TabIndex = 3;
            // 
            // tabDrinks
            // 
            this.tabDrinks.BackColor = System.Drawing.Color.Transparent;
            this.tabDrinks.Controls.Add(this.flpDrinkItems);
            this.tabDrinks.Location = new System.Drawing.Point(4, 22);
            this.tabDrinks.Name = "tabDrinks";
            this.tabDrinks.Padding = new System.Windows.Forms.Padding(3);
            this.tabDrinks.Size = new System.Drawing.Size(369, 790);
            this.tabDrinks.TabIndex = 0;
            this.tabDrinks.Text = "Drinks";
            // 
            // tabDinner
            // 
            this.tabDinner.BackColor = System.Drawing.Color.Transparent;
            this.tabDinner.Controls.Add(this.flpDinnerItems);
            this.tabDinner.Location = new System.Drawing.Point(4, 22);
            this.tabDinner.Name = "tabDinner";
            this.tabDinner.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinner.Size = new System.Drawing.Size(369, 790);
            this.tabDinner.TabIndex = 1;
            this.tabDinner.Text = "Dinner";
            // 
            // tabLunch
            // 
            this.tabLunch.BackColor = System.Drawing.Color.Transparent;
            this.tabLunch.Controls.Add(this.flpLunchItems);
            this.tabLunch.Location = new System.Drawing.Point(4, 22);
            this.tabLunch.Name = "tabLunch";
            this.tabLunch.Padding = new System.Windows.Forms.Padding(3);
            this.tabLunch.Size = new System.Drawing.Size(369, 790);
            this.tabLunch.TabIndex = 2;
            this.tabLunch.Text = "Lunch";
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
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.tabAllItems);
            this.Controls.Add(this.flpCurrentOrderItems);
            this.Controls.Add(this.label1);
            this.Name = "OrderingScreen";
            this.Text = "OrderingScreen";
            this.tabAllItems.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabAllItems;
        private System.Windows.Forms.TabPage tabDrinks;
        private System.Windows.Forms.TabPage tabDinner;
        private System.Windows.Forms.TabPage tabLunch;
        private System.Windows.Forms.FlowLayoutPanel flpDinnerItems;
        private System.Windows.Forms.FlowLayoutPanel flpLunchItems;
    }
}