namespace SchoolManagement.Forms
{
    partial class frmPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.dgvtxtSlNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtLedgerPostingId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpaymentMasterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtpaymentDetailsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbAccountLedger = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvbtnAgainst = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbCurrency = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.cbxPrintafterSave = new System.Windows.Forms.CheckBox();
            this.lblNarration = new System.Windows.Forms.Label();
            this.txtNarration = new System.Windows.Forms.TextBox();
            this.lnklblRemove = new System.Windows.Forms.LinkLabel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSalaryTypeValidator = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnLedgerAdd = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbBankorCash = new System.Windows.Forms.ComboBox();
            this.lblBankorCash = new System.Windows.Forms.Label();
            this.lblVoucheNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dgvPayment = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbledger = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvbtnAgainsth = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvtxtSlNo
            // 
            this.dgvtxtSlNo.DataPropertyName = "SL.NO";
            this.dgvtxtSlNo.HeaderText = "Sl No";
            this.dgvtxtSlNo.Name = "dgvtxtSlNo";
            this.dgvtxtSlNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtSlNo.Width = 103;
            // 
            // dgvtxtLedgerPostingId
            // 
            this.dgvtxtLedgerPostingId.DataPropertyName = "ledgerPostingId";
            this.dgvtxtLedgerPostingId.HeaderText = "LedgerPostingId";
            this.dgvtxtLedgerPostingId.Name = "dgvtxtLedgerPostingId";
            this.dgvtxtLedgerPostingId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtLedgerPostingId.Visible = false;
            // 
            // dgvtxtpaymentMasterId
            // 
            this.dgvtxtpaymentMasterId.DataPropertyName = "paymentMasterId";
            dataGridViewCellStyle1.NullValue = "0";
            this.dgvtxtpaymentMasterId.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtxtpaymentMasterId.HeaderText = "paymentMasterId";
            this.dgvtxtpaymentMasterId.Name = "dgvtxtpaymentMasterId";
            this.dgvtxtpaymentMasterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpaymentMasterId.Visible = false;
            // 
            // dgvtxtpaymentDetailsId
            // 
            this.dgvtxtpaymentDetailsId.DataPropertyName = "paymentDetailsid";
            dataGridViewCellStyle2.NullValue = "0";
            this.dgvtxtpaymentDetailsId.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvtxtpaymentDetailsId.HeaderText = "paymentDetailsId";
            this.dgvtxtpaymentDetailsId.Name = "dgvtxtpaymentDetailsId";
            this.dgvtxtpaymentDetailsId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtpaymentDetailsId.Visible = false;
            // 
            // dgvcmbAccountLedger
            // 
            this.dgvcmbAccountLedger.DataPropertyName = "ledgerId";
            this.dgvcmbAccountLedger.HeaderText = "Account Ledger";
            this.dgvcmbAccountLedger.Name = "dgvcmbAccountLedger";
            this.dgvcmbAccountLedger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbAccountLedger.Width = 103;
            // 
            // dgvbtnAgainst
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "Against";
            this.dgvbtnAgainst.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvbtnAgainst.HeaderText = "";
            this.dgvbtnAgainst.Name = "dgvbtnAgainst";
            this.dgvbtnAgainst.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvbtnAgainst.Text = "";
            this.dgvbtnAgainst.Width = 103;
            // 
            // dgvtxtAmount
            // 
            this.dgvtxtAmount.DataPropertyName = "amount";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.MaxInputLength = 8;
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtAmount.Width = 103;
            // 
            // dgvcmbCurrency
            // 
            this.dgvcmbCurrency.DataPropertyName = "exchangeRateId";
            this.dgvcmbCurrency.HeaderText = "Currency";
            this.dgvcmbCurrency.Name = "dgvcmbCurrency";
            this.dgvcmbCurrency.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbCurrency.Width = 103;
            // 
            // dgvtxtChequeNo
            // 
            this.dgvtxtChequeNo.DataPropertyName = "chequeNo";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.dgvtxtChequeNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtxtChequeNo.HeaderText = "Cheque No.";
            this.dgvtxtChequeNo.Name = "dgvtxtChequeNo";
            this.dgvtxtChequeNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtChequeNo.Width = 103;
            // 
            // dgvtxtChequeDate
            // 
            this.dgvtxtChequeDate.DataPropertyName = "chequeDate";
            this.dgvtxtChequeDate.HeaderText = "Cheque Date";
            this.dgvtxtChequeDate.Name = "dgvtxtChequeDate";
            this.dgvtxtChequeDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtChequeDate.Width = 103;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(505, 435);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 14);
            this.lblTotal.TabIndex = 530;
            this.lblTotal.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Location = new System.Drawing.Point(600, 431);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(200, 22);
            this.txtTotal.TabIndex = 522;
            // 
            // cbxPrintafterSave
            // 
            this.cbxPrintafterSave.AutoSize = true;
            this.cbxPrintafterSave.BackColor = System.Drawing.Color.Transparent;
            this.cbxPrintafterSave.ForeColor = System.Drawing.Color.Black;
            this.cbxPrintafterSave.Location = new System.Drawing.Point(32, 479);
            this.cbxPrintafterSave.Margin = new System.Windows.Forms.Padding(5);
            this.cbxPrintafterSave.Name = "cbxPrintafterSave";
            this.cbxPrintafterSave.Size = new System.Drawing.Size(107, 18);
            this.cbxPrintafterSave.TabIndex = 528;
            this.cbxPrintafterSave.Text = "Print after save";
            this.cbxPrintafterSave.UseVisualStyleBackColor = false;
            // 
            // lblNarration
            // 
            this.lblNarration.AutoSize = true;
            this.lblNarration.BackColor = System.Drawing.Color.Transparent;
            this.lblNarration.ForeColor = System.Drawing.Color.Black;
            this.lblNarration.Location = new System.Drawing.Point(32, 418);
            this.lblNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblNarration.Name = "lblNarration";
            this.lblNarration.Size = new System.Drawing.Size(58, 14);
            this.lblNarration.TabIndex = 529;
            this.lblNarration.Text = "Narration";
            // 
            // txtNarration
            // 
            this.txtNarration.Location = new System.Drawing.Point(150, 418);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtNarration.MaxLength = 5000;
            this.txtNarration.Multiline = true;
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Size = new System.Drawing.Size(200, 63);
            this.txtNarration.TabIndex = 521;
            // 
            // lnklblRemove
            // 
            this.lnklblRemove.ActiveLinkColor = System.Drawing.Color.Brown;
            this.lnklblRemove.AutoSize = true;
            this.lnklblRemove.LinkColor = System.Drawing.Color.Brown;
            this.lnklblRemove.Location = new System.Drawing.Point(755, 409);
            this.lnklblRemove.Margin = new System.Windows.Forms.Padding(5);
            this.lnklblRemove.Name = "lnklblRemove";
            this.lnklblRemove.Size = new System.Drawing.Size(50, 14);
            this.lnklblRemove.TabIndex = 526;
            this.lnklblRemove.TabStop = true;
            this.lnklblRemove.Text = "Remove";
            this.lnklblRemove.VisitedLinkColor = System.Drawing.Color.Brown;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(715, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 27);
            this.btnClose.TabIndex = 527;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Salmon;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(624, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 27);
            this.btnDelete.TabIndex = 525;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(533, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 524;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(442, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 523;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(340, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 14);
            this.label1.TabIndex = 1256;
            this.label1.Text = "*";
            // 
            // lblSalaryTypeValidator
            // 
            this.lblSalaryTypeValidator.AutoSize = true;
            this.lblSalaryTypeValidator.ForeColor = System.Drawing.Color.Red;
            this.lblSalaryTypeValidator.Location = new System.Drawing.Point(340, 17);
            this.lblSalaryTypeValidator.Margin = new System.Windows.Forms.Padding(5);
            this.lblSalaryTypeValidator.Name = "lblSalaryTypeValidator";
            this.lblSalaryTypeValidator.Size = new System.Drawing.Size(13, 14);
            this.lblSalaryTypeValidator.TabIndex = 1255;
            this.lblSalaryTypeValidator.Text = "*";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(581, 13);
            this.txtDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(181, 22);
            this.txtDate.TabIndex = 1249;
            // 
            // btnLedgerAdd
            // 
            this.btnLedgerAdd.BackColor = System.Drawing.Color.Gray;
            this.btnLedgerAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLedgerAdd.FlatAppearance.BorderSize = 0;
            this.btnLedgerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLedgerAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLedgerAdd.ForeColor = System.Drawing.Color.White;
            this.btnLedgerAdd.Location = new System.Drawing.Point(359, 39);
            this.btnLedgerAdd.Name = "btnLedgerAdd";
            this.btnLedgerAdd.Size = new System.Drawing.Size(21, 20);
            this.btnLedgerAdd.TabIndex = 1250;
            this.btnLedgerAdd.Text = "+";
            this.btnLedgerAdd.UseVisualStyleBackColor = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(486, 17);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 14);
            this.lblDate.TabIndex = 1254;
            this.lblDate.Text = "Date";
            // 
            // cmbBankorCash
            // 
            this.cmbBankorCash.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBankorCash.FormattingEnabled = true;
            this.cmbBankorCash.Location = new System.Drawing.Point(139, 38);
            this.cmbBankorCash.Margin = new System.Windows.Forms.Padding(5);
            this.cmbBankorCash.Name = "cmbBankorCash";
            this.cmbBankorCash.Size = new System.Drawing.Size(200, 22);
            this.cmbBankorCash.TabIndex = 1251;
            // 
            // lblBankorCash
            // 
            this.lblBankorCash.AutoSize = true;
            this.lblBankorCash.BackColor = System.Drawing.Color.Transparent;
            this.lblBankorCash.ForeColor = System.Drawing.Color.Black;
            this.lblBankorCash.Location = new System.Drawing.Point(19, 42);
            this.lblBankorCash.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblBankorCash.Name = "lblBankorCash";
            this.lblBankorCash.Size = new System.Drawing.Size(71, 14);
            this.lblBankorCash.TabIndex = 1252;
            this.lblBankorCash.Text = "Bank / Cash";
            // 
            // lblVoucheNo
            // 
            this.lblVoucheNo.AutoSize = true;
            this.lblVoucheNo.BackColor = System.Drawing.Color.Transparent;
            this.lblVoucheNo.ForeColor = System.Drawing.Color.Black;
            this.lblVoucheNo.Location = new System.Drawing.Point(19, 17);
            this.lblVoucheNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblVoucheNo.Name = "lblVoucheNo";
            this.lblVoucheNo.Size = new System.Drawing.Size(71, 14);
            this.lblVoucheNo.TabIndex = 1253;
            this.lblVoucheNo.Text = "Voucher No.";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Location = new System.Drawing.Point(139, 13);
            this.txtVoucherNo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(200, 22);
            this.txtVoucherNo.TabIndex = 1248;
            // 
            // dgvPayment
            // 
            this.dgvPayment.AllowUserToResizeColumns = false;
            this.dgvPayment.AllowUserToResizeRows = false;
            this.dgvPayment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayment.BackgroundColor = System.Drawing.Color.White;
            this.dgvPayment.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPayment.ColumnHeadersHeight = 25;
            this.dgvPayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgvcmbledger,
            this.dgvbtnAgainsth,
            this.dgvAmount,
            this.dgvtxtClass,
            this.dgvtxtStudentId});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 9F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPayment.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPayment.EnableHeadersVisualStyles = false;
            this.dgvPayment.GridColor = System.Drawing.Color.DimGray;
            this.dgvPayment.Location = new System.Drawing.Point(21, 67);
            this.dgvPayment.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.dgvPayment.MultiSelect = false;
            this.dgvPayment.Name = "dgvPayment";
            this.dgvPayment.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPayment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPayment.Size = new System.Drawing.Size(778, 337);
            this.dgvPayment.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SL.No";
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn1.HeaderText = "Sl No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvcmbledger
            // 
            this.dgvcmbledger.DataPropertyName = "ledgerName";
            this.dgvcmbledger.HeaderText = "Account Ledger";
            this.dgvcmbledger.Name = "dgvcmbledger";
            this.dgvcmbledger.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvbtnAgainsth
            // 
            this.dgvbtnAgainsth.HeaderText = "";
            this.dgvbtnAgainsth.Name = "dgvbtnAgainsth";
            this.dgvbtnAgainsth.Visible = false;
            // 
            // dgvAmount
            // 
            this.dgvAmount.DataPropertyName = "amount";
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dgvAmount.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvAmount.HeaderText = "Amount";
            this.dgvAmount.Name = "dgvAmount";
            this.dgvAmount.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtClass
            // 
            this.dgvtxtClass.DataPropertyName = "ChequeNo";
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtClass.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvtxtClass.HeaderText = "Cheque No.";
            this.dgvtxtClass.Name = "dgvtxtClass";
            this.dgvtxtClass.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvtxtStudentId
            // 
            this.dgvtxtStudentId.DataPropertyName = "ChequeDate";
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvtxtStudentId.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvtxtStudentId.HeaderText = "Cheque Date";
            this.dgvtxtStudentId.Name = "dgvtxtStudentId";
            this.dgvtxtStudentId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dgvtxtStudentId.Visible = false;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 520);
            this.Controls.Add(this.dgvPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSalaryTypeValidator);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnLedgerAdd);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbBankorCash);
            this.Controls.Add(this.lblBankorCash);
            this.Controls.Add(this.lblVoucheNo);
            this.Controls.Add(this.txtVoucherNo);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.cbxPrintafterSave);
            this.Controls.Add(this.lblNarration);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.lnklblRemove);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtSlNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtLedgerPostingId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpaymentMasterId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtpaymentDetailsId;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbAccountLedger;
        private System.Windows.Forms.DataGridViewButtonColumn dgvbtnAgainst;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbCurrency;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtChequeDate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.CheckBox cbxPrintafterSave;
        private System.Windows.Forms.Label lblNarration;
        private System.Windows.Forms.TextBox txtNarration;
        private System.Windows.Forms.LinkLabel lnklblRemove;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalaryTypeValidator;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnLedgerAdd;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbBankorCash;
        private System.Windows.Forms.Label lblBankorCash;
        private System.Windows.Forms.Label lblVoucheNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DataGridView dgvPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbledger;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvbtnAgainsth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtStudentId;
    }
}