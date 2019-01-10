using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;
using SchoolManagement.Classes.General;

namespace SchoolManagement.Forms
{
    public partial class frmFeeProcessing : Form
    {
        public frmFeeProcessing()
        {
            InitializeComponent();
        }

        frmLedgerPopup frmLedgerPopupObj;
        decimal termId;
        decimal ledgerID;
        decimal classId;




        public void FillComboBoxTerm()
        {
            DataTable dt = new DataTable();
            CommonSP spCommon = new CommonSP();
            dt = spCommon.FillTermCombo();
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            cmbTerm.DataSource = dt;
            cmbTerm.ValueMember = "term_id";
            cmbTerm.DisplayMember = "term_name";
           

        }

        public void FillFeeItemComboBox()
        {
            DataTable dt = new DataTable();
            CommonSP spCommon = new CommonSP();
            dt = spCommon.FillFeeItemCombo(termId,classId);
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            dgvcmbFeeItem.DataSource = dt;
            dgvcmbFeeItem.ValueMember = "feeItemId";
            dgvcmbFeeItem.DisplayMember = "feeTitle";


        }


        public void ClearFunction()
        {
            dgvFeeProcessing.Rows.Clear();
            txtAdminNumber.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtClassNo.Clear();
            txtHomeEmail.Clear();
            txtHomePhone.Clear();
            txtVoucherNo.Clear();
            cmbTerm.SelectedIndex = -1;
            txtChequeNo.Clear();
            txtGrandTotal.Clear();
            txtBalance.Clear();
            txtPaidAmount.Clear();
            txtOpeningBalance.Clear();
            txtTotalAmount.Clear();

        }



