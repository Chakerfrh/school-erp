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
    public partial class frmSalaryPackage : Form
    {
        public frmSalaryPackage()
        {
            InitializeComponent();
        }

        private void frmSalaryPackage_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///Function to Generate automatic journal_no no in the datagrid view column
        /// </summary>
        public void SlNo()
        {
            int inRowNo = 1;
            try
            {
                foreach (DataGridViewRow dr in dgvSalaryPackage.Rows)
                {
                    dr.Cells["dgvsno"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvSalaryPackage.Rows.Count - 2)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("JV11:" + ex.Message, "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Function to clear gatagrid rows after inserting data to database
        /// </summary>
        public void clearfielsd()
        {

            dgvSalaryPackage.Rows.Clear();




        }

        /// <summary>
        /// Function to remove_incomplete_rows fields from grid
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool remove_incomplete_rows()
        {
            bool isOk = true;
            try
            {

                string strMessage = "Row";
                int inC = 0, inForFirst = 0;
                int inRowcount = dgvSalaryPackage.RowCount;
                int inLastRow = 1;//To eliminate last row from checking
                foreach (DataGridViewRow dgvrowCur in dgvSalaryPackage.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.Cells["dgv_check"].Value.ToString() == "x" || dgvrowCur.Cells["dgvPayHead"].Value == null)
                        {
                            isOk = false;
                            if (inC == 0)
                            {
                                strMessage = strMessage + Convert.ToString(dgvrowCur.Index + 1);
                                inForFirst = dgvrowCur.Index;
                                inC++;
                            }
                            else
                            {
                                strMessage = strMessage + ", " + Convert.ToString(dgvrowCur.Index + 1);
                            }
                        }
                    }
                    inLastRow++;
                }
                inLastRow = 1;
                if (!isOk)
                {
                    strMessage = strMessage + " contains invalid entries. Do you want to continue?";
                    if (MessageBox.Show(strMessage, " Niambie School Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        isOk = true;
                        for (int inK = 0; inK < dgvSalaryPackage.Rows.Count; inK++)
                        {
                            if (dgvSalaryPackage.Rows[inK].Cells["dgv_check"].Value != null && dgvSalaryPackage.Rows[inK].Cells["dgv_check"].Value.ToString() == "x")
                            {
                                if (!dgvSalaryPackage.Rows[inK].IsNewRow)
                                {
                                    dgvSalaryPackage.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                       
                        dgvSalaryPackage.Focus();
                    }
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            return isOk;
        }





        public void SaveFunction()
        {

            try
            {

                SalaryPackageInfo salaryInfo = new SalaryPackageInfo();
                SalaryPackageSP salarySp = new SalaryPackageSP();


                for (int i = 0; i < dgvSalaryPackage.RowCount - 1; i++)
                {

                    if (dgvSalaryPackage.Rows[i].Cells["dgvPayHead"].Value.ToString() != string.Empty && dgvSalaryPackage.Rows[i].Cells["dgvPayHead"].Value != null)
                    {
                        salaryInfo.PayHead = Convert.ToString(dgvSalaryPackage.Rows[i].Cells["dgvPayHead"].Value);

                    }

                    if (dgvSalaryPackage.Rows[i].Cells["dgvPayType"].Value.ToString() != string.Empty && dgvSalaryPackage.Rows[i].Cells["dgvPayType"].Value != null)
                    {
                        salaryInfo.PayType = Convert.ToString(dgvSalaryPackage.Rows[i].Cells["dgvPayType"].Value);

                    }

                    if (dgvSalaryPackage.Rows[i].Cells["dgvAmount"].Value.ToString() != string.Empty && dgvSalaryPackage.Rows[i].Cells["dgvAmount"].Value != null)
                    {
                        salaryInfo.Amount = Convert.ToDecimal(dgvSalaryPackage.Rows[i].Cells["dgvAmount"].Value);

                    }

                    bool isCellChecked = (bool)dgvSalaryPackage.Rows[i].Cells["dgvtxtIsActive"].Value;

                    if (isCellChecked == true)
                    {
                        salaryInfo.IsActive = true;
                    }
                    else
                    {
                        salaryInfo.IsActive = false;
                    }


                    salarySp.SalaryPackageAdd(salaryInfo);

                }

                clearfielsd();
                Messages.SavedMessage();



            }
            catch (Exception ex)
            {

                MessageBox.Show(" SaveFunction " + ex.Message);
            }

        }






        public void SaveOrEdit()
        {
            try
            {


                // lblinfo.Text = "";
                if (remove_incomplete_rows())
                {
                    if (dgvSalaryPackage.Rows[0].Cells["dgvPayHead"].Value == null && dgvSalaryPackage.Rows[0].Cells["dgvPayType"].Value == null)
                    {

                        // lblinfo.Text = "Error! Can't save Transaction without complete entry";
                        MessageBox.Show("Can't save Transaction without complete entry", "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvSalaryPackage.ClearSelection();
                        dgvSalaryPackage.Focus();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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

        private void dgvSalaryPackage_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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

        private void dgvSalaryPackage_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvSalaryPackage.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvSalaryPackage.Columns[e.ColumnIndex]).Items.Contains(value))
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


        /// <summary>
        /// Function to fill the specified color on row enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSalaryPackage_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvSalaryPackage.Rows[e.RowIndex].Cells.Count; i++)
            {

                dgvSalaryPackage[i, e.RowIndex].Style.BackColor = Color.Azure;
            }
        }


        /// <summary>
        /// Function to check invalid entries in datagrid_view
        /// </summary>
        /// <param name="e"></param>
        public void check_invalid_entries(DataGridViewCellEventArgs e)
        {
            Boolean isvaluechanged = false;
            try
            {
                if (dgvSalaryPackage.CurrentRow != null)
                {



                    if (!isvaluechanged)
                    {
                        if (dgvSalaryPackage.CurrentRow.Cells["dgvPayHead"].Value == null || dgvSalaryPackage.CurrentRow.Cells["dgvPayHead"].Value.ToString().Trim() == "")
                        {
                            isvaluechanged = true;
                            dgvSalaryPackage.CurrentRow.HeaderCell.Value = "x";
                            dgvSalaryPackage.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isvaluechanged = true;
                            dgvSalaryPackage.CurrentRow.Cells["dgv_check"].Value = "x";
                            dgvSalaryPackage["dgv_check", e.RowIndex].Style.ForeColor = Color.Red;


                        }

                        else if (dgvSalaryPackage.CurrentRow.Cells["dgvPayType"].Value == null || dgvSalaryPackage.CurrentRow.Cells["dgvPayType"].Value.ToString().Trim() == "")
                        {
                            isvaluechanged = true;
                            dgvSalaryPackage.CurrentRow.HeaderCell.Value = "x";
                            dgvSalaryPackage.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isvaluechanged = true;
                            dgvSalaryPackage.CurrentRow.Cells["dgv_check"].Value = "x";
                            dgvSalaryPackage["dgv_check", e.RowIndex].Style.ForeColor = Color.Red;
                        }

                        else
                        {
                            isvaluechanged = true;
                            dgvSalaryPackage.CurrentRow.HeaderCell.Value = "";
                            isvaluechanged = true;
                            dgvSalaryPackage.CurrentRow.Cells["dgv_check"].Value = "";
                        }



                    }

                    isvaluechanged = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        private void dgvSalaryPackage_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                check_invalid_entries(e);




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
