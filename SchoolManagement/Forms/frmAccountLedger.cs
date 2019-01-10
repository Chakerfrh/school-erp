using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;

namespace SchoolManagement.Forms
{
    public partial class frmAccountLedger : Form
    {
        public frmAccountLedger()
        {
            InitializeComponent();
        }


        decimal ledgerId;




     public void ClearFunction()
     {

            txtLedgerName.Clear();
            txtOpeningBalance.Clear();
            cmbGroup.SelectedIndex = -1;
            cmbOpeningBalanceCrOrDr.SelectedIndex = -1;
            chkactive.Checked = false;
            FilldgvAccountLedger();
            FillComboGroup();

     }

      public void FillControls()
      {
            try
            {
              AccountLedgerSP spAccountLedger = new AccountLedgerSP();
              AccountLedgerInfo accountLedgerInfo = new AccountLedgerInfo();
              accountLedgerInfo = spAccountLedger.AccountLedgerViewOne(ledgerId);
              txtLedgerName.Text = accountLedgerInfo.LedgerName;
              cmbGroup.SelectedValue = accountLedgerInfo.AccountGroupId;
              txtOpeningBalance.Text = Convert.ToString(accountLedgerInfo.OpeningBalance);
              cmbOpeningBalanceCrOrDr.Text =accountLedgerInfo.CrOrDr;
                if (accountLedgerInfo.Active)
                {
                    chkactive.Checked = true;
                }

                else
                {
                    chkactive.Checked = false;
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




      }



        public void FilldgvAccountLedger()
        {
            DataTable dtbl = new DataTable();
            CommonSP spcommon= new CommonSP();
            dtbl = spcommon.FilldgvAccountLedger();
            dgvAccountLedger.DataSource = dtbl;

        }



       public void FillComboGroup()
       {
            DataTable dtbl = new DataTable();
            CommonSP common = new CommonSP();
            dtbl = common.FillAccountGroupCombo();
            DataRow drow = dtbl.NewRow();
            dtbl.Rows.InsertAt(drow, 0);

            cmbGroup.DataSource = dtbl;
            cmbGroup.DisplayMember = "accountName";
            cmbGroup.ValueMember = "accountId";
       }



        public void SaveOrEdit()
        {
            try
            {

                if (txtLedgerName.Text == string.Empty)
                {
                    MessageBox.Show("Enter a ledger name");
                }

                else if (cmbGroup.SelectedIndex == -1)
                {
                    MessageBox.Show("Select an accountGroup");
                }

                else
                {
                    
                       
                    AccountLedgerInfo accountLedgerInfo = new AccountLedgerInfo();
                    AccountLedgerSP spAccountLedger = new AccountLedgerSP();
                    accountLedgerInfo.LedgerName = txtLedgerName.Text.Trim();
                    accountLedgerInfo.AccountGroupId =Convert.ToDecimal(cmbGroup.SelectedValue.ToString());
                    accountLedgerInfo.CrOrDr = cmbOpeningBalanceCrOrDr.Text;
                    accountLedgerInfo.OpeningBalance = Convert.ToDecimal(txtOpeningBalance.Text.Trim());
                    if (chkactive.Checked)
                    {
                        accountLedgerInfo.Active = true;
                    }

                    else
                    {
                        accountLedgerInfo.Active = false;
                    }

                    if (btnSave.Text == "Save")
                    {

                        if (Messages.SaveConfirmation())
                        {
                            spAccountLedger.AccountLedgerAdd(accountLedgerInfo);
                            ClearFunction();
                            Messages.SavedMessage();
                        }

                    }

                    else
                    {
                        if (Messages.UpdateMessage())
                        {
                            accountLedgerInfo.LedgerId = ledgerId;
                            spAccountLedger.AccountLedgerUpdate(accountLedgerInfo);
                            ClearFunction();
                            Messages.UpdatedMessage();
                        }
                       
                    }




                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void frmAccountLedger_Load(object sender, EventArgs e)
        {
            try
            {
                ClearFunction();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvAccountLedger_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    if (dgvAccountLedger.CurrentRow.Cells["dgvtxtLedgerId"].Value != null && dgvAccountLedger.CurrentRow.Cells["dgvtxtLedgerId"].Value.ToString() != string.Empty)
                    {
                        ledgerId = Convert.ToDecimal(dgvAccountLedger.CurrentRow.Cells["dgvtxtLedgerId"].Value);
                        FillControls();
                        btnSave.Text = "Update"; 

                    }


                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            bool isMessageClose = true;

            try
            {

                if (isMessageClose)
                {

                    Messages.CloseMessage(this);
                }
                else
                {
                    this.Close();
                }


            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {

                ClearFunction();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