        public void TotalAmountCalculation()
        {

            try
            {
                decimal dTotal = 0;
                foreach (DataGridViewRow dgvrow in dgvFeeProcessing.Rows)
                {
                    if (dgvrow.Cells["dgvtxtAmount"].Value != null)
                    {
                        dTotal = dTotal + decimal.Parse(dgvrow.Cells["dgvtxtAmount"].Value.ToString());
                        txtTotalAmount.Text = Convert.ToString(dTotal);
                        decimal dcOpeningBalance = Convert.ToDecimal(txtOpeningBalance.Text);
                        txtGrandTotal.Text = (dTotal + dcOpeningBalance).ToString();
                    }
                }

                decimal dcBalance = 0;
                if (txtPaidAmount.Text != string.Empty)
                {
                    if (Convert.ToDecimal(txtPaidAmount.Text) < Convert.ToDecimal(txtGrandTotal.Text))
                    {
                        dcBalance = Convert.ToDecimal(txtGrandTotal.Text) - Convert.ToDecimal(txtPaidAmount.Text);
                    }
                    else
                    {
                        dcBalance = 0;
                    }
                   
                }

                txtBalance.Text = dcBalance.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }




        public void SaveFunction()
        {
           try
           {
                GeneraLedgerInfo generalLedgerInfo = new GeneraLedgerInfo();
                GeneralLedgerSP spGeneraLedger = new GeneralLedgerSP();

                //Debit the Student/customer Account
                generalLedgerInfo.TransDate = DateTime.Now;
                generalLedgerInfo.JournalTypeId = 1;//
                generalLedgerInfo.JournalNo =1;//automatic generated
                generalLedgerInfo.LedgerId = ledgerID;
                generalLedgerInfo.Debit =Convert.ToDecimal(txtGrandTotal.Text);
                generalLedgerInfo.Credit = 0;
                generalLedgerInfo.ChequeNo = txtChequeNo.Text;
                generalLedgerInfo.ChequeDate = Convert.ToDateTime(txtChequeDate.Text);
                spGeneraLedger.generaledgerAddAll(generalLedgerInfo);

                //Credit the DebtorsControl A/c
                generalLedgerInfo.TransDate = DateTime.Now;
                generalLedgerInfo.JournalTypeId = 1;//
                generalLedgerInfo.JournalNo = 1;//automatic generated
                generalLedgerInfo.LedgerId = 61;
                generalLedgerInfo.Credit = Convert.ToDecimal(txtGrandTotal.Text);
                generalLedgerInfo.Debit = 0;
                generalLedgerInfo.ChequeNo = txtChequeNo.Text;
                generalLedgerInfo.ChequeDate = Convert.ToDateTime(txtChequeDate.Text);
                spGeneraLedger.generaledgerAddAll(generalLedgerInfo);

                if (Convert.ToDecimal(txtPaidAmount.Text) > 0)
                {
                    //Debit Bank A/c with the amount paid
                    generalLedgerInfo.TransDate = DateTime.Now;
                    generalLedgerInfo.JournalTypeId = 1;//
                    generalLedgerInfo.JournalNo = 1;//automatic generated
                    generalLedgerInfo.LedgerId = 63;
                    generalLedgerInfo.Debit = Convert.ToDecimal(txtPaidAmount.Text.ToString());
                    generalLedgerInfo.Credit = 0;
                    generalLedgerInfo.ChequeNo = txtChequeNo.Text;
                    generalLedgerInfo.ChequeDate = Convert.ToDateTime(txtChequeDate.Text);
                    spGeneraLedger.generaledgerAddAll(generalLedgerInfo);
                    //Credit the Student/Customer A/c
                    generalLedgerInfo.TransDate = DateTime.Now;
                    generalLedgerInfo.JournalTypeId = 1;//
                    generalLedgerInfo.JournalNo = 1;//automatic generated
                    generalLedgerInfo.LedgerId = ledgerID;
                    generalLedgerInfo.Credit = Convert.ToDecimal(txtPaidAmount.Text);
                    generalLedgerInfo.Debit = 0;
                    generalLedgerInfo.ChequeNo = txtChequeNo.Text;
                    generalLedgerInfo.ChequeDate = Convert.ToDateTime(txtChequeDate.Text);
                    spGeneraLedger.generaledgerAddAll(generalLedgerInfo);

                }

                Messages.SavedMessage();
                ClearFunction();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void btnStudentAdd_Click(object sender, EventArgs e)
        {
            try
            {
               frmLedgerPopup frmLedgerPopup = new frmLedgerPopup();
               frmLedgerPopup.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        ///  Function to call this form from frmFeeProcessing
        /// </summary>
        /// <param name="frmAccountledger"></param>
        public void CallFromLedgerPopup(decimal ledgerId,frmLedgerPopup frm)
        {
            try
            {
        
                base.Show();
                frmLedgerPopupObj = frm;
                FeeProcessingSP spFeeProcessing = new FeeProcessingSP();
                AccountLedgerInfo ledgerInfo = new AccountLedgerInfo();
               
                ledgerInfo = spFeeProcessing.AccountLedgerViewFilter(ledgerId);
                txtFirstName.Text = ledgerInfo.LedgerName;
                txtLastName.Text = ledgerInfo.OtherName;
                txtAdminNumber.Text = ledgerInfo.AdminNumber;
                txtClassNo.Text = ledgerInfo.Extra1;
                txtHomeEmail.Text = ledgerInfo.Email;
                txtHomePhone.Text = ledgerInfo.HomePhone;
                txtOpeningBalance.Text = Convert.ToString(ledgerInfo.OpeningBalance);
                ledgerID = ledgerId;
                classId = ledgerInfo.ClassNo;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void FeeDetailsFill(decimal feeItemId,int inRowIndex)
        {
            DataTable dt = new DataTable();
            CommonSP spCommon = new CommonSP();
            dt = spCommon.FillFeeItemComboOne(feeItemId);
            if (dt.Rows.Count != 0)
            {
                dgvFeeProcessing.Rows[inRowIndex].Cells["dgvtxtTerm"].Value = dt.Rows[0]["term_name"];
                dgvFeeProcessing.Rows[inRowIndex].Cells["dgvtxtAmount"].Value = dt.Rows[0]["feeAmount"];
                TotalAmountCalculation();
            }


        }

        /// <summary>
        ///Function to Generate automatic journal_no no in the datagrid view column
        /// </summary>
        public void SlNo()
        {
            int inRowNo = 1;
            try
            {
                foreach (DataGridViewRow dr in dgvFeeProcessing.Rows)
                {
                    dr.Cells["dgvsno"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvFeeProcessing.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JV11:" + ex.Message, "FanisiPro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void frmFeeProcessing_Load(object sender, EventArgs e)
        {
            try
            {
                FillComboBoxTerm();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          
        }

        private void cmbTerm_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbTerm.SelectedIndex > -1 && cmbTerm.SelectedValue != null && cmbTerm.SelectedValue.ToString() != string.Empty)
            {

                if (cmbTerm.SelectedValue.ToString() != "System.Data.DataRowView" && cmbTerm.Text != "System.Data.DataRowView")
                {
                    termId = Convert.ToDecimal(cmbTerm.SelectedValue.ToString());
               
                    FillFeeItemComboBox();
                    
                }               
            }
        }

        private void dgvFeeProcessing_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            decimal feeItemId = 0;

            try
            {
                if (e.ColumnIndex == dgvFeeProcessing.Columns["dgvcmbFeeItem"].Index)
                {
                    if (dgvFeeProcessing.Rows[e.RowIndex].Cells["dgvcmbFeeItem"].Value != null)
                    {
                        if (dgvFeeProcessing.Rows[e.RowIndex].Cells["dgvcmbFeeItem"].Value.ToString() != string.Empty)
                        {
                            feeItemId =Convert.ToDecimal(dgvFeeProcessing.Rows[e.RowIndex].Cells["dgvcmbFeeItem"].Value);
                        }
                    }
                    FeeDetailsFill(feeItemId, e.RowIndex);

                }


            }
            catch (Exception ex)
            {

               MessageBox.Show(ex.Message);
            }
        }

        private void dgvFeeProcessing_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                e.ThrowException = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFeeProcessing_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {


                SlNo();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

   

        private void txtPaidAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalAmountCalculation();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            if (dgvFeeProcessing.Rows[0].Cells["dgvcmbFeeItem"].Value == null)
            {

               
                MessageBox.Show("Can't save Transaction without complete entry", "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvFeeProcessing.ClearSelection();
                dgvFeeProcessing.Focus();
            }

            else
            {
                if (Messages.SaveConfirmation())
                {

                    SaveFunction();

                }
            }
           

        }
    }
}
