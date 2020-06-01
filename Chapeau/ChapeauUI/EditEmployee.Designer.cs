namespace ChapeauUI
{
    partial class EditEmployee
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
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnToManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlEditEmp = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbAllEmp = new System.Windows.Forms.ComboBox();
            this.btnApplyEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.txtEditUser = new System.Windows.Forms.TextBox();
            this.btnEmpApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlEditEmp.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.editEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem,
            this.returnToManagementToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1087, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(162, 32);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(161, 32);
            this.editEmployeeToolStripMenuItem.Text = "Edit Employee";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.editEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            // 
            // returnToManagementToolStripMenuItem
            // 
            this.returnToManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToManagementToolStripMenuItem.Name = "returnToManagementToolStripMenuItem";
            this.returnToManagementToolStripMenuItem.Size = new System.Drawing.Size(246, 32);
            this.returnToManagementToolStripMenuItem.Text = "Return to management";
            this.returnToManagementToolStripMenuItem.Click += new System.EventHandler(this.returnToManagementToolStripMenuItem_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Controls.Add(this.btnEmpApply);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.cmbEmpType);
            this.pnlAdd.Controls.Add(this.txtPassword);
            this.pnlAdd.Controls.Add(this.txtUsername);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Location = new System.Drawing.Point(0, 120);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(1087, 576);
            this.pnlAdd.TabIndex = 1;
            this.pnlAdd.Visible = false;
            // 
            // pnlEditEmp
            // 
            this.pnlEditEmp.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditEmp.Controls.Add(this.label10);
            this.pnlEditEmp.Controls.Add(this.label9);
            this.pnlEditEmp.Controls.Add(this.cmbAllEmp);
            this.pnlEditEmp.Controls.Add(this.btnApplyEdit);
            this.pnlEditEmp.Controls.Add(this.label6);
            this.pnlEditEmp.Controls.Add(this.label7);
            this.pnlEditEmp.Controls.Add(this.txtEditPassword);
            this.pnlEditEmp.Controls.Add(this.txtEditUser);
            this.pnlEditEmp.Location = new System.Drawing.Point(0, 123);
            this.pnlEditEmp.Name = "pnlEditEmp";
            this.pnlEditEmp.Size = new System.Drawing.Size(1087, 573);
            this.pnlEditEmp.TabIndex = 9;
            this.pnlEditEmp.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(474, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Make Changes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(220, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Pick an employee:";
            // 
            // cmbAllEmp
            // 
            this.cmbAllEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAllEmp.FormattingEnabled = true;
            this.cmbAllEmp.Location = new System.Drawing.Point(447, 33);
            this.cmbAllEmp.Name = "cmbAllEmp";
            this.cmbAllEmp.Size = new System.Drawing.Size(322, 37);
            this.cmbAllEmp.TabIndex = 9;
            // 
            // btnApplyEdit
            // 
            this.btnApplyEdit.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnApplyEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplyEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyEdit.Location = new System.Drawing.Point(447, 423);
            this.btnApplyEdit.Name = "btnApplyEdit";
            this.btnApplyEdit.Size = new System.Drawing.Size(210, 60);
            this.btnApplyEdit.TabIndex = 8;
            this.btnApplyEdit.Text = "Apply Changes";
            this.btnApplyEdit.UseVisualStyleBackColor = true;
            this.btnApplyEdit.Click += new System.EventHandler(this.btnApplyEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(240, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(240, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "User name:";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPassword.Location = new System.Drawing.Point(447, 303);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(298, 30);
            this.txtEditPassword.TabIndex = 2;
            // 
            // txtEditUser
            // 
            this.txtEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUser.Location = new System.Drawing.Point(447, 240);
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Size = new System.Drawing.Size(298, 30);
            this.txtEditUser.TabIndex = 1;
            // 
            // btnEmpApply
            // 
            this.btnEmpApply.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnEmpApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpApply.Location = new System.Drawing.Point(482, 423);
            this.btnEmpApply.Name = "btnEmpApply";
            this.btnEmpApply.Size = new System.Drawing.Size(210, 60);
            this.btnEmpApply.TabIndex = 8;
            this.btnEmpApply.Text = "Apply";
            this.btnEmpApply.UseVisualStyleBackColor = true;
            this.btnEmpApply.Click += new System.EventHandler(this.btnEmpApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(243, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(243, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "User name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // cmbEmpType
            // 
            this.cmbEmpType.FormattingEnabled = true;
            this.cmbEmpType.Location = new System.Drawing.Point(450, 346);
            this.cmbEmpType.Name = "cmbEmpType";
            this.cmbEmpType.Size = new System.Drawing.Size(298, 24);
            this.cmbEmpType.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(450, 278);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(298, 30);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(450, 215);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(298, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(450, 152);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 30);
            this.txtName.TabIndex = 0;
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1087, 1055);
            this.Controls.Add(this.pnlEditEmp);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditEmployee";
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlEditEmp.ResumeLayout(false);
            this.pnlEditEmp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmpType;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ToolStripMenuItem returnToManagementToolStripMenuItem;
        private System.Windows.Forms.Button btnEmpApply;
        private System.Windows.Forms.Panel pnlEditEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbAllEmp;
        private System.Windows.Forms.Button btnApplyEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditUser;
    }
}