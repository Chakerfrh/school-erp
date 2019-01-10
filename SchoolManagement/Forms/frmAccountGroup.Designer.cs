namespace SchoolManagement.Forms
{
    partial class frmAccountGroup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountGroup));
            this.gbxAccountGroup = new System.Windows.Forms.GroupBox();
            this.txtAccountSubGroup = new System.Windows.Forms.TextBox();
            this.lblGroupUnderMandatory = new System.Windows.Forms.Label();
            this.lblNatureMandatory = new System.Windows.Forms.Label();
            this.lblAccountNameMandatory = new System.Windows.Forms.Label();
            this.lblAccountGroupName = new System.Windows.Forms.Label();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.cmbAffects = new System.Windows.Forms.ComboBox();
            this.lblNature = new System.Windows.Forms.Label();
            this.lblAffectGrossProfit = new System.Windows.Forms.Label();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtAccountCode = new System.Windows.Forms.TextBox();
            this.lblGroupUnder = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbAccountGroup = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxAccountGroupSearch = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.dgvAccountGroup = new System.Windows.Forms.DataGridView();
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAccountGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtUnderGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAccountGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbGroupUnderSearch = new System.Windows.Forms.ComboBox();
            this.lblGroupUnderSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAccountGroupNameSearch = new System.Windows.Forms.Label();
            this.txtAccountGroupNameSearch = new System.Windows.Forms.TextBox();
            this.gbxAccountGroup.SuspendLayout();
            this.gbxAccountGroupSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAccountGroup
            // 
            this.gbxAccountGroup.Controls.Add(this.txtAccountSubGroup);
            this.gbxAccountGroup.Controls.Add(this.lblGroupUnderMandatory);
            this.gbxAccountGroup.Controls.Add(this.lblNatureMandatory);
            this.gbxAccountGroup.Controls.Add(this.lblAccountNameMandatory);
            this.gbxAccountGroup.Controls.Add(this.lblAccountGroupName);
            this.gbxAccountGroup.Controls.Add(this.txtAccountName);
            this.gbxAccountGroup.Controls.Add(this.cmbAffects);
            this.gbxAccountGroup.Controls.Add(this.lblNature);
            this.gbxAccountGroup.Controls.Add(this.lblAffectGrossProfit);
            this.gbxAccountGroup.Controls.Add(this.lblNarration);
            this.gbxAccountGroup.Controls.Add(this.txtAccountCode);
            this.gbxAccountGroup.Controls.Add(this.lblGroupUnder);
            this.gbxAccountGroup.Controls.Add(this.btnSave);
            this.gbxAccountGroup.Controls.Add(this.cmbAccountGroup);
            this.gbxAccountGroup.Controls.Add(this.btnClear);
            this.gbxAccountGroup.Controls.Add(this.btnClose);
            this.gbxAccountGroup.Location = new System.Drawing.Point(13, 13);
            this.gbxAccountGroup.Name = "gbxAccountGroup";
            this.gbxAccountGroup.Size = new System.Drawing.Size(771, 145);
            this.gbxAccountGroup.TabIndex = 131;
            this.gbxAccountGroup.TabStop = false;
            // 
            // txtAccountSubGroup
            // 
            this.txtAccountSubGroup.Location = new System.Drawing.Point(122, 77);
            this.txtAccountSubGroup.Name = "txtAccountSubGroup";
            this.txtAccountSubGroup.Size = new System.Drawing.Size(200, 22);
            this.txtAccountSubGroup.TabIndex = 129;
            // 
            // lblGroupUnderMandatory
            // 
            this.lblGroupUnderMandatory.AutoSize = true;
            this.lblGroupUnderMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblGroupUnderMandatory.Location = new System.Drawing.Point(326, 77);
            this.lblGroupUnderMandatory.Name = "lblGroupUnderMandatory";
            this.lblGroupUnderMandatory.Size = new System.Drawing.Size(13, 14);
            this.lblGroupUnderMandatory.TabIndex = 128;
            this.lblGroupUnderMandatory.Text = "*";
            // 
            // lblNatureMandatory
            // 
            this.lblNatureMandatory.AutoSize = true;
            this.lblNatureMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblNatureMandatory.Location = new System.Drawing.Point(326, 49);
            this.lblNatureMandatory.Name = "lblNatureMandatory";
            this.lblNatureMandatory.Size = new System.Drawing.Size(13, 14);
            this.lblNatureMandatory.TabIndex = 128;
            this.lblNatureMandatory.Text = "*";
            // 
            // lblAccountNameMandatory
            // 
            this.lblAccountNameMandatory.AutoSize = true;
            this.lblAccountNameMandatory.ForeColor = System.Drawing.Color.Red;
            this.lblAccountNameMandatory.Location = new System.Drawing.Point(326, 24);
            this.lblAccountNameMandatory.Name = "lblAccountNameMandatory";
            this.lblAccountNameMandatory.Size = new System.Drawing.Size(13, 14);
            this.lblAccountNameMandatory.TabIndex = 128;
            this.lblAccountNameMandatory.Text = "*";
            // 
            // lblAccountGroupName
            // 
            this.lblAccountGroupName.AutoSize = true;
            this.lblAccountGroupName.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountGroupName.ForeColor = System.Drawing.Color.Black;
            this.lblAccountGroupName.Location = new System.Drawing.Point(15, 24);
            this.lblAccountGroupName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountGroupName.Name = "lblAccountGroupName";
            this.lblAccountGroupName.Size = new System.Drawing.Size(84, 14);
            this.lblAccountGroupName.TabIndex = 109;
            this.lblAccountGroupName.Text = "Account Name";
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(122, 20);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(200, 22);
            this.txtAccountName.TabIndex = 0;
            // 
            // cmbAffects
            // 
            this.cmbAffects.FormattingEnabled = true;
            this.cmbAffects.Items.AddRange(new object[] {
            "Income Statement",
            "Balancesheet"});
            this.cmbAffects.Location = new System.Drawing.Point(557, 45);
            this.cmbAffects.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAffects.Name = "cmbAffects";
            this.cmbAffects.Size = new System.Drawing.Size(202, 22);
            this.cmbAffects.TabIndex = 3;
            // 
            // lblNature
            // 
            this.lblNature.AutoSize = true;
            this.lblNature.BackColor = System.Drawing.Color.Transparent;
            this.lblNature.ForeColor = System.Drawing.Color.Black;
            this.lblNature.Location = new System.Drawing.Point(15, 49);
            this.lblNature.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNature.Name = "lblNature";
            this.lblNature.Size = new System.Drawing.Size(85, 14);
            this.lblNature.TabIndex = 111;
            this.lblNature.Text = "Account Group";
            // 
            // lblAffectGrossProfit
            // 
            this.lblAffectGrossProfit.AutoSize = true;
            this.lblAffectGrossProfit.BackColor = System.Drawing.Color.Transparent;
            this.lblAffectGrossProfit.ForeColor = System.Drawing.Color.Black;
            this.lblAffectGrossProfit.Location = new System.Drawing.Point(446, 45);
            this.lblAffectGrossProfit.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAffectGrossProfit.Name = "lblAffectGrossProfit";
            this.lblAffectGrossProfit.Size = new System.Drawing.Size(43, 14);
            this.lblAffectGrossProfit.TabIndex = 127;
            this.lblAffectGrossProfit.Text = "Affects";
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.BackColor = System.Drawing.Color.Transparent;
            this.lblNarration.ForeColor = System.Drawing.Color.Black;
            this.lblNarration.Location = new System.Drawing.Point(446, 14);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(79, 14);
            this.lblNarration.TabIndex = 112;
            this.lblNarration.Text = "Account Code";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(557, 14);
            this.txtAccountCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAccountCode.MaxLength = 5000;
            this.txtAccountCode.Multiline = true;
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(200, 24);
            this.txtAccountCode.TabIndex = 4;
            // 
            // lblGroupUnder
            // 
            this.lblGroupUnder.AutoSize = true;
            this.lblGroupUnder.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupUnder.ForeColor = System.Drawing.Color.Black;
            this.lblGroupUnder.Location = new System.Drawing.Point(15, 77);
            this.lblGroupUnder.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGroupUnder.Name = "lblGroupUnder";
            this.lblGroupUnder.Size = new System.Drawing.Size(64, 14);
            this.lblGroupUnder.TabIndex = 125;
            this.lblGroupUnder.Text = "Sub-Group";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(449, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbAccountGroup
            // 
            this.cmbAccountGroup.FormattingEnabled = true;
            this.cmbAccountGroup.Items.AddRange(new object[] {
            "Current assets",
            "Long term assets",
            "Current liabilities",
            "Long term liabilities",
            "Income",
            "Overheads",
            "Equity",
            "Sales",
            "Cost of Sales"});
            this.cmbAccountGroup.Location = new System.Drawing.Point(122, 45);
            this.cmbAccountGroup.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbAccountGroup.Name = "cmbAccountGroup";
            this.cmbAccountGroup.Size = new System.Drawing.Size(200, 22);
            this.cmbAccountGroup.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(557, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(675, 94);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxAccountGroupSearch
            // 
            this.gbxAccountGroupSearch.BackColor = System.Drawing.Color.Transparent;
            this.gbxAccountGroupSearch.Controls.Add(this.groupBox2);
            this.gbxAccountGroupSearch.Controls.Add(this.lblSearch);
            this.gbxAccountGroupSearch.Controls.Add(this.dgvAccountGroup);
            this.gbxAccountGroupSearch.Controls.Add(this.cmbGroupUnderSearch);
            this.gbxAccountGroupSearch.Controls.Add(this.lblGroupUnderSearch);
            this.gbxAccountGroupSearch.Controls.Add(this.btnSearch);
            this.gbxAccountGroupSearch.Controls.Add(this.lblAccountGroupNameSearch);
            this.gbxAccountGroupSearch.Controls.Add(this.txtAccountGroupNameSearch);
            this.gbxAccountGroupSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAccountGroupSearch.ForeColor = System.Drawing.Color.Black;
            this.gbxAccountGroupSearch.Location = new System.Drawing.Point(13, 177);
            this.gbxAccountGroupSearch.Name = "gbxAccountGroupSearch";
            this.gbxAccountGroupSearch.Size = new System.Drawing.Size(771, 458);
            this.gbxAccountGroupSearch.TabIndex = 132;
            this.gbxAccountGroupSearch.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(16, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 1);
            this.groupBox2.TabIndex = 124;
            this.groupBox2.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.ForeColor = System.Drawing.Color.Maroon;
            this.lblSearch.Location = new System.Drawing.Point(13, 8);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 15);
            this.lblSearch.TabIndex = 123;
            this.lblSearch.Text = "Search";
            // 
            // dgvAccountGroup
            // 
            this.dgvAccountGroup.AllowUserToAddRows = false;
            this.dgvAccountGroup.AllowUserToDeleteRows = false;
            this.dgvAccountGroup.AllowUserToResizeColumns = false;
            this.dgvAccountGroup.AllowUserToResizeRows = false;
            this.dgvAccountGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccountGroup.BackgroundColor = System.Drawing.Color.White;
            this.dgvAccountGroup.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountGroup.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAccountGroup.ColumnHeadersHeight = 25;
            this.dgvAccountGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAccountGroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvtxtSlNo,
            this.dgvtxtAccountGroupId,
            this.dgvtxtGroupName,
            this.dgvtxtUnderGroup,
            this.dgvtxtAccountGroup});
            this.dgvAccountGroup.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAccountGroup.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAccountGroup.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvAccountGroup.EnableHeadersVisualStyles = false;
            this.dgvAccountGroup.GridColor = System.Drawing.Color.DimGray;
            this.dgvAccountGroup.Location = new System.Drawing.Point(15, 70);
            this.dgvAccountGroup.Name = "dgvAccountGroup";
            this.dgvAccountGroup.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAccountGroup.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAccountGroup.RowHeadersVisible = false;
            this.dgvAccountGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccountGroup.ShowCellToolTips = false;
            this.dgvAccountGroup.Size = new System.Drawing.Size(742, 373);
            this.dgvAccountGroup.TabIndex = 3;
            this.dgvAccountGroup.TabStop = false;
            this.dgvAccountGroup.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccountGroup_CellDoubleClick);
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "Sl No";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.ReadOnly = true;
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAccountGroupId
            // 
            this.dgvtxtAccountGroupId.DataPropertyName = "accountId";
            this.dgvtxtAccountGroupId.HeaderText = "AccountGroupId";
            this.dgvtxtAccountGroupId.Name = "dgvtxtAccountGroupId";
            this.dgvtxtAccountGroupId.ReadOnly = true;
            this.dgvtxtAccountGroupId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAccountGroupId.Visible = false;
            // 
            // dgvtxtGroupName
            // 
            this.dgvtxtGroupName.DataPropertyName = "accountName";
            this.dgvtxtGroupName.HeaderText = "Account Name";
            this.dgvtxtGroupName.Name = "dgvtxtGroupName";
            this.dgvtxtGroupName.ReadOnly = true;
            this.dgvtxtGroupName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtUnderGroup
            // 
            this.dgvtxtUnderGroup.DataPropertyName = "accountSubGroup";
            this.dgvtxtUnderGroup.HeaderText = "Sub-Group";
            this.dgvtxtUnderGroup.Name = "dgvtxtUnderGroup";
            this.dgvtxtUnderGroup.ReadOnly = true;
            this.dgvtxtUnderGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtAccountGroup
            // 
            this.dgvtxtAccountGroup.DataPropertyName = "accountGroup";
            this.dgvtxtAccountGroup.HeaderText = "AccountGroup";
            this.dgvtxtAccountGroup.Name = "dgvtxtAccountGroup";
            this.dgvtxtAccountGroup.ReadOnly = true;
            this.dgvtxtAccountGroup.Visible = false;
            // 
            // cmbGroupUnderSearch
            // 
            this.cmbGroupUnderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGroupUnderSearch.FormattingEnabled = true;
            this.cmbGroupUnderSearch.Items.AddRange(new object[] {
            "All",
            "Current assets",
            "Long term assets",
            "Current liabilities",
            "Long term liabilities",
            "Income",
            "Overheads",
            "Equity",
            "Sales",
            "Cost of Sale"});
            this.cmbGroupUnderSearch.Location = new System.Drawing.Point(449, 39);
            this.cmbGroupUnderSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.cmbGroupUnderSearch.Name = "cmbGroupUnderSearch";
            this.cmbGroupUnderSearch.Size = new System.Drawing.Size(192, 21);
            this.cmbGroupUnderSearch.TabIndex = 1;
            // 
            // lblGroupUnderSearch
            // 
            this.lblGroupUnderSearch.AutoSize = true;
            this.lblGroupUnderSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblGroupUnderSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupUnderSearch.ForeColor = System.Drawing.Color.Black;
            this.lblGroupUnderSearch.Location = new System.Drawing.Point(360, 42);
            this.lblGroupUnderSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblGroupUnderSearch.Name = "lblGroupUnderSearch";
            this.lblGroupUnderSearch.Size = new System.Drawing.Size(79, 13);
            this.lblGroupUnderSearch.TabIndex = 122;
            this.lblGroupUnderSearch.Text = "Account Group";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DimGray;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(672, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(85, 21);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAccountGroupNameSearch
            // 
            this.lblAccountGroupNameSearch.AutoSize = true;
            this.lblAccountGroupNameSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblAccountGroupNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountGroupNameSearch.ForeColor = System.Drawing.Color.Black;
            this.lblAccountGroupNameSearch.Location = new System.Drawing.Point(14, 41);
            this.lblAccountGroupNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAccountGroupNameSearch.Name = "lblAccountGroupNameSearch";
            this.lblAccountGroupNameSearch.Size = new System.Drawing.Size(81, 13);
            this.lblAccountGroupNameSearch.TabIndex = 120;
            this.lblAccountGroupNameSearch.Text = "Account Name ";
            // 
            // txtAccountGroupNameSearch
            // 
            this.txtAccountGroupNameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountGroupNameSearch.Location = new System.Drawing.Point(122, 39);
            this.txtAccountGroupNameSearch.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtAccountGroupNameSearch.Name = "txtAccountGroupNameSearch";
            this.txtAccountGroupNameSearch.Size = new System.Drawing.Size(215, 20);
            this.txtAccountGroupNameSearch.TabIndex = 0;
            this.txtAccountGroupNameSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccountGroupNameSearch_KeyDown);
            // 
            // frmAccountGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(797, 638);
            this.Controls.Add(this.gbxAccountGroupSearch);
            this.Controls.Add(this.gbxAccountGroup);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountGroup";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Group";
            this.Load += new System.EventHandler(this.frmAccountGroup_Load);
            this.gbxAccountGroup.ResumeLayout(false);
            this.gbxAccountGroup.PerformLayout();
            this.gbxAccountGroupSearch.ResumeLayout(false);
            this.gbxAccountGroupSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountGroup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAccountGroup;
        private System.Windows.Forms.Label lblGroupUnderMandatory;
        private System.Windows.Forms.Label lblNatureMandatory;
        private System.Windows.Forms.Label lblAccountNameMandatory;
        private System.Windows.Forms.Label lblAccountGroupName;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.ComboBox cmbAffects;
        private System.Windows.Forms.Label lblNature;
        private System.Windows.Forms.Label lblAffectGrossProfit;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtAccountCode;
        private System.Windows.Forms.Label lblGroupUnder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbAccountGroup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxAccountGroupSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ComboBox cmbGroupUnderSearch;
        private System.Windows.Forms.Label lblGroupUnderSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblAccountGroupNameSearch;
        private System.Windows.Forms.TextBox txtAccountGroupNameSearch;
        private System.Windows.Forms.TextBox txtAccountSubGroup;
        private System.Windows.Forms.DataGridView dgvAccountGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtUnderGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAccountGroup;
    }
}