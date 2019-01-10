namespace SchoolManagement.Forms
{
    partial class frmFees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFees));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFeeType = new System.Windows.Forms.TextBox();
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvFeeItem = new System.Windows.Forms.DataGridView();
            this.dgvSlno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvterm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvctive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeeItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeItem)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFeeType);
            this.groupBox1.Controls.Add(this.cbxActive);
            this.groupBox1.Controls.Add(this.cmbClass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cmbTerm);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(23, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(780, 245);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fees Settings";
            // 
            // txtFeeType
            // 
            this.txtFeeType.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtFeeType.Location = new System.Drawing.Point(183, 47);
            this.txtFeeType.Name = "txtFeeType";
            this.txtFeeType.Size = new System.Drawing.Size(202, 22);
            this.txtFeeType.TabIndex = 1242;
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.ForeColor = System.Drawing.Color.Black;
            this.cbxActive.Location = new System.Drawing.Point(462, 49);
            this.cbxActive.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(57, 18);
            this.cbxActive.TabIndex = 1241;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(183, 130);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(202, 22);
            this.cmbClass.TabIndex = 1238;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.Location = new System.Drawing.Point(24, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 1237;
            this.label3.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtAmount.Location = new System.Drawing.Point(183, 176);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(202, 22);
            this.txtAmount.TabIndex = 1236;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(660, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 21);
            this.button3.TabIndex = 1235;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // cmbTerm
            // 
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(183, 82);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(202, 22);
            this.cmbTerm.TabIndex = 1233;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Gray;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Transparent;
            this.btnSave.Location = new System.Drawing.Point(499, 198);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 21);
            this.btnSave.TabIndex = 1225;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.Location = new System.Drawing.Point(24, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 14);
            this.label2.TabIndex = 22;
            this.label2.Text = "Fee Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F);
            this.label7.Location = new System.Drawing.Point(24, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 14);
            this.label7.TabIndex = 21;
            this.label7.Text = "Term";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvFeeItem);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(23, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 238);
            this.groupBox2.TabIndex = 1236;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            // 
            // dgvFeeItem
            // 
            this.dgvFeeItem.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeeItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeeItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSlno,
            this.dgvfee,
            this.dgvterm,
            this.dgvClass,
            this.dgvActive,
            this.dgvctive,
            this.dgvFeeItemId});
            this.dgvFeeItem.Location = new System.Drawing.Point(11, 33);
            this.dgvFeeItem.Name = "dgvFeeItem";
            this.dgvFeeItem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeeItem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFeeItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFeeItem.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvFeeItem.Size = new System.Drawing.Size(763, 181);
            this.dgvFeeItem.TabIndex = 0;
            this.dgvFeeItem.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeeItem_CellDoubleClick);
            // 
            // dgvSlno
            // 
            this.dgvSlno.DataPropertyName = "SL.NO";
            this.dgvSlno.HeaderText = "SL.NO";
            this.dgvSlno.Name = "dgvSlno";
            // 
            // dgvfee
            // 
            this.dgvfee.DataPropertyName = "feeTitle";
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvfee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvfee.HeaderText = "Fee Type";
            this.dgvfee.Name = "dgvfee";
            this.dgvfee.Width = 120;
            // 
            // dgvterm
            // 
            this.dgvterm.DataPropertyName = "term_name";
            this.dgvterm.HeaderText = "Term";
            this.dgvterm.Name = "dgvterm";
            this.dgvterm.Width = 150;
            // 
            // dgvClass
            // 
            this.dgvClass.DataPropertyName = "ClassNo";
            this.dgvClass.HeaderText = "Class";
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.Width = 150;
            // 
            // dgvActive
            // 
            this.dgvActive.DataPropertyName = "feeAmount";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvActive.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvActive.HeaderText = "Amount";
            this.dgvActive.Name = "dgvActive";
            this.dgvActive.Width = 150;
            // 
            // dgvctive
            // 
            this.dgvctive.DataPropertyName = "active";
            this.dgvctive.HeaderText = "Active";
            this.dgvctive.Name = "dgvctive";
            this.dgvctive.Width = 50;
            // 
            // dgvFeeItemId
            // 
            this.dgvFeeItemId.DataPropertyName = "feeItemId";
            this.dgvFeeItemId.HeaderText = "FeeItemId";
            this.dgvFeeItemId.Name = "dgvFeeItemId";
            this.dgvFeeItemId.Visible = false;
            // 
            // frmFees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Fees";
            this.Load += new System.EventHandler(this.frmFees_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.DataGridView dgvFeeItem;
        private System.Windows.Forms.TextBox txtFeeType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSlno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvterm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvctive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeeItemId;
    }
}