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
    public partial class frmFees : Form
    {
        public frmFees()
        {
            InitializeComponent();
        }

        decimal feeItemId;




        public void FillClassCombo()
        {
            DataTable dt = new DataTable();
            CommonSP spCommon = new CommonSP();
            dt = spCommon.FillStudentClassCombo();
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            cmbClass.DataSource = dt;
            cmbClass.ValueMember = "ClassNo";
            cmbClass.DisplayMember = "ClassNo";


        }


        public void FillTermCombo()
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



        public void FilldgvFeeItem()
        {
            DataTable dt = new DataTable();
            FeeItemSp feeItemSp = new FeeItemSp();
            dt = feeItemSp.FillDataGridViewFeeItem();
            dgvFeeItem.DataSource = dt;


        }


        public void ClearFunction()
        {
            txtAmount.Clear();
            txtFeeType.Clear();
            cbxActive.Checked = false;          
            FillClassCombo();
            FillTermCombo();
            FilldgvFeeItem();
            cmbClass.SelectedIndex = -1;
            cmbTerm.SelectedIndex = -1;

        }


        public void FillControls()
        {
            try
            {
                FeeItemInfo feeItemInfo = new FeeItemInfo();
                FeeItemSp feeItemSp = new FeeItemSp();
                feeItemInfo = feeItemSp.FillDataGridViewFeeItemOne(feeItemId);
                txtFeeType.Text = feeItemInfo.FeeTitle;
                cmbClass.SelectedValue = Convert.ToInt32(feeItemInfo.ClassId);
                cmbTerm.SelectedValue = Convert.ToInt32(feeItemInfo.TermId);
                txtAmount.Text = Convert.ToString(feeItemInfo.FeeAmount);
                if (feeItemInfo.Active)
                {
                    cbxActive.Checked = true;
                }

                else
                {
                    cbxActive.Checked = false;
                }





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

                if (txtFeeType.Text== string.Empty)
                {
                    MessageBox.Show("Enter a fee type");
                }

                else if (cmbClass.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a class");
                }

                else if (cmbTerm.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a term");
                }

                else if (txtAmount.Text == string.Empty)
                {
                    MessageBox.Show("Enter amount");
                }

                else
                {

                    FeeItemInfo feeItemInfo = new FeeItemInfo();
                    FeeItemSp feeItemSp = new FeeItemSp();


                    feeItemInfo.FeeTitle = txtFeeType.Text.Trim();
                    feeItemInfo.ClassId = Convert.ToDecimal(cmbClass.SelectedValue);
                    feeItemInfo.TermId = Convert.ToDecimal(cmbTerm.SelectedValue);
                    feeItemInfo.FeeAmount = Convert.ToDecimal(txtAmount.Text);
                    if (cbxActive.Checked)
                    {
                        feeItemInfo.Active = true;
                    }

                    else
                    {
                        feeItemInfo.Active = false;
                    }



                    if (btnSave.Text == "Save")
                    {
                        if (Messages.SaveConfirmation())
                        {
                            feeItemSp.FeeItemAdd(feeItemInfo);
                            Messages.SavedMessage();
                            ClearFunction();

                        }

                    }

                    else
                    {

                        if (Messages.UpdateMessage())
                        {

                            feeItemInfo.FeeItemId = feeItemId;
                            feeItemSp.FeeItemUpdate(feeItemInfo);
                            Messages.UpdatedMessage();
                            ClearFunction();
                        }


                    }





                }




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }




        private void btnSearch_Click(object sender, EventArgs e)
        {
            SaveFunction();
        }

        private void frmFees_Load(object sender, EventArgs e)
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

        private void dgvFeeItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dgvFeeItem.CurrentRow.Cells["dgvFeeItemId"].Value != null && dgvFeeItem.CurrentRow.Cells["dgvFeeItemId"].Value.ToString() != string.Empty)
                    {
                        feeItemId = Convert.ToDecimal(dgvFeeItem.CurrentRow.Cells["dgvFeeItemId"].Value);
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
    }
}
