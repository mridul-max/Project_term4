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
            this.btnOccupy = new System.Windows.Forms.Button();
            this.lblOccupy = new System.Windows.Forms.Label();
            this.BtnChout = new System.Windows.Forms.Button();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.pnlCurrentOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnOccupy);
            this.groupBox1.Controls.Add(this.lblOccupy);
            this.groupBox1.Controls.Add(this.BtnChout);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblTableNumber);
            this.groupBox1.Controls.Add(this.BtnOrder);
            this.groupBox1.Location = new System.Drawing.Point(9, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(732, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnOccupy
            // 
            this.btnOccupy.BackColor = System.Drawing.Color.Transparent;
            this.btnOccupy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOccupy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOccupy.Location = new System.Drawing.Point(438, 80);
            this.btnOccupy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOccupy.Name = "btnOccupy";
            this.btnOccupy.Size = new System.Drawing.Size(237, 56);
            this.btnOccupy.TabIndex = 8;
            this.btnOccupy.Text = "Mark as occupied";
            this.btnOccupy.UseVisualStyleBackColor = false;
            this.btnOccupy.Click += new System.EventHandler(this.btnOccupy_Click);
            // 
            // lblOccupy
            // 
            this.lblOccupy.AutoSize = true;
            this.lblOccupy.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupy.Location = new System.Drawing.Point(5, 91);
            this.lblOccupy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOccupy.Name = "lblOccupy";
            this.lblOccupy.Size = new System.Drawing.Size(169, 31);
            this.lblOccupy.TabIndex = 5;
            this.lblOccupy.Text = "Occupancy:";
            // 
            // BtnChout
            // 
            this.BtnChout.BackColor = System.Drawing.Color.Tomato;
            this.BtnChout.Enabled = false;
            this.BtnChout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnChout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChout.Location = new System.Drawing.Point(438, 145);
            this.BtnChout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnChout.Name = "BtnChout";
            this.BtnChout.Size = new System.Drawing.Size(237, 56);
            this.BtnChout.TabIndex = 4;
            this.BtnChout.Text = "Check out";
            this.BtnChout.UseVisualStyleBackColor = false;
            this.BtnChout.Click += new System.EventHandler(this.BtnChout_Click);
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(432, 37);
            this.lblCapacity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(138, 31);
            this.lblCapacity.TabIndex = 3;
            this.lblCapacity.Text = "Capacity:";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.Location = new System.Drawing.Point(5, 37);
            this.lblTableNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(206, 31);
            this.lblTableNumber.TabIndex = 1;
            this.lblTableNumber.Text = "Table Number:";
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.Location = new System.Drawing.Point(11, 145);
            this.BtnOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(237, 56);
            this.BtnOrder.TabIndex = 3;
            this.BtnOrder.Text = "Add Order";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // pnlCurrentOrders
            // 
            this.pnlCurrentOrders.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlCurrentOrders.AutoSize = true;
            this.pnlCurrentOrders.BackColor = System.Drawing.Color.White;
            this.pnlCurrentOrders.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.pnlCurrentOrders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCurrentOrders.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlCurrentOrders.Location = new System.Drawing.Point(-13, 341);
            this.pnlCurrentOrders.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlCurrentOrders.Name = "pnlCurrentOrders";
            this.pnlCurrentOrders.Size = new System.Drawing.Size(780, 889);
            this.pnlCurrentOrders.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 308);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "Orders";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(9, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(237, 56);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Return to table view";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TableDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlCurrentOrders);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button BtnOrder;       
        private System.Windows.Forms.Button BtnChout;
        private System.Windows.Forms.FlowLayoutPanel pnlCurrentOrders;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnOccupy;
    }
}