namespace SchoolManagement.Forms
{
    partial class frmPromoteStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPromoteStudents));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cboClass = new System.Windows.Forms.ComboBox();
            this.txtAdminNumber = new System.Windows.Forms.TextBox();
            this.dgvPromotion = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSearchRole = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.dgvtxtSLNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_promoted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dgvtxtStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.cboClass);
            this.groupBox2.Controls.Add(this.txtAdminNumber);
            this.groupBox2.Controls.Add(this.dgvPromotion);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.lblSearchRole);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(27, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 500);
            this.groupBox2.TabIndex = 1312;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(425, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1340;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(344, 24);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1239;
            this.label5.Text = "Class";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(663, 455);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 1342;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(538, 455);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1341;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cboClass
            // 
            this.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClass.FormattingEnabled = true;
            this.cboClass.Location = new System.Drawing.Point(410, 24);
            this.cboClass.Name = "cboClass";
            this.cboClass.Size = new System.Drawing.Size(237, 23);
            this.cboClass.TabIndex = 1238;
            // 
            // txtAdminNumber
            // 
            this.txtAdminNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminNumber.ForeColor = System.Drawing.Color.Black;
            this.txtAdminNumber.Location = new System.Drawing.Point(132, 25);
            this.txtAdminNumber.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAdminNumber.Name = "txtAdminNumber";
            this.txtAdminNumber.Size = new System.Drawing.Size(187, 20);
            this.txtAdminNumber.TabIndex = 1237;
            this.txtAdminNumber.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvPromotion
            // 
            this.dgvPromotion.AllowUserToAddRows = false;
            this.dgvPromotion.AllowUserToDeleteRows = false;
            this.dgvPromotion.AllowUserToResizeColumns = false;
            this.dgvPromotion.AllowUserToResizeRows = false;
            this.dgvPromotion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPromotion.BackgroundColor = System.Drawing.Color.White;
            this.dgvPromotion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPromotion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPromotion.ColumnHeadersHeight = 35;
            this.dgvPromotion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPromotion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSLNo,
            this.dgvtxtStudentName,
            this.dgvtxtStudentNo,
            this.dgvtxtClass,
            this.dgv_promoted,
            this.dgvtxtStudentId});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPromotion.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPromotion.EnableHeadersVisualStyles = false;
            this.dgvPromotion.GridColor = System.Drawing.Color.Gray;
            this.dgvPromotion.Location = new System.Drawing.Point(18, 83);
            this.dgvPromotion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvPromotion.Name = "dgvPromotion";
            this.dgvPromotion.RowHeadersVisible = false;
            this.dgvPromotion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPromotion.Size = new System.Drawing.Size(730, 359);
            this.dgvPromotion.TabIndex = 1236;
            this.dgvPromotion.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPromotion_DataError);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(9, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 1);
            this.groupBox3.TabIndex = 1225;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // lblSearchRole
            // 
            this.lblSearchRole.AutoSize = true;
            this.lblSearchRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRole.ForeColor = System.Drawing.Color.Black;
            this.lblSearchRole.Location = new System.Drawing.Point(15, 25);
            this.lblSearchRole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblSearchRole.Name = "lblSearchRole";
            this.lblSearchRole.Size = new System.Drawing.Size(94, 13);
            this.lblSearchRole.TabIndex = 1222;
            this.lblSearchRole.Text = "Admission Number";
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.Gray;
            this.btnDisplay.FlatAppearance.BorderSize = 0;
            this.btnDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisplay.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.Transparent;
            this.btnDisplay.Location = new System.Drawing.Point(665, 24);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(83, 21);
            this.btnDisplay.TabIndex = 1223;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // dgvtxtSLNo
            // 
            this.dgvtxtSLNo.DataPropertyName = "SL.No";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtSLNo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtSLNo.HeaderText = "No";
            this.dgvtxtSLNo.Name = "dgvtxtSLNo";
            this.dgvtxtSLNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtStudentName
            // 
            this.dgvtxtStudentName.DataPropertyName = "otherName";
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtStudentName.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtStudentName.HeaderText = "Student Name";
            this.dgvtxtStudentName.Name = "dgvtxtStudentName";
            this.dgvtxtStudentName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtStudentNo
            // 
            this.dgvtxtStudentNo.DataPropertyName = "adminNumber";
            this.dgvtxtStudentNo.HeaderText = "Admision No";
            this.dgvtxtStudentNo.Name = "dgvtxtStudentNo";
            this.dgvtxtStudentNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtClass
            // 
            this.dgvtxtClass.DataPropertyName = "ClassNo";
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtClass.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtClass.HeaderText = "Class";
            this.dgvtxtClass.Name = "dgvtxtClass";
            this.dgvtxtClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgv_promoted
            // 
            this.dgv_promoted.FalseValue = "0";
            this.dgv_promoted.HeaderText = "Promote";
            this.dgv_promoted.Name = "dgv_promoted";
            this.dgv_promoted.ToolTipText = "promote to next class";
            this.dgv_promoted.TrueValue = "1";
            // 
            // dgvtxtStudentId
            // 
            this.dgvtxtStudentId.DataPropertyName = "ledgerId";
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtStudentId.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtStudentId.HeaderText = "StudentId";
            this.dgvtxtStudentId.Name = "dgvtxtStudentId";
            this.dgvtxtStudentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtStudentId.Visible = false;
            // 
            // frmPromoteStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 538);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPromoteStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promote Students";
            this.Load += new System.EventHandler(this.frmPromoteStudents_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPromotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboClass;
        private System.Windows.Forms.DataGridView dgvPromotion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblSearchRole;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtAdminNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSLNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClass;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dgv_promoted;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStudentId;
    }
}