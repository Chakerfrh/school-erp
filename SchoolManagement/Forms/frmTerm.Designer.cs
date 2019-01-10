namespace SchoolManagement.Forms
{
    partial class frmTerm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTerm));
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvTerm = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtfrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTermId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtdatePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdatePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(433, 21);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(13, 14);
            this.lblSalaryTypeValidator.TabIndex = 180;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(713, 116);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 29);
            this.btnClose.TabIndex = 176;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.ForeColor = System.Drawing.Color.Black;
            this.lblRole.Location = new System.Drawing.Point(31, 21);
            this.lblRole.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(39, 14);
            this.lblRole.TabIndex = 178;
            this.lblRole.Text = "Name";
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(116, 21);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(307, 22);
            this.txtTerm.TabIndex = 172;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(459, 116);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 174;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(584, 116);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 175;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dgvTerm
            // 
            this.dgvTerm.AllowUserToAddRows = false;
            this.dgvTerm.AllowUserToDeleteRows = false;
            this.dgvTerm.AllowUserToResizeColumns = false;
            this.dgvTerm.AllowUserToResizeRows = false;
            this.dgvTerm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTerm.BackgroundColor = System.Drawing.Color.White;
            this.dgvTerm.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTerm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTerm.ColumnHeadersHeight = 25;
            this.dgvTerm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTerm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtname,
            this.dgvtxtfrom,
            this.dgvtxtto,
            this.dgvTermId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTerm.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTerm.EnableHeadersVisualStyles = false;
            this.dgvTerm.GridColor = System.Drawing.Color.Gray;
            this.dgvTerm.Location = new System.Drawing.Point(34, 184);
            this.dgvTerm.Name = "dgvTerm";
            this.dgvTerm.ReadOnly = true;
            this.dgvTerm.RowHeadersVisible = false;
            this.dgvTerm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTerm.Size = new System.Drawing.Size(764, 400);
            this.dgvTerm.TabIndex = 177;
            this.dgvTerm.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTerm_CellClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SlNo";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtname
            // 
            this.dgvtxtname.DataPropertyName = "term_name";
            this.dgvtxtname.HeaderText = "Name";
            this.dgvtxtname.Name = "dgvtxtname";
            this.dgvtxtname.ReadOnly = true;
            this.dgvtxtname.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtfrom
            // 
            this.dgvtxtfrom.DataPropertyName = "date_start";
            this.dgvtxtfrom.HeaderText = "From";
            this.dgvtxtfrom.Name = "dgvtxtfrom";
            this.dgvtxtfrom.ReadOnly = true;
            this.dgvtxtfrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtto
            // 
            this.dgvtxtto.DataPropertyName = "date_end";
            this.dgvtxtto.HeaderText = "To";
            this.dgvtxtto.Name = "dgvtxtto";
            this.dgvtxtto.ReadOnly = true;
            // 
            // dgvTermId
            // 
            this.dgvTermId.DataPropertyName = "term_id";
            this.dgvTermId.HeaderText = "TermId";
            this.dgvTermId.Name = "dgvTermId";
            this.dgvTermId.ReadOnly = true;
            this.dgvTermId.Visible = false;
            // 
            // txtdatePicker1
            // 
            this.txtdatePicker1.Location = new System.Drawing.Point(116, 56);
            this.txtdatePicker1.Name = "txtdatePicker1";
            this.txtdatePicker1.Size = new System.Drawing.Size(307, 22);
            this.txtdatePicker1.TabIndex = 181;
            // 
            // txtdatePicker2
            // 
            this.txtdatePicker2.Location = new System.Drawing.Point(116, 84);
            this.txtdatePicker2.Name = "txtdatePicker2";
            this.txtdatePicker2.Size = new System.Drawing.Size(307, 22);
            this.txtdatePicker2.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 14);
            this.label1.TabIndex = 183;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 14);
            this.label2.TabIndex = 184;
            this.label2.Text = "To";
            // 
            // frmTerm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 596);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdatePicker2);
            this.Controls.Add(this.txtdatePicker1);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dgvTerm);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTerm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Term";
            this.Load += new System.EventHandler(this.frmTerm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTerm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvTerm;
        private System.Windows.Forms.DateTimePicker txtdatePicker1;
        private System.Windows.Forms.DateTimePicker txtdatePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtname;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtfrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtto;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTermId;
    }
}