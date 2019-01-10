using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;
using System;
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
    public partial class frmPromoteStudents : Form
    {
        public frmPromoteStudents()
        {
            InitializeComponent();
        }


        public void ComboLevelFill()
        {
            try
            {
                StudentSP stud = new StudentSP();
                DataTable dt = new DataTable();
                dt = stud.FillDatagridViewPromotion();
                cboClass.DataSource = dt;
                cboClass.ValueMember = "ClassNo";
                cboClass.DisplayMember = "ClassNo";
                cboClass.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// Function to filter dgvStudent based on Search Item
        /// </summary>
        public void FilterdgvledgerPopup()
        {
            CommonSP spCommon = new CommonSP();
            dgvPromotion.AutoGenerateColumns = false;
            DataTable dt = new DataTable();

            if (txtAdminNumber.Text != string.Empty)
            {
                dt = spCommon.filterDetailsFordgvPromotion(Convert.ToString(txtAdminNumber.Text));
                dgvPromotion.DataSource = dt;
            }
        }


        /// <summary>
        /// Student Creation GridFill
        /// </summary>
        public void GridFillSearch()
        {
            try
            {

                int search_item = Convert.ToInt32(cboClass.SelectedValue.ToString());
                StudentSP spStudent = new StudentSP();
                DataTable dtblStudentCreation = new DataTable();
                dtblStudentCreation = spStudent.StudentPromotionViewForGridFill(search_item);
                dgvPromotion.DataSource = dtblStudentCreation;

                for (int i = 0; i < dgvPromotion.RowCount; i++)
                {
                    dgvPromotion.Rows[i].Cells["dgv_promoted"].Value = true;
                }


                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void frmPromoteStudents_Load(object sender, EventArgs e)
        {
            try
            {
                ComboLevelFill();
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

                AccountLedgerInfo studentInfo = new AccountLedgerInfo();
                StudentSP spStudent = new StudentSP();
                

                for (int i = 0; i < dgvPromotion.RowCount; i++)
                {

                    
                    DataGridViewCheckBoxCell chkchecking = dgvPromotion.Rows[i].Cells["dgv_promoted"] as DataGridViewCheckBoxCell;
                    
                    if (dgvPromotion.Rows[i].Cells["dgvtxtStudentId"].Value.ToString() != string.Empty && dgvPromotion.Rows[i].Cells["dgvtxtStudentId"].Value != null)
                    {

                      studentInfo.LedgerId =Convert.ToInt32(dgvPromotion.Rows[i].Cells["dgvtxtStudentId"].Value.ToString());
                    
                    }


                    if (Convert.ToInt32(chkchecking.Value) >= 1)
                    {
                        spStudent.PromotedStudentAdd(studentInfo);
                        Messages.SavedMessage();
                    }

                }


                



            }
            catch (Exception ex)
            {

                MessageBox.Show(" SaveFunction " + ex.Message);
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFunction();
        }




        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (cboClass.SelectedIndex == -1)
            {
                MessageBox.Show("Select a class");
                cboClass.Focus();
                
            }

            else
            {
                GridFillSearch();
            }
           
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminNumber.Text == string.Empty)
            {
                GridFillSearch();
            }

            else
            {
              FilterdgvledgerPopup();
            }
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }

        private void dgvPromotion_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvPromotion.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvPromotion.Columns[e.ColumnIndex]).Items.Contains(value))
                    {
                        e.ThrowException = false;
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
