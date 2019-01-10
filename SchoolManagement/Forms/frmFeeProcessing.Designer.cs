namespace SchoolManagement.Forms
{
    partial class frmFeeProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeeProcessing));
            this.dgvFeeProcessing = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHomeEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHomePhone = new System.Windows.Forms.TextBox();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdminNumber = new System.Windows.Forms.TextBox();
            this.cmbTerm = new System.Windows.Forms.ComboBox();
            this.lblAreaNameValidator = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.gbxAmountDetails = new System.Windows.Forms.GroupBox();
            this.txtChequeDate = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.lblPaidAmount = new System.Windows.Forms.Label();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.btnStudentAdd = new System.Windows.Forms.Button();
            this.txtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.dgvsno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvcmbFeeItem = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvtxtTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtxtAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_check = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeProcessing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbxAmountDetails.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFeeProcessing
            // 
            this.dgvFeeProcessing.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeeProcessing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeeProcessing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeeProcessing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvsno,
            this.dgvcmbFeeItem,
            this.dgvtxtTerm,
            this.dgvtxtAmount,
            this.dgv_check});
            this.dgvFeeProcessing.Location = new System.Drawing.Point(6, 37);
            this.dgvFeeProcessing.Name = "dgvFeeProcessing";
            this.dgvFeeProcessing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeeProcessing.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFeeProcessing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFeeProcessing.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvFeeProcessing.Size = new System.Drawing.Size(792, 116);
            this.dgvFeeProcessing.TabIndex = 1;
            this.dgvFeeProcessing.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeeProcessing_CellEndEdit);
            this.dgvFeeProcessing.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvFeeProcessing_DataError);
            this.dgvFeeProcessing.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvFeeProcessing_RowsAdded);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 14);
            this.label12.TabIndex = 1245;
            this.label12.Text = "Admin No";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHomeEmail);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtHomePhone);
            this.groupBox1.Controls.Add(this.txtClassNo);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtAdminNumber);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 193);
            this.groupBox1.TabIndex = 1253;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Details";
            // 
            // txtHomeEmail
            // 
            this.txtHomeEmail.BackColor = System.Drawing.Color.White;
            this.txtHomeEmail.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtHomeEmail.Location = new System.Drawing.Point(120, 163);
            this.txtHomeEmail.Name = "txtHomeEmail";
            this.txtHomeEmail.ReadOnly = true;
            this.txtHomeEmail.Size = new System.Drawing.Size(202, 22);
            this.txtHomeEmail.TabIndex = 1255;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(20, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 14);
            this.label14.TabIndex = 1257;
            this.label14.Text = "Home Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9F);
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 14);
            this.label11.TabIndex = 1258;
            this.label11.Text = "Home Phone";
            // 
            // txtHomePhone
            // 
            this.txtHomePhone.BackColor = System.Drawing.Color.White;
            this.txtHomePhone.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtHomePhone.Location = new System.Drawing.Point(120, 135);
            this.txtHomePhone.Name = "txtHomePhone";
            this.txtHomePhone.ReadOnly = true;
            this.txtHomePhone.Size = new System.Drawing.Size(202, 22);
            this.txtHomePhone.TabIndex = 1256;
            // 
            // txtClassNo
            // 
            this.txtClassNo.BackColor = System.Drawing.Color.White;
            this.txtClassNo.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtClassNo.Location = new System.Drawing.Point(120, 108);
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.ReadOnly = true;
            this.txtClassNo.Size = new System.Drawing.Size(202, 22);
            this.txtClassNo.TabIndex = 1263;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtLastName.Location = new System.Drawing.Point(120, 80);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(202, 22);
            this.txtLastName.TabIndex = 1254;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 14);
            this.label5.TabIndex = 1256;
            this.label5.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 14);
            this.label3.TabIndex = 1262;
            this.label3.Text = "Class";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtFirstName.Location = new System.Drawing.Point(120, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(202, 22);
            this.txtFirstName.TabIndex = 1255;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(22, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 14);
            this.label6.TabIndex = 1253;
            this.label6.Text = "Last Name";
            // 
            // txtAdminNumber
            // 
            this.txtAdminNumber.BackColor = System.Drawing.Color.White;
            this.txtAdminNumber.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtAdminNumber.Location = new System.Drawing.Point(120, 28);
            this.txtAdminNumber.Name = "txtAdminNumber";
            this.txtAdminNumber.Size = new System.Drawing.Size(202, 22);
            this.txtAdminNumber.TabIndex = 1243;
            // 
            // cmbTerm
            // 
            this.cmbTerm.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTerm.FormattingEnabled = true;
            this.cmbTerm.Location = new System.Drawing.Point(114, 43);
            this.cmbTerm.Name = "cmbTerm";
            this.cmbTerm.Size = new System.Drawing.Size(202, 22);
            this.cmbTerm.TabIndex = 1275;
            this.cmbTerm.SelectedIndexChanged += new System.EventHandler(this.cmbTerm_SelectedIndexChanged);
            // 
            // lblAreaNameValidator
            // 
            this.lblAreaNameValidator.AutoSize = true;
            this.lblAreaNameValidator.ForeColor = System.Drawing.Color.Red;
            this.lblAreaNameValidator.Location = new System.Drawing.Point(318, 46);
            this.lblAreaNameValidator.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.lblAreaNameValidator.Name = "lblAreaNameValidator";
            this.lblAreaNameValidator.Size = new System.Drawing.Size(12, 15);
            this.lblAreaNameValidator.TabIndex = 1277;
            this.lblAreaNameValidator.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 14);
            this.label2.TabIndex = 1276;
            this.label2.Text = "Term";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(451, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 14);
            this.label1.TabIndex = 1271;
            this.label1.Text = "Total Amount";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.lblBalance);
            this.groupBox3.Controls.Add(this.txtBalance);
            this.groupBox3.Controls.Add(this.lblGrandTotal);
            this.groupBox3.Controls.Add(this.gbxAmountDetails);
            this.groupBox3.Controls.Add(this.txtPaidAmount);
            this.groupBox3.Controls.Add(this.lblPaidAmount);
            this.groupBox3.Controls.Add(this.txtOpeningBalance);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtGrandTotal);
            this.groupBox3.Controls.Add(this.txtTotalAmount);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.dgvFeeProcessing);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox3.Location = new System.Drawing.Point(3, 244);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(804, 361);
            this.groupBox3.TabIndex = 1274;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fee Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DimGray;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(455, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 27);
            this.btnSave.TabIndex = 1339;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(705, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(85, 27);
            this.btnClear.TabIndex = 1340;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.ForeColor = System.Drawing.Color.Black;
            this.lblBalance.Location = new System.Drawing.Point(455, 275);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(5);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(46, 13);
            this.lblBalance.TabIndex = 1159;
            this.lblBalance.Text = "Balance";
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(575, 275);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(221, 20);
            this.txtBalance.TabIndex = 100;
            this.txtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.Black;
            this.lblGrandTotal.Location = new System.Drawing.Point(452, 217);
            this.lblGrandTotal.Margin = new System.Windows.Forms.Padding(5);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(70, 14);
            this.lblGrandTotal.TabIndex = 1281;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // gbxAmountDetails
            // 
            this.gbxAmountDetails.Controls.Add(this.txtChequeDate);
            this.gbxAmountDetails.Controls.Add(this.label16);
            this.gbxAmountDetails.Controls.Add(this.txtChequeNo);
            this.gbxAmountDetails.Controls.Add(this.label15);
            this.gbxAmountDetails.Controls.Add(this.groupBox4);
            this.gbxAmountDetails.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAmountDetails.ForeColor = System.Drawing.Color.Maroon;
            this.gbxAmountDetails.Location = new System.Drawing.Point(9, 165);
            this.gbxAmountDetails.Name = "gbxAmountDetails";
            this.gbxAmountDetails.Size = new System.Drawing.Size(243, 109);
            this.gbxAmountDetails.TabIndex = 1280;
            this.gbxAmountDetails.TabStop = false;
            this.gbxAmountDetails.Text = "Payment Details";
            // 
            // txtChequeDate
            // 
            this.txtChequeDate.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeDate.Location = new System.Drawing.Point(90, 54);
            this.txtChequeDate.Name = "txtChequeDate";
            this.txtChequeDate.Size = new System.Drawing.Size(138, 22);
            this.txtChequeDate.TabIndex = 1280;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(16, 54);
            this.label16.Margin = new System.Windows.Forms.Padding(5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 13);
            this.label16.TabIndex = 1184;
            this.label16.Text = "Cheque Date";
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Location = new System.Drawing.Point(90, 27);
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(138, 21);
            this.txtChequeNo.TabIndex = 1182;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 27);
            this.label15.Margin = new System.Windows.Forms.Padding(5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 1181;
            this.label15.Text = "Cheque No";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Black;
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(10, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(70, 1);
            this.groupBox4.TabIndex = 1180;
            this.groupBox4.TabStop = false;
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(575, 250);
            this.txtPaidAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtPaidAmount.MaxLength = 10;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.Size = new System.Drawing.Size(223, 20);
            this.txtPaidAmount.TabIndex = 0;
            this.txtPaidAmount.Text = "0";
            this.txtPaidAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaidAmount.TextChanged += new System.EventHandler(this.txtPaidAmount_TextChanged);
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.AutoSize = true;
            this.lblPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidAmount.ForeColor = System.Drawing.Color.Black;
            this.lblPaidAmount.Location = new System.Drawing.Point(455, 250);
            this.lblPaidAmount.Margin = new System.Windows.Forms.Padding(5);
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Size = new System.Drawing.Size(67, 13);
            this.lblPaidAmount.TabIndex = 1157;
            this.lblPaidAmount.Text = "Paid Amount";
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.BackColor = System.Drawing.Color.White;
            this.txtOpeningBalance.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtOpeningBalance.Location = new System.Drawing.Point(575, 191);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.ReadOnly = true;
            this.txtOpeningBalance.Size = new System.Drawing.Size(223, 22);
            this.txtOpeningBalance.TabIndex = 1279;
            this.txtOpeningBalance.Text = "0";
            this.txtOpeningBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(451, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 14);
            this.label13.TabIndex = 1278;
            this.label13.Text = "Opening Balance";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.BackColor = System.Drawing.Color.White;
            this.txtGrandTotal.Font = new System.Drawing.Font("Calibri", 9F);
            this.txtGrandTotal.Location = new System.Drawing.Point(575, 219);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.Size = new System.Drawing.Size(222, 22);
            this.txtGrandTotal.TabIndex = 1275;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.White;
            this.txtTotalAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(575, 163);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(222, 23);
            this.txtTotalAmount.TabIndex = 1270;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStudentAdd
            // 
            this.btnStudentAdd.BackColor = System.Drawing.Color.DarkGray;
            this.btnStudentAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStudentAdd.FlatAppearance.BorderSize = 0;
            this.btnStudentAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentAdd.ForeColor = System.Drawing.Color.White;
            this.btnStudentAdd.Location = new System.Drawing.Point(355, 38);
            this.btnStudentAdd.Name = "btnStudentAdd";
            this.btnStudentAdd.Size = new System.Drawing.Size(20, 24);
            this.btnStudentAdd.TabIndex = 1268;
            this.btnStudentAdd.Text = "+";
            this.btnStudentAdd.UseVisualStyleBackColor = false;
            this.btnStudentAdd.Click += new System.EventHandler(this.btnStudentAdd_Click);
            // 
            // txtDateTimePicker
            // 
            this.txtDateTimePicker.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTimePicker.Location = new System.Drawing.Point(116, 71);
            this.txtDateTimePicker.Name = "txtDateTimePicker";
            this.txtDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.txtDateTimePicker.TabIndex = 1275;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(10, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 1259;
            this.label4.Text = "Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 14);
            this.label7.TabIndex = 1279;
            this.label7.Text = "Voucher No";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtDateTimePicker);
            this.groupBox5.Controls.Add(this.lblAreaNameValidator);
            this.groupBox5.Controls.Add(this.txtVoucherNo);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.cmbTerm);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox5.ForeColor = System.Drawing.Color.Maroon;
            this.groupBox5.Location = new System.Drawing.Point(457, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(336, 112);
            this.groupBox5.TabIndex = 1280;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Voucher Details";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.Location = new System.Drawing.Point(113, 18);
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.ReadOnly = true;
            this.txtVoucherNo.Size = new System.Drawing.Size(202, 22);
            this.txtVoucherNo.TabIndex = 1278;
            // 
            // dgvsno
            // 
            this.dgvsno.HeaderText = "No";
            this.dgvsno.Name = "dgvsno";
            // 
            // dgvcmbFeeItem
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            this.dgvcmbFeeItem.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvcmbFeeItem.HeaderText = "Fee Item";
            this.dgvcmbFeeItem.Name = "dgvcmbFeeItem";
            this.dgvcmbFeeItem.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcmbFeeItem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvcmbFeeItem.Width = 210;
            // 
            // dgvtxtTerm
            // 
            this.dgvtxtTerm.HeaderText = "Term";
            this.dgvtxtTerm.Name = "dgvtxtTerm";
            this.dgvtxtTerm.Width = 210;
            // 
            // dgvtxtAmount
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(100, 0, 0, 0);
            this.dgvtxtAmount.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvtxtAmount.HeaderText = "Amount";
            this.dgvtxtAmount.Name = "dgvtxtAmount";
            this.dgvtxtAmount.Width = 220;
            // 
            // dgv_check
            // 
            this.dgv_check.HeaderText = "";
            this.dgv_check.Name = "dgv_check";
            this.dgv_check.Visible = false;
            // 
            // frmFeeProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 608);
            this.Controls.Add(this.btnStudentAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFeeProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fee Processing";
            this.Load += new System.EventHandler(this.frmFeeProcessing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeeProcessing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbxAmountDetails.ResumeLayout(false);
            this.gbxAmountDetails.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFeeProcessing;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnStudentAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.GroupBox gbxAmountDetails;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label lblPaidAmount;
        private System.Windows.Forms.Label lblAreaNameValidator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTerm;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtAdminNumber;
        private System.Windows.Forms.TextBox txtHomePhone;
        private System.Windows.Forms.TextBox txtHomeEmail;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker txtDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.DateTimePicker txtChequeDate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvsno;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvcmbFeeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtxtAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_check;
    }
}