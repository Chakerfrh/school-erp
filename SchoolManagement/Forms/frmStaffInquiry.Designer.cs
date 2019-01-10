namespace SchoolManagement.Forms
{
    partial class frmStaffInquiries
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffInquiries));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbsalaryType = new System.Windows.Forms.ComboBox();
            this.txtVisaNumber = new System.Windows.Forms.TextBox();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.lblVisaNumber = new System.Windows.Forms.Label();
            this.lblPassportNumber = new System.Windows.Forms.Label();
            this.lblSalaryType = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.txtLabourCardNumber = new System.Windows.Forms.TextBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtEmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBankAccountNumber = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.lblLabourCardNumber = new System.Windows.Forms.Label();
            this.lblBankAccountNumber = new System.Windows.Forms.Label();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(708, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 23);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(617, 115);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 23);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // cmbsalaryType
            // 
            this.cmbsalaryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsalaryType.FormattingEnabled = true;
            this.cmbsalaryType.Items.AddRange(new object[] {
            "All",
            "Daily wage",
            "Monthly"});
            this.cmbsalaryType.Location = new System.Drawing.Point(593, 38);
            this.cmbsalaryType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbsalaryType.Name = "cmbsalaryType";
            this.cmbsalaryType.Size = new System.Drawing.Size(200, 22);
            this.cmbsalaryType.TabIndex = 41;
            // 
            // txtVisaNumber
            // 
            this.txtVisaNumber.Location = new System.Drawing.Point(593, 89);
            this.txtVisaNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVisaNumber.Name = "txtVisaNumber";
            this.txtVisaNumber.Size = new System.Drawing.Size(200, 22);
            this.txtVisaNumber.TabIndex = 45;
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(593, 64);
            this.txtPassportNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPassportNumber.TabIndex = 43;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(593, 13);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeeName.TabIndex = 39;
            // 
            // lblVisaNumber
            // 
            this.lblVisaNumber.AutoSize = true;
            this.lblVisaNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblVisaNumber.ForeColor = System.Drawing.Color.Black;
            this.lblVisaNumber.Location = new System.Drawing.Point(483, 93);
            this.lblVisaNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVisaNumber.Name = "lblVisaNumber";
            this.lblVisaNumber.Size = new System.Drawing.Size(52, 14);
            this.lblVisaNumber.TabIndex = 56;
            this.lblVisaNumber.Text = "Visa No.";
            // 
            // lblPassportNumber
            // 
            this.lblPassportNumber.AutoSize = true;
            this.lblPassportNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPassportNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPassportNumber.Location = new System.Drawing.Point(483, 68);
            this.lblPassportNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblPassportNumber.Name = "lblPassportNumber";
            this.lblPassportNumber.Size = new System.Drawing.Size(75, 14);
            this.lblPassportNumber.TabIndex = 55;
            this.lblPassportNumber.Text = "Passport No.";
            // 
            // lblSalaryType
            // 
            this.lblSalaryType.AutoSize = true;
            this.lblSalaryType.BackColor = System.Drawing.Color.Transparent;
            this.lblSalaryType.ForeColor = System.Drawing.Color.Black;
            this.lblSalaryType.Location = new System.Drawing.Point(483, 42);
            this.lblSalaryType.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSalaryType.Name = "lblSalaryType";
            this.lblSalaryType.Size = new System.Drawing.Size(67, 14);
            this.lblSalaryType.TabIndex = 54;
            this.lblSalaryType.Text = "Salary Type";
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeName.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeName.Location = new System.Drawing.Point(483, 17);
            this.lblEmployeeName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(95, 14);
            this.lblEmployeeName.TabIndex = 53;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(142, 38);
            this.cmbDesignation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(200, 22);
            this.cmbDesignation.TabIndex = 40;
            // 
            // txtLabourCardNumber
            // 
            this.txtLabourCardNumber.Location = new System.Drawing.Point(142, 89);
            this.txtLabourCardNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtLabourCardNumber.Name = "txtLabourCardNumber";
            this.txtLabourCardNumber.Size = new System.Drawing.Size(200, 22);
            this.txtLabourCardNumber.TabIndex = 44;
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AllowUserToDeleteRows = false;
            this.dgvEmployee.AllowUserToResizeColumns = false;
            this.dgvEmployee.AllowUserToResizeRows = false;
            this.dgvEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployee.ColumnHeadersHeight = 25;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtEmployeeId,
            this.dgvtxtEmployeeCode,
            this.dgvtxtEmployeeName,
            this.dgvtxtDesignation});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployee.EnableHeadersVisualStyles = false;
            this.dgvEmployee.GridColor = System.Drawing.Color.DimGray;
            this.dgvEmployee.Location = new System.Drawing.Point(31, 145);
            this.dgvEmployee.MultiSelect = false;
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.ReadOnly = true;
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployee.ShowCellToolTips = false;
            this.dgvEmployee.Size = new System.Drawing.Size(764, 432);
            this.dgvEmployee.TabIndex = 52;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtEmployeeId
            // 
            this.dgvtxtEmployeeId.DataPropertyName = "employeeId";
            this.dgvtxtEmployeeId.HeaderText = "Employee Id";
            this.dgvtxtEmployeeId.Name = "dgvtxtEmployeeId";
            this.dgvtxtEmployeeId.ReadOnly = true;
            this.dgvtxtEmployeeId.Visible = false;
            // 
            // dgvtxtEmployeeCode
            // 
            this.dgvtxtEmployeeCode.DataPropertyName = "employeeCode";
            this.dgvtxtEmployeeCode.HeaderText = "Employee Code";
            this.dgvtxtEmployeeCode.Name = "dgvtxtEmployeeCode";
            this.dgvtxtEmployeeCode.ReadOnly = true;
            this.dgvtxtEmployeeCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtEmployeeName
            // 
            this.dgvtxtEmployeeName.DataPropertyName = "employeeName";
            this.dgvtxtEmployeeName.HeaderText = "Employee Name";
            this.dgvtxtEmployeeName.Name = "dgvtxtEmployeeName";
            this.dgvtxtEmployeeName.ReadOnly = true;
            this.dgvtxtEmployeeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDesignation
            // 
            this.dgvtxtDesignation.DataPropertyName = "designationName";
            this.dgvtxtDesignation.HeaderText = "Designation";
            this.dgvtxtDesignation.Name = "dgvtxtDesignation";
            this.dgvtxtDesignation.ReadOnly = true;
            this.dgvtxtDesignation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // txtBankAccountNumber
            // 
            this.txtBankAccountNumber.Location = new System.Drawing.Point(142, 64);
            this.txtBankAccountNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBankAccountNumber.Name = "txtBankAccountNumber";
            this.txtBankAccountNumber.Size = new System.Drawing.Size(200, 22);
            this.txtBankAccountNumber.TabIndex = 42;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(142, 13);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(200, 22);
            this.txtEmployeeCode.TabIndex = 38;
            // 
            // lblLabourCardNumber
            // 
            this.lblLabourCardNumber.AutoSize = true;
            this.lblLabourCardNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblLabourCardNumber.ForeColor = System.Drawing.Color.Black;
            this.lblLabourCardNumber.Location = new System.Drawing.Point(32, 93);
            this.lblLabourCardNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblLabourCardNumber.Name = "lblLabourCardNumber";
            this.lblLabourCardNumber.Size = new System.Drawing.Size(92, 14);
            this.lblLabourCardNumber.TabIndex = 51;
            this.lblLabourCardNumber.Text = "Labour Card No.";
            // 
            // lblBankAccountNumber
            // 
            this.lblBankAccountNumber.AutoSize = true;
            this.lblBankAccountNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblBankAccountNumber.ForeColor = System.Drawing.Color.Black;
            this.lblBankAccountNumber.Location = new System.Drawing.Point(32, 68);
            this.lblBankAccountNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBankAccountNumber.Name = "lblBankAccountNumber";
            this.lblBankAccountNumber.Size = new System.Drawing.Size(75, 14);
            this.lblBankAccountNumber.TabIndex = 50;
            this.lblBankAccountNumber.Text = "Bank A/c No.";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.BackColor = System.Drawing.Color.Transparent;
            this.lblDesignation.ForeColor = System.Drawing.Color.Black;
            this.lblDesignation.Location = new System.Drawing.Point(32, 42);
            this.lblDesignation.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(73, 14);
            this.lblDesignation.TabIndex = 49;
            this.lblDesignation.Text = "Designation";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCode.Location = new System.Drawing.Point(32, 17);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(90, 14);
            this.lblEmployeeCode.TabIndex = 48;
            this.lblEmployeeCode.Text = "Employee Code";
            // 
            // frmStaffInquiries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 591);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbsalaryType);
            this.Controls.Add(this.txtVisaNumber);
            this.Controls.Add(this.txtPassportNumber);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.lblVisaNumber);
            this.Controls.Add(this.lblPassportNumber);
            this.Controls.Add(this.lblSalaryType);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.txtLabourCardNumber);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.txtBankAccountNumber);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.lblLabourCardNumber);
            this.Controls.Add(this.lblBankAccountNumber);
            this.Controls.Add(this.lblDesignation);
            this.Controls.Add(this.lblEmployeeCode);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStaffInquiries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Inquiry";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbsalaryType;
        private System.Windows.Forms.TextBox txtVisaNumber;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.Label lblVisaNumber;
        private System.Windows.Forms.Label lblPassportNumber;
        private System.Windows.Forms.Label lblSalaryType;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.TextBox txtLabourCardNumber;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtEmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignation;
        private System.Windows.Forms.TextBox txtBankAccountNumber;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label lblLabourCardNumber;
        private System.Windows.Forms.Label lblBankAccountNumber;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblEmployeeCode;
    }
}