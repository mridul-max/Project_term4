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
            this.btnAddEmpApply = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmpType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlEditEmp = new System.Windows.Forms.Panel();
            this.listEditEmployee = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label10 = new System.Windows.Forms.Label();
            this.btnApplyEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEditPassword = new System.Windows.Forms.TextBox();
            this.txtEditUser = new System.Windows.Forms.TextBox();
            this.pnlRemove = new System.Windows.Forms.Panel();
            this.listRemoveEmployee = new System.Windows.Forms.ListView();
            this.employeeID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.employeeType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlEditEmp.SuspendLayout();
            this.pnlRemove.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(784, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(152, 29);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.AddEmployeeToolStripMenuItem_Click);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(149, 29);
            this.editEmployeeToolStripMenuItem.Text = "Edit Employee";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.EditEmployeeToolStripMenuItem_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(186, 29);
            this.removeEmployeeToolStripMenuItem.Text = "Remove Employee";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.RemoveEmployeeToolStripMenuItem_Click);
            // 
            // returnToManagementToolStripMenuItem
            // 
            this.returnToManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToManagementToolStripMenuItem.Name = "returnToManagementToolStripMenuItem";
            this.returnToManagementToolStripMenuItem.Size = new System.Drawing.Size(231, 29);
            this.returnToManagementToolStripMenuItem.Text = "Return to management";
            this.returnToManagementToolStripMenuItem.Click += new System.EventHandler(this.ReturnToManagementToolStripMenuItem_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Transparent;
            this.pnlAdd.Controls.Add(this.btnAddEmpApply);
            this.pnlAdd.Controls.Add(this.label4);
            this.pnlAdd.Controls.Add(this.label3);
            this.pnlAdd.Controls.Add(this.label2);
            this.pnlAdd.Controls.Add(this.label1);
            this.pnlAdd.Controls.Add(this.cmbEmpType);
            this.pnlAdd.Controls.Add(this.txtPassword);
            this.pnlAdd.Controls.Add(this.txtUsername);
            this.pnlAdd.Controls.Add(this.txtName);
            this.pnlAdd.Location = new System.Drawing.Point(0, 46);
            this.pnlAdd.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(784, 1180);
            this.pnlAdd.TabIndex = 1;
            this.pnlAdd.Visible = false;
            // 
            // btnAddEmpApply
            // 
            this.btnAddEmpApply.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnAddEmpApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddEmpApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmpApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmpApply.Location = new System.Drawing.Point(216, 698);
            this.btnAddEmpApply.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEmpApply.Name = "btnAddEmpApply";
            this.btnAddEmpApply.Size = new System.Drawing.Size(314, 126);
            this.btnAddEmpApply.TabIndex = 8;
            this.btnAddEmpApply.Text = "Create Employee";
            this.btnAddEmpApply.UseVisualStyleBackColor = true;
            this.btnAddEmpApply.Click += new System.EventHandler(this.BtnEmpApply_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 503);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Employee Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 416);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 318);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "User name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // cmbEmpType
            // 
            this.cmbEmpType.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpType.FormattingEnabled = true;
            this.cmbEmpType.Location = new System.Drawing.Point(378, 500);
            this.cmbEmpType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEmpType.Name = "cmbEmpType";
            this.cmbEmpType.Size = new System.Drawing.Size(291, 37);
            this.cmbEmpType.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(378, 413);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(291, 35);
            this.txtPassword.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(378, 315);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(291, 35);
            this.txtUsername.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(378, 218);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(291, 35);
            this.txtName.TabIndex = 0;
            // 
            // pnlEditEmp
            // 
            this.pnlEditEmp.BackColor = System.Drawing.Color.Transparent;
            this.pnlEditEmp.Controls.Add(this.listEditEmployee);
            this.pnlEditEmp.Controls.Add(this.label10);
            this.pnlEditEmp.Controls.Add(this.btnApplyEdit);
            this.pnlEditEmp.Controls.Add(this.label6);
            this.pnlEditEmp.Controls.Add(this.label7);
            this.pnlEditEmp.Controls.Add(this.txtEditPassword);
            this.pnlEditEmp.Controls.Add(this.txtEditUser);
            this.pnlEditEmp.Location = new System.Drawing.Point(0, 48);
            this.pnlEditEmp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEditEmp.Name = "pnlEditEmp";
            this.pnlEditEmp.Size = new System.Drawing.Size(784, 1180);
            this.pnlEditEmp.TabIndex = 9;
            this.pnlEditEmp.Visible = false;
            // 
            // listEditEmployee
            // 
            this.listEditEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listEditEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEditEmployee.FullRowSelect = true;
            this.listEditEmployee.HideSelection = false;
            this.listEditEmployee.Location = new System.Drawing.Point(27, 200);
            this.listEditEmployee.MultiSelect = false;
            this.listEditEmployee.Name = "listEditEmployee";
            this.listEditEmployee.Size = new System.Drawing.Size(731, 964);
            this.listEditEmployee.TabIndex = 12;
            this.listEditEmployee.UseCompatibleStateImageBehavior = false;
            this.listEditEmployee.View = System.Windows.Forms.View.Details;
            this.listEditEmployee.SelectedIndexChanged += new System.EventHandler(this.listEditEmployee_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 119;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Type";
            this.columnHeader3.Width = 106;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(29, 24);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(481, 29);
            this.label10.TabIndex = 11;
            this.label10.Text = "Enter only the fields you want to change:";
            // 
            // btnApplyEdit
            // 
            this.btnApplyEdit.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnApplyEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnApplyEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyEdit.Location = new System.Drawing.Point(540, 79);
            this.btnApplyEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyEdit.Name = "btnApplyEdit";
            this.btnApplyEdit.Size = new System.Drawing.Size(218, 72);
            this.btnApplyEdit.TabIndex = 8;
            this.btnApplyEdit.Text = "Apply Changes";
            this.btnApplyEdit.UseVisualStyleBackColor = true;
            this.btnApplyEdit.Click += new System.EventHandler(this.BtnApplyEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 133);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "User name:";
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditPassword.Location = new System.Drawing.Point(191, 130);
            this.txtEditPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(319, 35);
            this.txtEditPassword.TabIndex = 2;
            // 
            // txtEditUser
            // 
            this.txtEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditUser.Location = new System.Drawing.Point(191, 77);
            this.txtEditUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtEditUser.Name = "txtEditUser";
            this.txtEditUser.Size = new System.Drawing.Size(319, 35);
            this.txtEditUser.TabIndex = 1;
            // 
            // pnlRemove
            // 
            this.pnlRemove.BackColor = System.Drawing.Color.Transparent;
            this.pnlRemove.Controls.Add(this.listRemoveEmployee);
            this.pnlRemove.Controls.Add(this.label8);
            this.pnlRemove.Controls.Add(this.btnRemove);
            this.pnlRemove.Location = new System.Drawing.Point(0, 48);
            this.pnlRemove.Margin = new System.Windows.Forms.Padding(2);
            this.pnlRemove.Name = "pnlRemove";
            this.pnlRemove.Size = new System.Drawing.Size(784, 1182);
            this.pnlRemove.TabIndex = 12;
            this.pnlRemove.Visible = false;
            // 
            // listRemoveEmployee
            // 
            this.listRemoveEmployee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeID,
            this.employeeName,
            this.employeeType});
            this.listRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRemoveEmployee.FullRowSelect = true;
            this.listRemoveEmployee.HideSelection = false;
            this.listRemoveEmployee.Location = new System.Drawing.Point(27, 113);
            this.listRemoveEmployee.MultiSelect = false;
            this.listRemoveEmployee.Name = "listRemoveEmployee";
            this.listRemoveEmployee.Size = new System.Drawing.Size(731, 1062);
            this.listRemoveEmployee.TabIndex = 11;
            this.listRemoveEmployee.UseCompatibleStateImageBehavior = false;
            this.listRemoveEmployee.View = System.Windows.Forms.View.Details;
            // 
            // employeeID
            // 
            this.employeeID.Text = "ID";
            this.employeeID.Width = 128;
            // 
            // employeeName
            // 
            this.employeeName.Text = "Name";
            this.employeeName.Width = 119;
            // 
            // employeeType
            // 
            this.employeeType.Text = "Type";
            this.employeeType.Width = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 39);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Pick an employee:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(482, 11);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(276, 80);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove Employee";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // EditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ChapeauUI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 1241);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlEditEmp);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlRemove);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditEmployee";
            this.Load += new System.EventHandler(this.EditEmployee_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlEditEmp.ResumeLayout(false);
            this.pnlEditEmp.PerformLayout();
            this.pnlRemove.ResumeLayout(false);
            this.pnlRemove.PerformLayout();
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
        private System.Windows.Forms.Button btnAddEmpApply;
        private System.Windows.Forms.Panel pnlEditEmp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnApplyEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditUser;
        private System.Windows.Forms.Panel pnlRemove;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListView listRemoveEmployee;
        private System.Windows.Forms.ColumnHeader employeeID;
        private System.Windows.Forms.ColumnHeader employeeName;
        private System.Windows.Forms.ColumnHeader employeeType;
        private System.Windows.Forms.ListView listEditEmployee;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}