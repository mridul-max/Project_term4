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
            this.btnApply = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.listViewOrders = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.RDCash = new System.Windows.Forms.RadioButton();
            this.RDCredit = new System.Windows.Forms.RadioButton();
            this.RDPin = new System.Windows.Forms.RadioButton();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(470, 704);
            this.btnApply.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(158, 35);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Check out";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(164, 704);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(158, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // listViewOrders
            // 
            this.listViewOrders.HideSelection = false;
            this.listViewOrders.Location = new System.Drawing.Point(8, 50);
            this.listViewOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewOrders.Name = "listViewOrders";
            this.listViewOrders.Size = new System.Drawing.Size(768, 149);
            this.listViewOrders.TabIndex = 4;
            this.listViewOrders.UseCompatibleStateImageBehavior = false;
            this.listViewOrders.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Current orders:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(9, 508);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(81, 29);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = "Price:";
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.BackColor = System.Drawing.Color.Transparent;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(9, 556);
            this.lblVAT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(69, 29);
            this.lblVAT.TabIndex = 7;
            this.lblVAT.Text = "VAT:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(9, 600);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(148, 29);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "Total Price:";
            // 
            // RDCash
            // 
            this.RDCash.AutoSize = true;
            this.RDCash.BackColor = System.Drawing.Color.Transparent;
            this.RDCash.Location = new System.Drawing.Point(448, 480);
            this.RDCash.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDCash.Name = "RDCash";
            this.RDCash.Size = new System.Drawing.Size(49, 17);
            this.RDCash.TabIndex = 9;
            this.RDCash.TabStop = true;
            this.RDCash.Text = "Cash";
            this.RDCash.UseVisualStyleBackColor = false;
            // 
            // RDCredit
            // 
            this.RDCredit.AutoSize = true;
            this.RDCredit.BackColor = System.Drawing.Color.Transparent;
            this.RDCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RDCredit.Location = new System.Drawing.Point(448, 547);
            this.RDCredit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDCredit.Name = "RDCredit";
            this.RDCredit.Size = new System.Drawing.Size(77, 17);
            this.RDCredit.TabIndex = 10;
            this.RDCredit.TabStop = true;
            this.RDCredit.Text = "Credit Card";
            this.RDCredit.UseVisualStyleBackColor = false;
            // 
            // RDPin
            // 
            this.RDPin.AutoSize = true;
            this.RDPin.BackColor = System.Drawing.Color.Transparent;
            this.RDPin.Location = new System.Drawing.Point(448, 513);
            this.RDPin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RDPin.Name = "RDPin";
            this.RDPin.Size = new System.Drawing.Size(40, 17);
            this.RDPin.TabIndex = 11;
            this.RDPin.TabStop = true;
            this.RDPin.Text = "Pin";
            this.RDPin.UseVisualStyleBackColor = false;
            // 
            // txtTip
            // 
            this.txtTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTip.Location = new System.Drawing.Point(189, 417);
            this.txtTip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(144, 28);
            this.txtTip.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tip:(Optional)";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(8, 245);
            this.txtComment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(768, 149);
            this.txtComment.TabIndex = 14;
            this.txtComment.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Comments:(Optional)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(444, 419);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 29);
            this.label4.TabIndex = 16;
            this.label4.Text = "Payment Method:";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.RDPin);
            this.Controls.Add(this.RDCredit);
            this.Controls.Add(this.RDCash);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblVAT);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApply);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PaymentScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView listViewOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.RadioButton RDCash;
        private System.Windows.Forms.RadioButton RDCredit;
        private System.Windows.Forms.RadioButton RDPin;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}