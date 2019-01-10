namespace SchoolManagement.Forms
{
    partial class frmAttendance
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendance));
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.dgvsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbstudent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvstatus = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgv_check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dgvAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsno,
            this.dgvcmbstudent,
            this.dgvstatus,
            this.dgv_check});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAttendance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAttendance.EnableHeadersVisualStyles = false;
            this.dgvAttendance.Location = new System.Drawing.Point(14, 104);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttendance.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvAttendance.Size = new System.Drawing.Size(765, 484);
            this.dgvAttendance.TabIndex = 2;
            this.dgvAttendance.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvAttendance_CellBeginEdit);
            this.dgvAttendance.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_CellValueChanged);
            this.dgvAttendance.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvAttendance_DataError);
            this.dgvAttendance.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_RowEnter);
            this.dgvAttendance.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAttendance_RowLeave);
            this.dgvAttendance.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvAttendance_RowsAdded);
            // 
            // dgvsno
            // 
            this.dgvsno.HeaderText = "SNo";
            this.dgvsno.Name = "dgvsno";
            this.dgvsno.ReadOnly = true;
            // 
            // dgvcmbstudent
            // 
            this.dgvcmbstudent.DataPropertyName = "StudentId";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvcmbstudent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcmbstudent.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvcmbstudent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvcmbstudent.HeaderText = "Student";
            this.dgvcmbstudent.Name = "dgvcmbstudent";
            this.dgvcmbstudent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbstudent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcmbstudent.Width = 310;
            // 
            // dgvstatus
            // 
            this.dgvstatus.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvstatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvstatus.HeaderText = "Status";
            this.dgvstatus.Items.AddRange(new object[] {
            "Absent",
            "Present"});
            this.dgvstatus.Name = "dgvstatus";
            this.dgvstatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvstatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvstatus.Width = 310;
            // 
            // dgv_check
            // 
            this.dgv_check.HeaderText = "";
            this.dgv_check.Name = "dgv_check";
            this.dgv_check.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Date";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(42, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(128, 22);
            this.datePicker.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Class";
            // 
            // cmbClass
            // 
            this.cmbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(552, 3);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(213, 22);
            this.cmbClass.TabIndex = 6;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.cmbTerm);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datePicker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(15, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(768, 30);
            this.panel1.TabIndex = 7;
            // 
            // cmbTerm
            // 
            this.cmbTerm.DisplayMember = "term_id";
            this.cmbTerm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(260, 3);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(195, 22);
            this.cmbTerm.TabIndex = 9;
            this.cmbTerm.ValueMember = "term_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Term";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(695, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1270;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 600);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvAttendance);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Attendance";
            this.Load += new System.EventHandler(this.frmAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsno;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbstudent;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvstatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_check;
    }
}