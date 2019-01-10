using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Forms
{
    public partial class frmPayment : Form
    {

        DataTable dtblPartyBalance = new DataTable();//to store party balance entries while clicking btn_Save in payment voucher
        string strVoucherNo = string.Empty;//to save voucher no into tbl_payment master
        decimal decDailySuffixPrefixId = 0;//to store the selected voucher type's suffixpreffixid from frmVoucherTypeSelection
        decimal decAmount = 0;//to find the total amount

        public frmPayment()
        {
            InitializeComponent();
        }

      

        /// <summary>
        /// Cash or bank combofill
        /// </summary>
        public void CashOrBankComboFill()
        {
            try
            {
                DataTable dtbl = new DataTable();
                FillComboBoxes obj = new FillComboBoxes();
                dtbl = obj.BankOrCashComboFill(false);
                cmbBankorCash.DataSource = dtbl;
                cmbBankorCash.ValueMember = "ledgerId";
                cmbBankorCash.DisplayMember = "ledgerName";
                cmbBankorCash.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Account ledger combofill
        /// </summary>
        public void AccountLedgerComboFill()
        {
            try
            {
                DataTable dtbl = new DataTable();
                FillComboBoxes obj = new FillComboBoxes();
                dtbl = obj.AccountLedgerComboFill();
                DataRow dr = dtbl.NewRow();
                dr["ledgerId"] = "0";
                dr["ledgerName"] = string.Empty;
                dtbl.Rows.InsertAt(dr, 0);
                dgvcmbledger.DataSource = dtbl;
                dgvcmbledger.ValueMember = "ledgerId";
                dgvcmbledger.DisplayMember = "ledgerName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Serial no generation function for grid
        /// </summary>
        public void SerialNumberGeneration()
        {
            try
            {
                int inRowSlNo = 1;
                foreach (DataGridViewRow dr in dgvPayment.Rows)
                {
                    dr.Cells["dgvtxtSlNo"].Value = inRowSlNo;
                    inRowSlNo++;
                    if (dr.Index == dgvPayment.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// TotalAmountCalculation
        /// </summary>
        /// <returns></returns>
        public decimal TotalAmountCalculation()
        {
            decimal decTotal = 0;
            
            try
            {
                for (int inI = 0; inI < dgvPayment.RowCount - 1; inI++)
                {

                    if (dgvPayment.Rows[inI].HeaderCell.Value.ToString() != "X")
                    {
                       
                        decTotal = decTotal + (Convert.ToDecimal(dgvPayment.Rows[inI].Cells["dgvtxtAmount"].Value.ToString()));
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return decTotal;
        }

        /// <summary>
        /// Ledger Posting Add
        /// </summary>
        public void MasterLedgerPosting()
        {
            try
            {
                GeneraLedgerInfo InfoLedgerPosting = new GeneraLedgerInfo();
                GeneralLedgerSP SpLedgerPosting = new GeneralLedgerSP();
                //ExchangeRateSP SpExchangRate = new ExchangeRateSP();
                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");

                InfoLedgerPosting.Credit = Convert.ToDecimal(txtTotal.Text);
                InfoLedgerPosting.TransDate = Convert.ToDateTime(txtDate.Text);
                InfoLedgerPosting.Debit = 0;
                InfoLedgerPosting.DetailsId = 0;
                InfoLedgerPosting.Extra1 = string.Empty;
                InfoLedgerPosting.Extra2 = string.Empty;
                //InfoLedgerPosting.InvoiceNo = strInvoiceNo;
                InfoLedgerPosting.ChequeNo = string.Empty;
                InfoLedgerPosting.ChequeDate = DateTime.Now;
                InfoLedgerPosting.LedgerId = Convert.ToDecimal(cmbBankorCash.SelectedValue.ToString());
                /*if (!isAutomatic)
                {
                    InfoLedgerPosting.JournalNo = txtVoucherNo.Text.Trim();
                }
                else
                {
                    InfoLedgerPosting.JournalNo = strVoucherNo;
                }*/
               // InfoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                InfoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                SpLedgerPosting.generaledgerAddAll(InfoLedgerPosting);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Ledger posting details add
        /// </summary>
        /// <param name="inA"></param>
        /// <param name="decPaymentDetailsId"></param>
        public void DetailsLedgerPosting(int inA, decimal decPaymentDetailsId)
        {
            GeneraLedgerInfo InfoLedgerPosting = new GeneraLedgerInfo();
            GeneralLedgerSP SpLedgerPosting = new GeneralLedgerSP();
            
         
            try
            {


                if (!dgvPayment.Rows[inA].Cells["dgvtxtAmount"].ReadOnly)
                {
                    decimal d = Convert.ToDecimal(dgvPayment.Rows[inA].Cells["dgvcmbCurrency"].Value.ToString());
                    
                    decAmount = Convert.ToDecimal(dgvPayment.Rows[inA].Cells["dgvtxtAmount"].Value.ToString());
                    txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");

                    InfoLedgerPosting.Credit = 0;
                    InfoLedgerPosting.TransDate = Convert.ToDateTime(txtDate.Text);
                    InfoLedgerPosting.Debit = decAmount;
                    InfoLedgerPosting.DetailsId = decPaymentDetailsId;
                    InfoLedgerPosting.Extra1 = string.Empty;
                    InfoLedgerPosting.Extra2 = string.Empty;
                    //InfoLedgerPosting.InvoiceNo = strInvoiceNo;
                   // isAutomatic = SpVoucherType.CheckMethodOfVoucherNumbering(InfoPaymentMaster.VoucherTypeId);
                    if (dgvPayment.Rows[inA].Cells["dgvtxtChequeNo"].Value != null && dgvPayment.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                    {
                        InfoLedgerPosting.ChequeNo = dgvPayment.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString();
                        if (dgvPayment.Rows[inA].Cells["dgvtxtChequeDate"].Value != null && dgvPayment.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                        {
                            InfoLedgerPosting.ChequeDate = Convert.ToDateTime(dgvPayment.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString());
                        }
                        else
                            InfoLedgerPosting.ChequeDate = DateTime.Now;

                    }
                    else
                    {
                        InfoLedgerPosting.ChequeNo = string.Empty;
                        InfoLedgerPosting.ChequeDate = DateTime.Now;
                    }
                    InfoLedgerPosting.LedgerId = Convert.ToDecimal(dgvPayment.Rows[inA].Cells["dgvcmbAccountLedger"].Value.ToString());
                    /*if (!isAutomatic)
                    {
                        InfoLedgerPosting.VoucherNo = txtVoucherNo.Text.Trim();
                    }
                    else
                    {
                        InfoLedgerPosting.VoucherNo = strVoucherNo;
                    }*/
                   // InfoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                    InfoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    SpLedgerPosting.generaledgerAddAll(InfoLedgerPosting);
                }
                else
                {
                    //InfoLedgerPosting.Date = dtpDate.Value;

                    InfoLedgerPosting.Extra1 = string.Empty;
                    InfoLedgerPosting.Extra2 = string.Empty;
                    //InfoLedgerPosting.InvoiceNo = strInvoiceNo;
                    //InfoLedgerPosting.VoucherTypeId = decPaymentVoucherTypeId;
                    InfoLedgerPosting.YearId = PublicVariables._decCurrentFinancialYearId;
                    InfoLedgerPosting.Credit = 0;
                    InfoLedgerPosting.LedgerId = Convert.ToDecimal(dgvPayment.Rows[inA].Cells["dgvcmbAccountLedger"].Value.ToString());
                   // InfoLedgerPosting.VoucherNo = strVoucherNo;
                    InfoLedgerPosting.DetailsId = decPaymentDetailsId;
                    InfoLedgerPosting.InvoiceNo = txtVoucherNo.Text.Trim();
                    if (dgvPayment.Rows[inA].Cells["dgvtxtChequeNo"].Value != null && dgvPayment.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                    {
                        InfoLedgerPosting.ChequeNo = dgvPayment.Rows[inA].Cells["dgvtxtChequeNo"].Value.ToString();
                        if (dgvPayment.Rows[inA].Cells["dgvtxtChequeDate"].Value != null && dgvPayment.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                        {
                            InfoLedgerPosting.ChequeDate = Convert.ToDateTime(dgvPayment.Rows[inA].Cells["dgvtxtChequeDate"].Value.ToString());
                        }
                        else
                            InfoLedgerPosting.ChequeDate = DateTime.Now;
                    }
                    else
                    {
                        InfoLedgerPosting.ChequeNo = string.Empty;
                        InfoLedgerPosting.ChequeDate = DateTime.Now;
                    }

                    foreach (DataRow dr in dtblPartyBalance.Rows)
                    {
                        if (InfoLedgerPosting.LedgerId == Convert.ToDecimal(dr["LedgerId"].ToString()))
                        {
                            
                            decAmount = Convert.ToDecimal(dr["Amount"].ToString());
                           

                        }
                    }
                    InfoLedgerPosting.Debit = decAmount;
                    SpLedgerPosting.generaledgerAddAll(InfoLedgerPosting);

                    InfoLedgerPosting.LedgerId = 12;
                    foreach (DataRow dr in dtblPartyBalance.Rows)
                    {
                        if (Convert.ToDecimal(dgvPayment.Rows[inA].Cells["dgvcmbAccountLedger"].Value.ToString()) == Convert.ToDecimal(dr["LedgerId"].ToString()))
                        {
                            if (dr["ReferenceType"].ToString() == "Against")
                            {
                                
                                decAmount = Convert.ToDecimal(dr["Amount"].ToString());
                               
                                
                                
                                InfoLedgerPosting.Credit = -1 * decAmount;
                                InfoLedgerPosting.Debit = 0;
                               
                                SpLedgerPosting.generaledgerAddAll(InfoLedgerPosting);
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Save Function
        /// </summary>
        public void Save()
        {
            try
            {
                int inGridRowCount = dgvPayment.RowCount;
                int inTableRowCount = dtblPartyBalance.Rows.Count;
                int inB = 0;
                PaymentMasterInfo InfoPaymentMaster = new PaymentMasterInfo();
                PaymentMasterSP SpPaymentMaster = new PaymentMasterSP();
                PaymentDetailsInfo InfoPaymentDetails = new PaymentDetailsInfo();
                PaymentDetailsSP SpPaymentDetails = new PaymentDetailsSP();
                //PartyBalanceSP SpPartyBalance = new PartyBalanceSP(); NOT IMPLEMENTED
                //PartyBalanceInfo InfopartyBalance = new PartyBalanceInfo(); NOT IMPLEMENTED
                //DateValidation objVal = new DateValidation();
                TextBox txtDate1 = new TextBox();
                InfoPaymentMaster.VoucherNo = strVoucherNo;

                txtDate.Text = PublicVariables._dtCurrentDate.ToString("dd-MMM-yyyy");
                
                InfoPaymentMaster.Date = Convert.ToDateTime(txtDate.Text);
                InfoPaymentMaster.Extra1 = string.Empty;
                InfoPaymentMaster.Extra2 = string.Empty;
                InfoPaymentMaster.FinancialYearId = PublicVariables._decCurrentFinancialYearId;
                InfoPaymentMaster.InvoiceNo = txtVoucherNo.Text.Trim();
                InfoPaymentMaster.LedgerId = Convert.ToDecimal(cmbBankorCash.SelectedValue.ToString());
                InfoPaymentMaster.Narration = txtNarration.Text.Trim();
                InfoPaymentMaster.SuffixPrefixId = decDailySuffixPrefixId;
                decimal decTotalAmount = TotalAmountCalculation();
                InfoPaymentMaster.TotalAmount = decTotalAmount;
                InfoPaymentMaster.UserId = PublicVariables._decCurrentUserId;

                //InfoPaymentMaster.VoucherTypeId = decPaymentVoucherTypeId;
                decimal decPaymentMasterId = SpPaymentMaster.PaymentMasterAdd(InfoPaymentMaster);
                if (decPaymentMasterId != 0)
                {
                    MasterLedgerPosting();
                }
                for (int inI = 0; inI < inGridRowCount - 1; inI++)
                {
                    if (dgvPayment.Rows[inI].HeaderCell.Value.ToString() != "X")
                    {
                        InfoPaymentDetails.Amount = Convert.ToDecimal(dgvPayment.Rows[inI].Cells["dgvtxtAmount"].Value.ToString());
                        InfoPaymentDetails.ExchangeRateId = Convert.ToDecimal(dgvPayment.Rows[inI].Cells["dgvcmbCurrency"].Value.ToString());
                        InfoPaymentDetails.Extra1 = string.Empty;
                        InfoPaymentDetails.Extra2 = string.Empty;
                        InfoPaymentDetails.LedgerId = Convert.ToDecimal(dgvPayment.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString());
                        InfoPaymentDetails.PaymentMasterId = decPaymentMasterId;
                        if (dgvPayment.Rows[inI].Cells["dgvcmbAccountLedger"].Value != null && dgvPayment.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString() != string.Empty)
                        {
                            InfoPaymentDetails.LedgerId = Convert.ToDecimal(dgvPayment.Rows[inI].Cells["dgvcmbAccountLedger"].Value.ToString());
                        }
                        if (dgvPayment.Rows[inI].Cells["dgvtxtChequeNo"].Value != null && dgvPayment.Rows[inI].Cells["dgvtxtChequeNo"].Value.ToString() != string.Empty)
                        {
                            InfoPaymentDetails.ChequeNo = dgvPayment.Rows[inI].Cells["dgvtxtChequeNo"].Value.ToString();

                            if (dgvPayment.Rows[inI].Cells["dgvtxtChequeDate"].Value != null && dgvPayment.Rows[inI].Cells["dgvtxtChequeDate"].Value.ToString() != string.Empty)
                            {
                                InfoPaymentDetails.ChequeDate = Convert.ToDateTime(dgvPayment.Rows[inI].Cells["dgvtxtChequeDate"].Value);
                            }
                            else
                            {
                                InfoPaymentDetails.ChequeDate = DateTime.Now;
                            }
                        }
                        else
                        {
                            InfoPaymentDetails.ChequeNo = string.Empty;
                            InfoPaymentDetails.ChequeDate = DateTime.Now;
                        }
                        decimal decPaymentDetailsId = SpPaymentDetails.PaymentDetailsAdd(InfoPaymentDetails);
                        if (decPaymentDetailsId != 0)
                        {
                            
                            inB++;
                            DetailsLedgerPosting(inI, decPaymentDetailsId);
                        }
                    }
                }
                
                //Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Save or edit function, checking invalid entries to save or update
        /// </summary>
        public void SaveOrEdit()
        {
            try
            {
                
                int inIfGridColumnMissing = 0;
                int inRowCount = dgvPayment.RowCount;
                ArrayList arrLst = new ArrayList();
                string output = string.Empty;
                if (txtVoucherNo.Text == string.Empty)
                {
                    Messages.InformationMessage("Enter voucher number.");
                    txtVoucherNo.Focus();
                    inIfGridColumnMissing = 1;
                }
                else if (cmbBankorCash.SelectedIndex == -1)
                {
                    Messages.InformationMessage("Select any bank or cash");
                    cmbBankorCash.Focus();
                    inIfGridColumnMissing = 1;
                }
                else if (inRowCount == 1)
                {
                    Messages.InformationMessage("Can't save without atleast one complete details");
                    dgvPayment.Focus();
                    inIfGridColumnMissing = 1;
                }
                else if (Convert.ToDecimal(txtTotal.Text) == 0)
                {
                    Messages.InformationMessage("Can't save the total amount as Zero");
                    dgvPayment.Focus();
                }
                else
                {
                    int inJ = 0;
                    for (int inI = 0; inI < inRowCount - 1; inI++)
                    {

                        if (dgvPayment.Rows[inI].HeaderCell.Value.ToString() == "X")
                        {
                            arrLst.Add(Convert.ToString(inI + 1));
                            inIfGridColumnMissing = 1;
                            inJ++;
                        }
                    }
                    if (inJ != 0)
                    {
                        if (inJ == inRowCount - 1)
                        {
                            Messages.InformationMessage("Can't save without atleat one complete details");
                            inIfGridColumnMissing = 1;
                        }
                        else
                        {
                            foreach (object obj in arrLst)
                            {
                                string str = Convert.ToString(obj);
                                if (str != null)
                                {
                                    output += str + ",";
                                }
                                else
                                {
                                    break;
                                }
                            }
                            bool isOk = Messages.UpdateMessageCustom("Row No " + output + " not completed.Do you want to continue?");
                            if (isOk)
                            {
                                inIfGridColumnMissing = 0;
                            }
                            else
                            {
                                inIfGridColumnMissing = 1;
                            }
                        }
                    }

                    if (inIfGridColumnMissing == 0)
                    {
                        if (btnSave.Text == "Save")
                        {
                                           /* if (!isAutomatic)
                                            {
                                                if (SpPaymentMaster.PaymentVoucherCheckExistence(txtVoucherNo.Text.Trim(), decPaymentVoucherTypeId, 0))
                                                {
                               Save();                      Messages.InformationMessage("Voucher number already exist");
                                                }
                                                else
                                                {
                                    
                                    
                                                   Save();
                                    
                                                }
                                            }*/
                           
                        }
              
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }






        private void frmPayment_Load(object sender, EventArgs e)
        {
            CashOrBankComboFill();
            AccountLedgerComboFill();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
               
               SaveOrEdit();
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
