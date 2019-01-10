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
    public partial class frmGrading : Form
    {
        public frmGrading()
        {
            InitializeComponent();
        }


        decimal classId;


        public void FillComboClass()
        {
            CommonSP stud = new CommonSP();
            DataTable dt = new DataTable();
            dt = stud.FillStudentClassCombo();
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            cmbClass.DataSource = dt;
            cmbClass.ValueMember = "ClassNo";
            cmbClass.DisplayMember = "ClassNo";
            cmbClass.SelectedIndex = -1;
            cmbStudent.SelectedIndex = -1;
        }

        public void FillComboStudent()
        {
            CommonSP stud = new CommonSP();
            DataTable dt = new DataTable();
            dt = stud.FillStudents(classId);
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            cmbStudent.DataSource = dt;
            cmbStudent.ValueMember = "ledgerId";
            cmbStudent.DisplayMember = "ledgerName";


        }

        public void FillComboTerm()
        {
            CommonSP stud = new CommonSP();
            DataTable dt = new DataTable();
            dt = stud.FillTermCombo();
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            cmbTerm.DataSource = dt;
            cmbTerm.ValueMember = "term_id";
            cmbTerm.DisplayMember = "term_name";

        }


        public void FillDgvSubjectsCombo()
        {
            CommonSP stud = new CommonSP();
            DataTable dt = new DataTable();
            dt = stud.FillSubjectsCombo();
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);

            dgvsubject.DataSource = dt;
            dgvsubject.ValueMember = "subject_id";
            dgvsubject.DisplayMember = "subjectName";

        }



        /// <summary>
        ///Function to Generate automatic journal_no no in the datagrid view column
        /// </summary>
        public void SlNo()
        {
            int inRowNo = 1;
            try
            {
                foreach (DataGridViewRow dr in dgvGrading.Rows)
                {
                    dr.Cells["dgvSno"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvGrading.Rows.Count - 2)
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
        /// Function to check invalid entries in datagrid_view
        /// </summary>
        /// <param name="e"></param>
        public void check_invalid_entries(DataGridViewCellEventArgs e)
        {
            Boolean isvaluechanged = false;
            try
            {
                if (dgvGrading.CurrentRow != null)
                {



                    if (!isvaluechanged)
                    {
                        if (dgvGrading.CurrentRow.Cells["dgvsubject"].Value == null || dgvGrading.CurrentRow.Cells["dgvsubject"].Value.ToString().Trim() == "")
                        {
                            isvaluechanged = true;
                            dgvGrading.CurrentRow.HeaderCell.Value = "x";
                            dgvGrading.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isvaluechanged = true;
                            dgvGrading.CurrentRow.Cells["dgv_check"].Value = "x";
                            dgvGrading["dgv_check", e.RowIndex].Style.ForeColor = Color.Red;


                        }

                        else if (dgvGrading.CurrentRow.Cells["dgvmarks"].Value == null || dgvGrading.CurrentRow.Cells["dgvmarks"].Value.ToString().Trim() == "" || Convert.ToDecimal(dgvGrading.CurrentRow.Cells["dgvmarks"].Value.ToString()) > 100)
                        {
                            isvaluechanged = true;
                            dgvGrading.CurrentRow.HeaderCell.Value = "x";
                            dgvGrading.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isvaluechanged = true;
                            dgvGrading.CurrentRow.Cells["dgv_check"].Value = "x";
                            dgvGrading["dgv_check", e.RowIndex].Style.ForeColor = Color.Red;
                        }

                        else
                        {
                            isvaluechanged = true;
                            dgvGrading.CurrentRow.HeaderCell.Value = "";
                            isvaluechanged = true;
                            dgvGrading.CurrentRow.Cells["dgv_check"].Value = "";
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






        /// <summary>
        /// Function to clear gatagrid rows after inserting data to database
        /// </summary>
        public void clearfielsd()
        {

            dgvGrading.Rows.Clear();




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
                int inRowcount = dgvGrading.RowCount;
                int inLastRow = 1;//To eliminate last row from checking
                
                foreach (DataGridViewRow dgvrowCur in dgvGrading.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.Cells["dgv_check"].Value.ToString() == "x" || dgvrowCur.Cells["dgvsubject"].Value == null)
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
                        for (int inK = 0; inK < dgvGrading.Rows.Count; inK++)
                        {
                            if (dgvGrading.Rows[inK].Cells["dgv_check"].Value != null && dgvGrading.Rows[inK].Cells["dgv_check"].Value.ToString() == "x")
                            {
                                if (!dgvGrading.Rows[inK].IsNewRow)
                                {
                                    dgvGrading.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvGrading.Rows[inForFirst].Cells["dgvsubject"].Selected = true;
                        dgvGrading.CurrentCell = dgvGrading.Rows[inForFirst].Cells["dgvsubject"];
                        dgvGrading.Focus();
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

            GradingSP gradingSP = new GradingSP();
            GradingInfo gradingInfo = new GradingInfo();

            try
            {

                for (int i = 0; i < dgvGrading.RowCount-1; i++)
                {
                    if (dgvGrading.Rows[i].Cells["dgvsubject"].Value.ToString() != string.Empty && dgvGrading.Rows[i].Cells["dgvsubject"].Value != null)
                    {
                        gradingInfo.SubjectId = Convert.ToInt32(dgvGrading.Rows[i].Cells["dgvsubject"].Value);
                    }

                    if (dgvGrading.Rows[i].Cells["dgvmarks"].Value.ToString() != string.Empty && dgvGrading.Rows[i].Cells["dgvmarks"].Value != null)
                    {
                        gradingInfo.Marks = Convert.ToInt32(dgvGrading.Rows[i].Cells["dgvmarks"].Value);
                    }

                    gradingInfo.TermId = Convert.ToInt32(cmbTerm.SelectedValue);
                    gradingInfo.ClassId = Convert.ToInt32(cmbClass.SelectedValue);
                    gradingInfo.StudentId = Convert.ToInt32(cmbStudent.SelectedValue);

                  
                    gradingSP.GradingAdd(gradingInfo);

                }

                clearfielsd();
                Messages.SavedMessage();
               
               


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }



        public void SaveOrEdit()
        {
            try
            {

                if (cmbStudent.SelectedIndex <= -1)
                {
                    MessageBox.Show("Select a student");
                }

                else
                {


                    // lblinfo.Text = "";
                    if (remove_incomplete_rows())
                    {
                        if (dgvGrading.Rows[0].Cells["dgvsubject"].Value == null && dgvGrading.Rows[0].Cells["dgvmarks"].Value == null)
                        {

                            // lblinfo.Text = "Error! Can't save Transaction without complete entry";
                            MessageBox.Show("Can't save Transaction without complete entry", "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvGrading.ClearSelection();
                            dgvGrading.Focus();
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClass.SelectedIndex > -1 && cmbClass.SelectedValue != null && cmbClass.SelectedValue.ToString() != string.Empty)
            {

                if (cmbClass.SelectedValue.ToString() != "System.Data.DataRowView" && cmbClass.Text != "System.Data.DataRowView")
                {
                    classId = Convert.ToDecimal(cmbClass.SelectedValue.ToString());
                    FillComboStudent();


                }

            }
        }

        private void frmGrading_Load(object sender, EventArgs e)
        {
            try
            {
                FillComboClass();
                FillComboTerm();
                FillDgvSubjectsCombo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGrading_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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

        /// Function to check invalid entries on cell changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGrading_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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


        /// <summary>
        ///  dgvGrading grid cell begin edit for Combo box subject fill and remove from the list once it has selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvGrading_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dgvGrading.RowCount > 1)
                {
                    DataTable dtbl = new DataTable();
                    CommonSP subjectsSp = new CommonSP();
                  
                    if (dgvGrading.CurrentCell.ColumnIndex == dgvGrading.Columns["dgvsubject"].Index)
                    {
                        dtbl = subjectsSp.FillSubjectsCombo();
                        if (dtbl.Rows.Count > 0)
                        {
                            if (dgvGrading.RowCount > 1)
                            {
                                int inGridRowCount = dgvGrading.RowCount;
                                for (int inI = 0; inI < inGridRowCount - 1; inI++)
                                {
                                    if (inI != e.RowIndex)
                                    {
                                        int inTableRowcount = dtbl.Rows.Count;
                                        for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                        {
                                            if (dgvGrading.Rows[inI].Cells["dgvsubject"].Value != null && dgvGrading.Rows[inI].Cells["dgvsubject"].Value.ToString() != string.Empty)
                                            {
                                                if (dtbl.Rows[inJ]["subject_id"].ToString() == dgvGrading.Rows[inI].Cells["dgvsubject"].Value.ToString())
                                                {
                                                    dtbl.Rows.RemoveAt(inJ);
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            DataGridViewComboBoxCell dgvccSubject = (DataGridViewComboBoxCell)dgvGrading[dgvGrading.Columns["dgvsubject"].Index, e.RowIndex];
                            dgvccSubject.DataSource = dtbl;
                            dgvccSubject.ValueMember = "subject_id";
                            dgvccSubject.DisplayMember = "subjectName";
                        }
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
