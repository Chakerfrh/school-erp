namespace SchoolManagement.Forms
{
    partial class frmDesignation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignation));
            this.lblStar = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dgvDesignation = new System.Windows.Forms.DataGridView();
            this.slNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtDesignationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDesignationName = new System.Windows.Forms.TextBox();
            this.lblDesignationName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAdvanceAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStar
            // 
            this.lblStar.AutoSize = true;
            this.lblStar.ForeColor = System.Drawing.Color.Red;
            this.lblStar.Location = new System.Drawing.Point(401, 17);
            this.lblStar.Name = "lblStar";
            this.lblStar.Size = new System.Drawing.Size(13, 14);
            this.lblStar.TabIndex = 32;
            this.lblStar.Text = "*";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(696, 85);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 29);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(594, 85);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 29);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(486, 85);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 29);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dgvDesignation
            // 
            this.dgvDesignation.AllowUserToAddRows = false;
            this.dgvDesignation.AllowUserToDeleteRows = false;
            this.dgvDesignation.AllowUserToResizeColumns = false;
            this.dgvDesignation.AllowUserToResizeRows = false;
            this.dgvDesignation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDesignation.BackgroundColor = System.Drawing.Color.White;
            this.dgvDesignation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDesignation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDesignation.ColumnHeadersHeight = 25;
            this.dgvDesignation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDesignation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slNo,
            this.dgvtxtDesignationName,
            this.dgvDescription,
            this.dgvtxtDesignationId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDesignation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDesignation.EnableHeadersVisualStyles = false;
            this.dgvDesignation.GridColor = System.Drawing.Color.DimGray;
            this.dgvDesignation.Location = new System.Drawing.Point(20, 130);
            this.dgvDesignation.MultiSelect = false;
            this.dgvDesignation.Name = "dgvDesignation";
            this.dgvDesignation.ReadOnly = true;
            this.dgvDesignation.RowHeadersVisible = false;
            this.dgvDesignation.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDesignation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDesignation.Size = new System.Drawing.Size(764, 420);
            this.dgvDesignation.TabIndex = 30;
            this.dgvDesignation.TabStop = false;
            this.dgvDesignation.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDesignation_CellClick);
            // 
            // slNo
            // 
            this.slNo.DataPropertyName = "SlNo";
            this.slNo.HeaderText = "Sl No";
            this.slNo.Name = "slNo";
            this.slNo.ReadOnly = true;
            this.slNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtDesignationName
            // 
            this.dgvtxtDesignationName.DataPropertyName = "designationName";
            this.dgvtxtDesignationName.HeaderText = "Designation";
            this.dgvtxtDesignationName.Name = "dgvtxtDesignationName";
            this.dgvtxtDesignationName.ReadOnly = true;
            this.dgvtxtDesignationName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvDescription
            // 
            this.dgvDescription.DataPropertyName = "description";
            this.dgvDescription.HeaderText = "Description";
            this.dgvDescription.Name = "dgvDescription";
            this.dgvDescription.ReadOnly = true;
            // 
            // dgvtxtDesignationId
            // 
            this.dgvtxtDesignationId.DataPropertyName = "designationId";
            this.dgvtxtDesignationId.HeaderText = "DesignationId";
            this.dgvtxtDesignationId.Name = "dgvtxtDesignationId";
            this.dgvtxtDesignationId.ReadOnly = true;
            this.dgvtxtDesignationId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtDesignationId.Visible = false;
            // 
            // txtDesignationName
            // 
            this.txtDesignationName.Location = new System.Drawing.Point(127, 11);
            this.txtDesignationName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDesignationName.Name = "txtDesignationName";
            this.txtDesignationName.Size = new System.Drawing.Size(272, 22);
            this.txtDesignationName.TabIndex = 17;
            // 
            // lblDesignationName
            // 
            this.lblDesignationName.AutoSize = true;
            this.lblDesignationName.BackColor = System.Drawing.Color.Transparent;
            this.lblDesignationName.ForeColor = System.Drawing.Color.Black;
            this.lblDesignationName.Location = new System.Drawing.Point(17, 16);
            this.lblDesignationName.Margin = new System.Windows.Forms.Padding(5);
            this.lblDesignationName.Name = "lblDesignationName";
            this.lblDesignationName.Size = new System.Drawing.Size(39, 14);
            this.lblDesignationName.TabIndex = 18;
            this.lblDesignationName.Text = "Name";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(127, 52);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDescription.MaxLength = 9;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(272, 22);
            this.txtDescription.TabIndex = 20;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblAdvanceAmount
            // 
            this.lblAdvanceAmount.AutoSize = true;
            this.lblAdvanceAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAdvanceAmount.ForeColor = System.Drawing.Color.Black;
            this.lblAdvanceAmount.Location = new System.Drawing.Point(17, 52);
            this.lblAdvanceAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblAdvanceAmount.Name = "lblAdvanceAmount";
            this.lblAdvanceAmount.Size = new System.Drawing.Size(69, 14);
            this.lblAdvanceAmount.TabIndex = 23;
            this.lblAdvanceAmount.Text = "Description";
            // 
            // frmDesignation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 575);
            this.Controls.Add(this.lblStar);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvDesignation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDesignationName);
            this.Controls.Add(this.lblAdvanceAmount);
            this.Controls.Add(this.lblDesignationName);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDesignation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Designation";
            this.Load += new System.EventHandler(this.frmDesignation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDesignation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvDesignation;
        private System.Windows.Forms.TextBox txtDesignationName;
        private System.Windows.Forms.Label lblDesignationName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAdvanceAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn slNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtDesignationId;
    }
}