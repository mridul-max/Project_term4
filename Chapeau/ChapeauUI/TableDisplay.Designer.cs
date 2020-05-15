namespace ChapeauUI
{
    partial class TableDisplay
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOccupy = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnreserve = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnChout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblOccupy);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblTableNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(484, 496);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 409);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(465, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 354);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Reservation Status:";
            // 
            // lblOccupy
            // 
            this.lblOccupy.AutoSize = true;
            this.lblOccupy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupy.Location = new System.Drawing.Point(7, 222);
            this.lblOccupy.Name = "lblOccupy";
            this.lblOccupy.Size = new System.Drawing.Size(175, 32);
            this.lblOccupy.TabIndex = 5;
            this.lblOccupy.Text = "Occupancy:";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(7, 127);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(143, 32);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.Location = new System.Drawing.Point(7, 46);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(215, 32);
            this.lblTableNumber.TabIndex = 1;
            this.lblTableNumber.Text = "Table Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(501, 38);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(468, 743);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(310, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "There will be orders here that belongs to tables.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 0;
            // 
            // Btnreserve
            // 
            this.Btnreserve.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.Btnreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnreserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnreserve.Location = new System.Drawing.Point(12, 540);
            this.Btnreserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnreserve.Name = "Btnreserve";
            this.Btnreserve.Size = new System.Drawing.Size(207, 59);
            this.Btnreserve.TabIndex = 2;
            this.Btnreserve.Text = "Add reservation";
            this.Btnreserve.UseVisualStyleBackColor = true;
            this.Btnreserve.Click += new System.EventHandler(this.Btnreserve_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(240, 540);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(189, 50);
            this.BtnOrder.TabIndex = 3;
            this.BtnOrder.Text = "Add Order";
            this.BtnOrder.UseVisualStyleBackColor = true;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnChout
            // 
            this.BtnChout.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BtnChout.Enabled = false;
            this.BtnChout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChout.Location = new System.Drawing.Point(12, 618);
            this.BtnChout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChout.Name = "BtnChout";
            this.BtnChout.Size = new System.Drawing.Size(189, 50);
            this.BtnChout.TabIndex = 4;
            this.BtnChout.Text = "Check out";
            this.BtnChout.UseVisualStyleBackColor = true;
            this.BtnChout.Click += new System.EventHandler(this.BtnChout_Click);
            // 
            // TableDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 1055);
            this.Controls.Add(this.BtnChout);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.Btnreserve);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TableDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableDisplay";
            this.Load += new System.EventHandler(this.TableDisplay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblOccupy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Btnreserve;        
        private System.Windows.Forms.Button BtnOrder;       
        private System.Windows.Forms.Button BtnChout;
    }
}