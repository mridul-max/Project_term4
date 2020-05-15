namespace ChapeauUI
{
    partial class PaymentScreen
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
            this.lblTbnumber = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.lblPriceVAT = new System.Windows.Forms.Label();
            this.lblNoVAT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTbnumber
            // 
            this.lblTbnumber.AutoSize = true;
            this.lblTbnumber.BackColor = System.Drawing.Color.Transparent;
            this.lblTbnumber.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTbnumber.Location = new System.Drawing.Point(41, 32);
            this.lblTbnumber.Name = "lblTbnumber";
            this.lblTbnumber.Size = new System.Drawing.Size(141, 22);
            this.lblTbnumber.TabIndex = 0;
            this.lblTbnumber.Text = "Table Number:";
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(108, 380);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(123, 43);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(446, 380);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 43);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployee.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.Location = new System.Drawing.Point(41, 85);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(151, 22);
            this.lblEmployee.TabIndex = 3;
            this.lblEmployee.Text = "Host Employee:";
            // 
            // lblPriceVAT
            // 
            this.lblPriceVAT.AutoSize = true;
            this.lblPriceVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblPriceVAT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceVAT.Location = new System.Drawing.Point(41, 209);
            this.lblPriceVAT.Name = "lblPriceVAT";
            this.lblPriceVAT.Size = new System.Drawing.Size(225, 22);
            this.lblPriceVAT.TabIndex = 4;
            this.lblPriceVAT.Text = "Total price (with VAT):";
            // 
            // lblNoVAT
            // 
            this.lblNoVAT.AutoSize = true;
            this.lblNoVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblNoVAT.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoVAT.Location = new System.Drawing.Point(41, 156);
            this.lblNoVAT.Name = "lblNoVAT";
            this.lblNoVAT.Size = new System.Drawing.Size(117, 22);
            this.lblNoVAT.TabIndex = 5;
            this.lblNoVAT.Text = "Total Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selected payment method";
            // 
            // cmbPayment
            // 
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Location = new System.Drawing.Point(325, 264);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(160, 24);
            this.cmbPayment.TabIndex = 7;
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(741, 435);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNoVAT);
            this.Controls.Add(this.lblPriceVAT);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.lblTbnumber);
            this.Name = "PaymentScreen";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTbnumber;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Label lblPriceVAT;
        private System.Windows.Forms.Label lblNoVAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPayment;
    }
}