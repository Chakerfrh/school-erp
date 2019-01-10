namespace SchoolManagement.Forms
{
    partial class frmLedgerPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedgerPopup));
            this.dgvLedgerPopup = new System.Windows.Forms.DataGridView();
            this.txtAdminNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClassNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerPopup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLedgerPopup
            // 
            this.dgvLedgerPopup.AllowUserToAddRows = false;
            this.dgvLedgerPopup.AllowUserToDeleteRows = false;
            this.dgvLedgerPopup.AllowUserToResizeRows = false;
            this.dgvLedgerPopup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLedgerPopup.BackgroundColor = System.Drawing.Color.White;
            this.dgvLedgerPopup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLedgerPopup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLedgerPopup.ColumnHeadersHeight = 25;
            this.dgvLedgerPopup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLedgerPopup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtOpeningBalance,
            this.dgvtxtLedgerName,
            this.dgvtxtClassNo,
            this.dgvtxtLedgerId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLedgerPopup.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLedgerPopup.EnableHeadersVisualStyles = false;
            this.dgvLedgerPopup.GridColor = System.Drawing.Color.DimGray;
            this.dgvLedgerPopup.Location = new System.Drawing.Point(18, 53);
            this.dgvLedgerPopup.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.dgvLedgerPopup.MultiSelect = false;
            this.dgvLedgerPopup.Name = "dgvLedgerPopup";
            this.dgvLedgerPopup.RowHeadersVisible = false;
            this.dgvLedgerPopup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLedgerPopup.Size = new System.Drawing.Size(619, 251);
            this.dgvLedgerPopup.TabIndex = 6;
            this.dgvLedgerPopup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLedgerPopup_CellDoubleClick);
            // 
            // txtAdminNumber
            // 
            this.txtAdminNumber.Location = new System.Drawing.Point(136, 7);
            this.txtAdminNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtAdminNumber.Name = "txtAdminNumber";
            this.txtAdminNumber.Size = new System.Drawing.Size(200, 22);
            this.txtAdminNumber.TabIndex = 17;
            this.txtAdminNumber.TextChanged += new System.EventHandler(this.txtAdminNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 14);
            this.label1.TabIndex = 18;
            this.label1.Text = "Admission Number";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(435, 7);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(5);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(364, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Last Name";
            // 
            // dgvtxtOpeningBalance
            // 
            this.dgvtxtOpeningBalance.DataPropertyName = "adminNumber";
            this.dgvtxtOpeningBalance.HeaderText = "Admin Number";
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.ReadOnly = true;
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedgerName
            // 
            this.dgvtxtLedgerName.DataPropertyName = "OtherName";
            this.dgvtxtLedgerName.HeaderText = "Last Name";
            this.dgvtxtLedgerName.Name = "dgvtxtLedgerName";
            this.dgvtxtLedgerName.ReadOnly = true;
            this.dgvtxtLedgerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtClassNo
            // 
            this.dgvtxtClassNo.DataPropertyName = "classNo";
            this.dgvtxtClassNo.HeaderText = "Class No";
            this.dgvtxtClassNo.Name = "dgvtxtClassNo";
            this.dgvtxtClassNo.ReadOnly = true;
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "LedgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // frmLedgerPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 324);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtAdminNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLedgerPopup);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLedgerPopup";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Student";
            this.Load += new System.EventHandler(this.frmLedgerPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLedgerPopup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLedgerPopup;
        private System.Windows.Forms.TextBox txtAdminNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClassNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
    }
}