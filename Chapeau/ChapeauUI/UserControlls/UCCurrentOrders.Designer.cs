namespace ChapeauUI.UserControlls
{
    partial class UCCurrentOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblItemName = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pcTimer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnServed = new System.Windows.Forms.Button();
            this.btnRemake = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcTimer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 17);
            this.panel1.TabIndex = 0;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.Location = new System.Drawing.Point(16, 32);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(104, 36);
            this.lblItemName.TabIndex = 1;
            this.lblItemName.Text = "Order:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(164, 80);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(126, 36);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "Amount:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(731, 80);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(190, 36);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Order Status:";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(843, 31);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(49, 36);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "00";
            // 
            // pcTimer
            // 
            this.pcTimer.BackColor = System.Drawing.Color.Tomato;
            this.pcTimer.BackgroundImage = global::ChapeauUI.Properties.Resources.WarningTimer;
            this.pcTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcTimer.Location = new System.Drawing.Point(917, 130);
            this.pcTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pcTimer.Name = "pcTimer";
            this.pcTimer.Size = new System.Drawing.Size(80, 74);
            this.pcTimer.TabIndex = 4;
            this.pcTimer.TabStop = false;
            this.pcTimer.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount:";
            // 
            // btnServed
            // 
            this.btnServed.BackColor = System.Drawing.Color.LimeGreen;
            this.btnServed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnServed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServed.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnServed.Location = new System.Drawing.Point(155, 143);
            this.btnServed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServed.Name = "btnServed";
            this.btnServed.Size = new System.Drawing.Size(275, 62);
            this.btnServed.TabIndex = 7;
            this.btnServed.Text = "Mark as served";
            this.btnServed.UseVisualStyleBackColor = false;
            this.btnServed.Visible = false;
            this.btnServed.Click += new System.EventHandler(this.btnServed_Click);
            // 
            // btnRemake
            // 
            this.btnRemake.BackColor = System.Drawing.Color.Tomato;
            this.btnRemake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemake.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemake.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRemake.Location = new System.Drawing.Point(563, 143);
            this.btnRemake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemake.Name = "btnRemake";
            this.btnRemake.Size = new System.Drawing.Size(275, 62);
            this.btnRemake.TabIndex = 8;
            this.btnRemake.Text = "Remake Order";
            this.btnRemake.UseVisualStyleBackColor = false;
            this.btnRemake.Visible = false;
            this.btnRemake.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(731, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 36);
            this.label3.TabIndex = 9;
            this.label3.Text = "Time:";
            // 
            // UCCurrentOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemake);
            this.Controls.Add(this.btnServed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcTimer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCCurrentOrders";
            this.Size = new System.Drawing.Size(1000, 207);
            this.Load += new System.EventHandler(this.UCCurrentOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox pcTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnServed;
        private System.Windows.Forms.Button btnRemake;
        private System.Windows.Forms.Label label3;
    }
}
