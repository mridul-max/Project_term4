namespace ChapeauUI
{
    partial class OrderingRow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(4, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Menu item name";
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(196, 0);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(22, 21);
            this.btnMinus.TabIndex = 1;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(248, 0);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(22, 21);
            this.btnPlus.TabIndex = 2;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(227, 4);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(13, 13);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "0";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OrderingRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.lblName);
            this.Name = "OrderingRow";
            this.Size = new System.Drawing.Size(443, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Label lblAmount;
    }
}
