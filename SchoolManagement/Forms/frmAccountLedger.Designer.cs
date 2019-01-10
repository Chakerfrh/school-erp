namespace SchoolManagement.Forms
{
    partial class frmAccountLedger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountLedger));
            this.tbctrlLedger = new System.Windows.Forms.TabControl();
            this.tbMainDetails = new System.Windows.Forms.TabPage();
            this.chkactive = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.btnAccountGroupAdd = new System.Windows.Forms.Button();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.txtLedgerName = new System.Windows.Forms.TextBox();
            this.gbxDetails = new System.Windows.Forms.GroupBox();
            this.txtBranchCode = new System.Windows.Forms.TextBox();
            this.lblBranchCode = new System.Windows.Forms.Label();
            this.txtBranchName = new System.Windows.Forms.TextBox();
            this.lblBranchName = new System.Windows.Forms.Label();
            this.txtAcNo = new System.Windows.Forms.TextBox();
            this.lblACNo = new System.Windows.Forms.Label();
            this.lblNarration = new System.Windows.Forms.Label();
            this.cmbOpeningBalanceCrOrDr = new System.Windows.Forms.ComboBox();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAccountLedger = new System.Windows.Forms.DataGridView();
            this.dgvtxtLedgerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtOpeningBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtCreditOrDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtLedgerNameSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblLedgerNameSearch = new System.Windows.Forms.Label();
            this.cmbGroupSearch = new System.Windows.Forms.ComboBox();
            this.lblGroupSearch = new System.Windows.Forms.Label();
            this.tbctrlLedger.SuspendLayout();
            this.tbMainDetails.SuspendLayout();
            this.gbxDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).BeginInit();
            this.SuspendLayout();
            // 
            // tbctrlLedger
            // 
            this.tbctrlLedger.Controls.Add(this.tbMainDetails);
            this.tbctrlLedger.Location = new System.Drawing.Point(38, 39);
            this.tbctrlLedger.Name = "tbctrlLedger";
            this.tbctrlLedger.SelectedIndex = 0;
            this.tbctrlLedger.Size = new System.Drawing.Size(724, 262);
            this.tbctrlLedger.TabIndex = 1;
            // 
            // tbMainDetails
            // 
            this.tbMainDetails.BackColor = System.Drawing.Color.Gainsboro;
            this.tbMainDetails.Controls.Add(this.chkactive);
            this.tbMainDetails.Controls.Add(this.label1);
            this.tbMainDetails.Controls.Add(this.lblSalaryTypeValidator);
            this.tbMainDetails.Controls.Add(this.btnAccountGroupAdd);
            this.tbMainDetails.Controls.Add(this.txtOpeningBalance);
            this.tbMainDetails.Controls.Add(this.txtNarration);
            this.tbMainDetails.Controls.Add(this.txtLedgerName);
            this.tbMainDetails.Controls.Add(this.gbxDetails);
            this.tbMainDetails.Controls.Add(this.lblNarration);
            this.tbMainDetails.Controls.Add(this.cmbOpeningBalanceCrOrDr);
            this.tbMainDetails.Controls.Add(this.lblOpeningBalance);
            this.tbMainDetails.Controls.Add(this.cmbGroup);
            this.tbMainDetails.Controls.Add(this.lblGroup);
            this.tbMainDetails.Controls.Add(this.lblName);
            this.tbMainDetails.Location = new System.Drawing.Point(4, 23);
            this.tbMainDetails.Margin = new System.Windows.Forms.Padding(5);
            this.tbMainDetails.Name = "tbMainDetails";
            this.tbMainDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tbMainDetails.Size = new System.Drawing.Size(716, 235);
            this.tbMainDetails.TabIndex = 0;
            this.tbMainDetails.Text = "Main Details";
            // 
            // chkactive
            // 
            this.chkactive.AutoSize = true;
            this.chkactive.Location = new System.Drawing.Point(14, 144);
            this.chkactive.Name = "chkactive";
            this.chkactive.Size = new System.Drawing.Size(57, 18);
            this.chkactive.TabIndex = 176;
            this.chkactive.Text = "Active";
            this.chkactive.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(328, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "*";
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(328, 20);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(13, 14);
            this.lblSalaryTypeValidator.TabIndex = 175;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // btnAccountGroupAdd
            // 
            this.btnAccountGroupAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAccountGroupAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccountGroupAdd.FlatAppearance.BorderSize = 0;
            this.btnAccountGroupAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccountGroupAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountGroupAdd.ForeColor = System.Drawing.Color.White;
            this.btnAccountGroupAdd.Location = new System.Drawing.Point(344, 40);
            this.btnAccountGroupAdd.Name = "btnAccountGroupAdd";
            this.btnAccountGroupAdd.Size = new System.Drawing.Size(20, 20);
            this.btnAccountGroupAdd.TabIndex = 4;
            this.btnAccountGroupAdd.Text = "+";
            this.btnAccountGroupAdd.UseVisualStyleBackColor = false;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(120, 67);
            this.txtOpeningBalance.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtOpeningBalance.MaxLength = 13;
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(146, 22);
            this.txtOpeningBalance.TabIndex = 2;
            this.txtOpeningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(120, 92);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtNarration.MaxLength = 5000;
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 70);
            this.txtNarration.TabIndex = 4;
            // 
            // txtLedgerName
            // 
            this.txtLedgerName.Location = new System.Drawing.Point(120, 16);
            this.txtLedgerName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLedgerName.Name = "txtLedgerName";
            this.txtLedgerName.Size = new System.Drawing.Size(200, 22);
            this.txtLedgerName.TabIndex = 0;
            // 
            // gbxDetails
            // 
            this.gbxDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbxDetails.Controls.Add(this.txtBranchCode);
            this.gbxDetails.Controls.Add(this.lblBranchCode);
            this.gbxDetails.Controls.Add(this.txtBranchName);
            this.gbxDetails.Controls.Add(this.lblBranchName);
            this.gbxDetails.Controls.Add(this.txtAcNo);
            this.gbxDetails.Controls.Add(this.lblACNo);
            this.gbxDetails.ForeColor = System.Drawing.Color.Black;
            this.gbxDetails.Location = new System.Drawing.Point(374, 16);
            this.gbxDetails.Name = "gbxDetails";
            this.gbxDetails.Size = new System.Drawing.Size(324, 146);
            this.gbxDetails.TabIndex = 6;
            this.gbxDetails.TabStop = false;
            this.gbxDetails.Text = "Details";
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(105, 92);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtBranchCode.MaxLength = 18;
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Size = new System.Drawing.Size(200, 22);
            this.txtBranchCode.TabIndex = 2;
            // 
            // lblBranchCode
            // 
            this.lblBranchCode.AutoSize = true;
            this.lblBranchCode.ForeColor = System.Drawing.Color.Black;
            this.lblBranchCode.Location = new System.Drawing.Point(17, 95);
            this.lblBranchCode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBranchCode.Name = "lblBranchCode";
            this.lblBranchCode.Size = new System.Drawing.Size(74, 14);
            this.lblBranchCode.TabIndex = 149;
            this.lblBranchCode.Text = "Branch Code";
            // 
            // txtBranchName
            // 
            this.txtBranchName.Location = new System.Drawing.Point(105, 67);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Size = new System.Drawing.Size(200, 22);
            this.txtBranchName.TabIndex = 1;
            // 
            // lblBranchName
            // 
            this.lblBranchName.AutoSize = true;
            this.lblBranchName.ForeColor = System.Drawing.Color.Black;
            this.lblBranchName.Location = new System.Drawing.Point(17, 71);
            this.lblBranchName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblBranchName.Name = "lblBranchName";
            this.lblBranchName.Size = new System.Drawing.Size(79, 14);
            this.lblBranchName.TabIndex = 147;
            this.lblBranchName.Text = "Branch Name";
            // 
            // txtAcNo
            // 
            this.txtAcNo.Location = new System.Drawing.Point(105, 42);
            this.txtAcNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtAcNo.MaxLength = 18;
            this.txtAcNo.Name = "txtAcNo";
            this.txtAcNo.Size = new System.Drawing.Size(200, 22);
            this.txtAcNo.TabIndex = 0;
            // 
            // lblACNo
            // 
            this.lblACNo.AutoSize = true;
            this.lblACNo.ForeColor = System.Drawing.Color.Black;
            this.lblACNo.Location = new System.Drawing.Point(17, 45);
            this.lblACNo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblACNo.Name = "lblACNo";
            this.lblACNo.Size = new System.Drawing.Size(48, 14);
            this.lblACNo.TabIndex = 145;
            this.lblACNo.Text = "Ac / No.";
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.BackColor = System.Drawing.Color.Transparent;
            this.lblNarration.ForeColor = System.Drawing.Color.Black;
            this.lblNarration.Location = new System.Drawing.Point(10, 92);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(58, 14);
            this.lblNarration.TabIndex = 161;
            this.lblNarration.Text = "Narration";
            // 
            // cmbOpeningBalanceCrOrDr
            // 
            this.cmbOpeningBalanceCrOrDr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpeningBalanceCrOrDr.FormattingEnabled = true;
            this.cmbOpeningBalanceCrOrDr.Items.AddRange(new object[] {
            "Dr",
            "Cr"});
            this.cmbOpeningBalanceCrOrDr.Location = new System.Drawing.Point(270, 67);
            this.cmbOpeningBalanceCrOrDr.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbOpeningBalanceCrOrDr.Name = "cmbOpeningBalanceCrOrDr";
            this.cmbOpeningBalanceCrOrDr.Size = new System.Drawing.Size(51, 22);
            this.cmbOpeningBalanceCrOrDr.TabIndex = 3;
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.BackColor = System.Drawing.Color.Transparent;
            this.lblOpeningBalance.ForeColor = System.Drawing.Color.Black;
            this.lblOpeningBalance.Location = new System.Drawing.Point(11, 71);
            this.lblOpeningBalance.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(100, 14);
            this.lblOpeningBalance.TabIndex = 145;
            this.lblOpeningBalance.Text = "Opening Balance";
            // 
            // cmbGroup
            // 
            this.cmbGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(120, 41);
            this.cmbGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(200, 22);
            this.cmbGroup.TabIndex = 1;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.BackColor = System.Drawing.Color.Transparent;
            this.lblGroup.ForeColor = System.Drawing.Color.Black;
            this.lblGroup.Location = new System.Drawing.Point(11, 45);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(40, 14);
            this.lblGroup.TabIndex = 139;
            this.lblGroup.Text = "Group";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(11, 20);
            this.lblName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 14);
            this.lblName.TabIndex = 136;
            this.lblName.Text = "Name";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(18, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 334);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(659, 294);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(540, 294);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(431, 294);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvAccountLedger);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtLedgerNameSearch);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.lblLedgerNameSearch);
            this.groupBox2.Controls.Add(this.cmbGroupSearch);
            this.groupBox2.Controls.Add(this.lblGroupSearch);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox2.Location = new System.Drawing.Point(18, 362);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(764, 225);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "     Search";
            // 
            // dgvAccountLedger
            // 
            this.dgvAccountLedger.AllowUserToAddRows = false;
            this.dgvAccountLedger.AllowUserToDeleteRows = false;
            this.dgvAccountLedger.AllowUserToResizeColumns = false;
            this.dgvAccountLedger.AllowUserToResizeRows = false;
            this.dgvAccountLedger.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountLedger.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountLedger.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountLedger.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountLedger.ColumnHeadersHeight = 25;
            this.dgvAccountLedger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountLedger.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtLedgerId,
            this.dgvtxtSlNo,
            this.dgvtxtLedger,
            this.dgvtxtGroup,
            this.dgvtxtOpeningBalance,
            this.dgvtxtCreditOrDebit});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountLedger.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccountLedger.EnableHeadersVisualStyles = false;
            this.dgvAccountLedger.GridColor = System.Drawing.Color.DimGray;
            this.dgvAccountLedger.Location = new System.Drawing.Point(20, 59);
            this.dgvAccountLedger.MultiSelect = false;
            this.dgvAccountLedger.Name = "dgvAccountLedger";
            this.dgvAccountLedger.ReadOnly = true;
            this.dgvAccountLedger.RowHeadersVisible = false;
            this.dgvAccountLedger.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountLedger.Size = new System.Drawing.Size(724, 153);
            this.dgvAccountLedger.TabIndex = 173;
            this.dgvAccountLedger.TabStop = false;
            this.dgvAccountLedger.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountLedger_CellDoubleClick);
            // 
            // dgvtxtLedgerId
            // 
            this.dgvtxtLedgerId.DataPropertyName = "ledgerId";
            this.dgvtxtLedgerId.HeaderText = "LedgerId";
            this.dgvtxtLedgerId.Name = "dgvtxtLedgerId";
            this.dgvtxtLedgerId.ReadOnly = true;
            this.dgvtxtLedgerId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerId.Visible = false;
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtLedger
            // 
            this.dgvtxtLedger.DataPropertyName = "ledgerName";
            this.dgvtxtLedger.HeaderText = "Ledger";
            this.dgvtxtLedger.Name = "dgvtxtLedger";
            this.dgvtxtLedger.ReadOnly = true;
            this.dgvtxtLedger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtGroup
            // 
            this.dgvtxtGroup.DataPropertyName = "accountName";
            this.dgvtxtGroup.HeaderText = "Group";
            this.dgvtxtGroup.Name = "dgvtxtGroup";
            this.dgvtxtGroup.ReadOnly = true;
            this.dgvtxtGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtOpeningBalance
            // 
            this.dgvtxtOpeningBalance.DataPropertyName = "openingBalance";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dgvtxtOpeningBalance.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtOpeningBalance.HeaderText = "Opening Balance";
            this.dgvtxtOpeningBalance.Name = "dgvtxtOpeningBalance";
            this.dgvtxtOpeningBalance.ReadOnly = true;
            this.dgvtxtOpeningBalance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtCreditOrDebit
            // 
            this.dgvtxtCreditOrDebit.DataPropertyName = "crOrDr";
            this.dgvtxtCreditOrDebit.HeaderText = "Cr/Dr";
            this.dgvtxtCreditOrDebit.Name = "dgvtxtCreditOrDebit";
            this.dgvtxtCreditOrDebit.ReadOnly = true;
            this.dgvtxtCreditOrDebit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(24, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(65, 1);
            this.groupBox3.TabIndex = 172;
            this.groupBox3.TabStop = false;
            // 
            // txtLedgerNameSearch
            // 
            this.txtLedgerNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLedgerNameSearch.ForeColor = System.Drawing.Color.Black;
            this.txtLedgerNameSearch.Location = new System.Drawing.Point(141, 23);
            this.txtLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.txtLedgerNameSearch.Name = "txtLedgerNameSearch";
            this.txtLedgerNameSearch.Size = new System.Drawing.Size(231, 20);
            this.txtLedgerNameSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(659, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblLedgerNameSearch
            // 
            this.lblLedgerNameSearch.AutoSize = true;
            this.lblLedgerNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLedgerNameSearch.ForeColor = System.Drawing.Color.Black;
            this.lblLedgerNameSearch.Location = new System.Drawing.Point(35, 27);
            this.lblLedgerNameSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblLedgerNameSearch.Name = "lblLedgerNameSearch";
            this.lblLedgerNameSearch.Size = new System.Drawing.Size(41, 13);
            this.lblLedgerNameSearch.TabIndex = 171;
            this.lblLedgerNameSearch.Text = "Name  ";
            // 
            // cmbGroupSearch
            // 
            this.cmbGroupSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGroupSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupSearch.ForeColor = System.Drawing.Color.Black;
            this.cmbGroupSearch.FormattingEnabled = true;
            this.cmbGroupSearch.Location = new System.Drawing.Point(431, 22);
            this.cmbGroupSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.cmbGroupSearch.Name = "cmbGroupSearch";
            this.cmbGroupSearch.Size = new System.Drawing.Size(224, 21);
            this.cmbGroupSearch.TabIndex = 1;
            // 
            // lblGroupSearch
            // 
            this.lblGroupSearch.AutoSize = true;
            this.lblGroupSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupSearch.ForeColor = System.Drawing.Color.Black;
            this.lblGroupSearch.Location = new System.Drawing.Point(383, 27);
            this.lblGroupSearch.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblGroupSearch.Name = "lblGroupSearch";
            this.lblGroupSearch.Size = new System.Drawing.Size(42, 13);
            this.lblGroupSearch.TabIndex = 169;
            this.lblGroupSearch.Text = "Group  ";
            // 
            // frmAccountLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbctrlLedger);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountLedger";
            this.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Ledger";
            this.Load += new System.EventHandler(this.frmAccountLedger_Load);
            this.tbctrlLedger.ResumeLayout(false);
            this.tbMainDetails.ResumeLayout(false);
            this.tbMainDetails.PerformLayout();
            this.gbxDetails.ResumeLayout(false);
            this.gbxDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountLedger)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbctrlLedger;
        private System.Windows.Forms.TabPage tbMainDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.Button btnAccountGroupAdd;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.TextBox txtLedgerName;
        private System.Windows.Forms.GroupBox gbxDetails;
        private System.Windows.Forms.TextBox txtBranchCode;
        private System.Windows.Forms.Label lblBranchCode;
        private System.Windows.Forms.TextBox txtBranchName;
        private System.Windows.Forms.Label lblBranchName;
        private System.Windows.Forms.TextBox txtAcNo;
        private System.Windows.Forms.Label lblACNo;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.ComboBox cmbOpeningBalanceCrOrDr;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAccountLedger;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtLedgerNameSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblLedgerNameSearch;
        private System.Windows.Forms.ComboBox cmbGroupSearch;
        private System.Windows.Forms.Label lblGroupSearch;
        private System.Windows.Forms.CheckBox chkactive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtOpeningBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtCreditOrDebit;
    }
}