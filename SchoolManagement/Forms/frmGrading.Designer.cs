namespace SchoolManagement.Forms
{
    partial class frmGrading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGrading));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnRoleAdd = new System.Windows.Forms.Button();
            this.dgvGrading = new System.Windows.Forms.DataGridView();
            this.dgvSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvsubject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvmarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrading)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbTerm);
            this.panel1.Controls.Add(this.cmbStudent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbClass);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(867, 30);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Term";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Class";
            // 
            // cmbTerm
            // 
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(646, 3);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(213, 22);
            this.cmbTerm.TabIndex = 9;
            // 
            // cmbStudent
            // 
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(351, 3);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(213, 22);
            this.cmbStudent.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(296, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(57, 3);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(213, 22);
            this.cmbClass.TabIndex = 8;
            this.cmbClass.SelectedIndexChanged += new System.EventHandler(this.cmbClass_SelectedIndexChanged);
            // 
            // btnRoleAdd
            // 
            this.btnRoleAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnRoleAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRoleAdd.FlatAppearance.BorderSize = 0;
            this.btnRoleAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoleAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoleAdd.ForeColor = System.Drawing.Color.White;
            this.btnRoleAdd.Location = new System.Drawing.Point(344, 637);
            this.btnRoleAdd.Name = "btnRoleAdd";
            this.btnRoleAdd.Size = new System.Drawing.Size(152, 24);
            this.btnRoleAdd.TabIndex = 1270;
            this.btnRoleAdd.Text = "Process";
            this.btnRoleAdd.UseVisualStyleBackColor = false;
            // 
            // dgvGrading
            // 
            this.dgvGrading.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrading.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrading.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrading.ColumnHeadersHeight = 35;
            this.dgvGrading.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvGrading.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSno,
            this.dgvsubject,
            this.dgvmarks,
            this.dgv_check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrading.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrading.EnableHeadersVisualStyles = false;
            this.dgvGrading.GridColor = System.Drawing.Color.DimGray;
            this.dgvGrading.Location = new System.Drawing.Point(52, 102);
            this.dgvGrading.Name = "dgvGrading";
            this.dgvGrading.Size = new System.Drawing.Size(793, 448);
            this.dgvGrading.TabIndex = 1271;
            this.dgvGrading.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvGrading_CellBeginEdit);
            this.dgvGrading.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrading_CellValueChanged);
            this.dgvGrading.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvGrading_RowsAdded);
            // 
            // dgvSno
            // 
            this.dgvSno.HeaderText = "SNo";
            this.dgvSno.Name = "dgvSno";
            // 
            // dgvsubject
            // 
            this.dgvsubject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dgvsubject.HeaderText = "Subject";
            this.dgvsubject.Name = "dgvsubject";
            this.dgvsubject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvsubject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvsubject.Width = 350;
            // 
            // dgvmarks
            // 
            this.dgvmarks.HeaderText = "Marks";
            this.dgvmarks.Name = "dgvmarks";
            this.dgvmarks.Width = 300;
            // 
            // dgv_check
            // 
            this.dgv_check.HeaderText = "";
            this.dgv_check.Name = "dgv_check";
            this.dgv_check.ReadOnly = true;
            this.dgv_check.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(760, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1273;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmGrading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 555);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvGrading);
            this.Controls.Add(this.btnRoleAdd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGrading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Marks";
            this.Load += new System.EventHandler(this.frmGrading_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRoleAdd;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.DataGridView dgvGrading;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSno;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvsubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvmarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_check;
    }
}