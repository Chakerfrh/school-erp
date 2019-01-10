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
    public partial class frmAccountGroup : Form
    {
        public frmAccountGroup()
        {
            InitializeComponent();
        }



        decimal accountId;
        bool isDefault;





        public void FillControls()
        {
            try
            {
              AccountGroupSP spAccountGroup = new AccountGroupSP();
              AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
              infoAccountGroup = spAccountGroup.AccountGroupViewOne(accountId);
              txtAccountName.Text = infoAccountGroup.AccountName;
              cmbAccountGroup.Text = infoAccountGroup.AccountGroup;
              txtAccountSubGroup.Text = infoAccountGroup.AccountSubGroup;
              txtAccountCode.Text = infoAccountGroup.AccountCode;
              cmbAffects.Text = infoAccountGroup.Affects;
              isDefault = Convert.ToBoolean(infoAccountGroup.IsDefault);
            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }





        /// <summary>
        /// Function to fill the grid with values from the accountGrroupTable
        /// </summary>

        public void FillDgvAccountGroup()
        {
            try
            {
                AccountGroupSP spAccountGroup = new AccountGroupSP();
                DataTable dtbl = new DataTable();
                if (cmbGroupUnderSearch.Text.Trim() == string.Empty)
                {
                    cmbGroupUnderSearch.Text = "All";
                }

                dtbl = spAccountGroup.AccountGroupSearch(txtAccountGroupNameSearch.Text.Trim(), cmbGroupUnderSearch.Text);
                dgvAccountGroup.DataSource = dtbl;



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        


        /// <summary>
        /// resetting the Account group page
        /// </summary>
        public void Clear()
        {
            try
            {
                txtAccountName.Clear();
                cmbAffects.SelectedIndex = -1;
                cmbGroupUnderSearch.SelectedIndex = -1;
                txtAccountSubGroup.Clear();
                cmbAccountGroup.SelectedIndex = -1;
                txtAccountCode.Clear();
                btnSave.Text = "Save";
                btnSave.Enabled = true;
                txtAccountName.Enabled = true;
                cmbAffects.Enabled = true;
                txtAccountSubGroup.Enabled = true;
                cmbAccountGroup.Enabled = true;
                FillDgvAccountGroup();
                txtAccountName.Select();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /// <summary>
        /// Function to update values in accountGrroupTable
        /// </summary>
        
        public void EditFunction()
        {


            try
            {

                AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
                AccountGroupSP spAccountGroup = new AccountGroupSP();

                infoAccountGroup.AccountName = txtAccountName.Text.Trim();
                infoAccountGroup.AccountGroup = cmbAccountGroup.SelectedItem.ToString();
                infoAccountGroup.AccountSubGroup = txtAccountSubGroup.Text.Trim();
                infoAccountGroup.AccountCode = txtAccountCode.Text.Trim();
                infoAccountGroup.Affects = cmbAffects.SelectedItem.ToString();
                infoAccountGroup.IsDefault = false;
                infoAccountGroup.Narration = string.Empty;
                infoAccountGroup.Extra1 = string.Empty;
                infoAccountGroup.Extra2 = string.Empty;

                infoAccountGroup.AccountId = accountId;
         
                spAccountGroup.AccountGroupUpdate(infoAccountGroup);
                Messages.UpdatedMessage();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }        

        /// <summary>
        /// Function to save values in accountGrroupTable
        /// </summary>

        public void SaveFunction()
        {
            try
            {

                AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
                AccountGroupSP spAccountGroup = new AccountGroupSP();

                infoAccountGroup.AccountName = txtAccountName.Text.Trim();
                infoAccountGroup.AccountGroup = cmbAccountGroup.SelectedItem.ToString();
                infoAccountGroup.AccountSubGroup = txtAccountSubGroup.Text.Trim();
                infoAccountGroup.AccountCode = txtAccountCode.Text.Trim();
                infoAccountGroup.Affects = cmbAffects.SelectedItem.ToString();
                infoAccountGroup.IsDefault = false;
                infoAccountGroup.Narration = string.Empty;
                infoAccountGroup.Extra1 = string.Empty;
                infoAccountGroup.Extra2 = string.Empty;

              
               spAccountGroup.AccountGroupAdd(infoAccountGroup);
                Messages.SavedMessage();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        public void SaveOrEdit()
        {

            if (txtAccountName.Text == string.Empty)
            {
                MessageBox.Show("Enter an account group please");
            }

            else if (cmbAccountGroup.SelectedIndex == -1)
            {
                MessageBox.Show("Select a category");
            }

            else
            {

                if (btnSave.Text == "Save")
                {
                    if (Messages.SaveConfirmation())
                    {
                        SaveFunction();
                        Clear();
                    }

                }
               

                else
                {

                    if (isDefault == true)
                    {
                        MessageBox.Show("Cant Update a built in account");
                    }
                    else
                    {
                        if (Messages.UpdateMessage())
                        {
                            EditFunction();
                            Clear();
                        }
                    }
                    
                }
            }



        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void frmAccountGroup_Load(object sender, EventArgs e)
        {
            try
            {
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtAccountGroupNameSearch_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    cmbGroupUnderSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                FillDgvAccountGroup();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void dgvAccountGroup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    if(dgvAccountGroup.CurrentRow.Cells["dgvtxtAccountGroupId"].Value != null && dgvAccountGroup.CurrentRow.Cells["dgvtxtAccountGroupId"].Value.ToString() != string.Empty)
                    {
                        accountId = Convert.ToDecimal(dgvAccountGroup.CurrentRow.Cells["dgvtxtAccountGroupId"].Value);
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
                Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
