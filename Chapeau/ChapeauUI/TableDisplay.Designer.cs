using ChapeauModel;

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
            this.lblOccupy = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.Btnreserve = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnChout = new System.Windows.Forms.Button();
            this.pnlCurrentOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOccupy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblOccupy);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblTableNumber);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(484, 372);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
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
            // Btnreserve
            // 
            this.Btnreserve.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.Btnreserve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnreserve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnreserve.Location = new System.Drawing.Point(3, 724);
            this.Btnreserve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btnreserve.Name = "Btnreserve";
            this.Btnreserve.Size = new System.Drawing.Size(207, 59);
            this.Btnreserve.TabIndex = 2;
            this.Btnreserve.Text = "Add reservation";
            this.Btnreserve.UseVisualStyleBackColor = true;
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(227, 722);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(207, 62);
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
            this.BtnChout.Location = new System.Drawing.Point(3, 806);
            this.BtnChout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnChout.Name = "BtnChout";
            this.BtnChout.Size = new System.Drawing.Size(207, 62);
            this.BtnChout.TabIndex = 4;
            this.BtnChout.Text = "Check out";
            this.BtnChout.UseVisualStyleBackColor = true;
            this.BtnChout.Click += new System.EventHandler(this.BtnChout_Click);
            // 
            // pnlCurrentOrders
            // 
            this.pnlCurrentOrders.AutoScroll = true;
            this.pnlCurrentOrders.BackColor = System.Drawing.Color.Transparent;
            this.pnlCurrentOrders.Location = new System.Drawing.Point(509, 84);
            this.pnlCurrentOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCurrentOrders.Name = "pnlCurrentOrders";
            this.pnlCurrentOrders.Size = new System.Drawing.Size(524, 1430);
            this.pnlCurrentOrders.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Unserved orders of this table";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(3, 7);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(207, 62);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnOccupy
            // 
            this.btnOccupy.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnOccupy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupy.Location = new System.Drawing.Point(227, 806);
            this.btnOccupy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOccupy.Name = "btnOccupy";
            this.btnOccupy.Size = new System.Drawing.Size(207, 62);
            this.btnOccupy.TabIndex = 8;
            this.btnOccupy.Text = "Mark as occupied";
            this.btnOccupy.UseVisualStyleBackColor = true;
            this.btnOccupy.Click += new System.EventHandler(this.btnOccupy_Click);
            // 
            // TableDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1045, 1055);
            this.Controls.Add(this.btnOccupy);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCurrentOrders);
            this.Controls.Add(this.BtnChout);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.Btnreserve);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "TableDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TableDisplay";
            this.Load += new System.EventHandler(this.TableDisplay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblTableNumber;
        private System.Windows.Forms.Label lblOccupy;
        private System.Windows.Forms.Button Btnreserve;        
        private System.Windows.Forms.Button BtnOrder;       
        private System.Windows.Forms.Button BtnChout;
        private System.Windows.Forms.FlowLayoutPanel pnlCurrentOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOccupy;
    }
}