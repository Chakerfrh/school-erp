namespace SchoolManagement.Forms
{
    partial class frmStudentBalances
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudentBalances));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvStudentBalance = new System.Windows.Forms.DataGridView();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAdminNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtbalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBalance)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(195, 92);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 25);
            this.btnClear.TabIndex = 66;
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
            this.btnSearch.Location = new System.Drawing.Point(80, 92);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 25);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvStudentBalance
            // 
            this.dgvStudentBalance.AllowUserToAddRows = false;
            this.dgvStudentBalance.AllowUserToDeleteRows = false;
            this.dgvStudentBalance.AllowUserToResizeColumns = false;
            this.dgvStudentBalance.AllowUserToResizeRows = false;
            this.dgvStudentBalance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudentBalance.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudentBalance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudentBalance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudentBalance.ColumnHeadersHeight = 25;
            this.dgvStudentBalance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStudentBalance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtName,
            this.dgvtxtAdminNo,
            this.dgvtxtClass,
            this.dgvtxtbalance});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudentBalance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudentBalance.EnableHeadersVisualStyles = false;
            this.dgvStudentBalance.GridColor = System.Drawing.Color.DimGray;
            this.dgvStudentBalance.Location = new System.Drawing.Point(12, 132);
            this.dgvStudentBalance.MultiSelect = false;
            this.dgvStudentBalance.Name = "dgvStudentBalance";
            this.dgvStudentBalance.ReadOnly = true;
            this.dgvStudentBalance.RowHeadersVisible = false;
            this.dgvStudentBalance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentBalance.ShowCellToolTips = false;
            this.dgvStudentBalance.Size = new System.Drawing.Size(764, 465);
            this.dgvStudentBalance.TabIndex = 71;
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.BackColor = System.Drawing.Color.Transparent;
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.Black;
            this.lblEmployeeCode.Location = new System.Drawing.Point(9, 24);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(36, 14);
            this.lblEmployeeCode.TabIndex = 67;
            this.lblEmployeeCode.Text = "Class";
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cboClass.Location = new System.Drawing.Point(80, 24);
            this.cboClass.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(200, 22);
            this.cboClass.TabIndex = 75;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.FillWeight = 113.4068F;
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtName
            // 
            this.dgvtxtName.DataPropertyName = "StudentName";
            this.dgvtxtName.FillWeight = 206.2458F;
            this.dgvtxtName.HeaderText = "Name";
            this.dgvtxtName.Name = "dgvtxtName";
            this.dgvtxtName.ReadOnly = true;
            // 
            // dgvtxtAdminNo
            // 
            this.dgvtxtAdminNo.DataPropertyName = "adminNumber";
            this.dgvtxtAdminNo.FillWeight = 67.80005F;
            this.dgvtxtAdminNo.HeaderText = "Admin No";
            this.dgvtxtAdminNo.Name = "dgvtxtAdminNo";
            this.dgvtxtAdminNo.ReadOnly = true;
            this.dgvtxtAdminNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtClass
            // 
            this.dgvtxtClass.DataPropertyName = "classNo";
            this.dgvtxtClass.FillWeight = 49.09562F;
            this.dgvtxtClass.HeaderText = "Class";
            this.dgvtxtClass.Name = "dgvtxtClass";
            this.dgvtxtClass.ReadOnly = true;
            this.dgvtxtClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtbalance
            // 
            this.dgvtxtbalance.DataPropertyName = "balance";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvtxtbalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtbalance.FillWeight = 63.45177F;
            this.dgvtxtbalance.HeaderText = "Balance";
            this.dgvtxtbalance.Name = "dgvtxtbalance";
            this.dgvtxtbalance.ReadOnly = true;
            this.dgvtxtbalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // frmStudentBalances
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 551);
            this.Controls.Add(this.cboClass);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStudentBalance);
            this.Controls.Add(this.lblEmployeeCode);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStudentBalances";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentBalances";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentBalance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvStudentBalance;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAdminNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtbalance;
    }
}