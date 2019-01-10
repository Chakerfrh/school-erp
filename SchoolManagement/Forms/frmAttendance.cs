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
    public partial class frmAttendance : Form
    {



        public frmAttendance()
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
        }




        public void FillComboStudent()
        {
            CommonSP stud = new CommonSP();
            DataTable dt = new DataTable();
            dt = stud.FillStudents(classId);
            DataRow drow = dt.NewRow();
            dt.Rows.InsertAt(drow, 0);
        
            dgvcmbstudent.DataSource = dt;
            dgvcmbstudent.ValueMember = "ledgerId";
            dgvcmbstudent.DisplayMember = "ledgerName";
            
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



        /// <summary>
        ///Function to Generate automatic journal_no no in the datagrid view column
        /// </summary>
        public void SlNo()
        {
            int inRowNo = 1;
            try
            {
                foreach (DataGridViewRow dr in dgvAttendance.Rows)
                {
                    dr.Cells["dgvsno"].Value = inRowNo;
                    inRowNo++;
                    if (dr.Index == dgvAttendance.Rows.Count - 2)
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

            dgvAttendance.Rows.Clear();




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
                int inRowcount = dgvAttendance.RowCount;
                int inLastRow = 1;//To eliminate last row from checking
                foreach (DataGridViewRow dgvrowCur in dgvAttendance.Rows)
                {
                    if (inLastRow < inRowcount)
                    {
                        if (dgvrowCur.Cells["dgv_check"].Value.ToString() == "x" || dgvrowCur.Cells["dgvcmbstudent"].Value == null)
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
                        for (int inK = 0; inK < dgvAttendance.Rows.Count; inK++)
                        {
                            if (dgvAttendance.Rows[inK].Cells["dgv_check"].Value != null && dgvAttendance.Rows[inK].Cells["dgv_check"].Value.ToString() == "x")
                            {
                                if (!dgvAttendance.Rows[inK].IsNewRow)
                                {
                                    dgvAttendance.Rows.RemoveAt(inK);
                                    inK--;
                                }
                            }
                        }
                    }
                    else
                    {
                        dgvAttendance.Rows[inForFirst].Cells["dgvcmbstudent"].Selected = true;
                        dgvAttendance.CurrentCell = dgvAttendance.Rows[inForFirst].Cells["dgvcmbstudent"];
                        dgvAttendance.Focus();
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

                AttendanceInfo attendanceInfo = new AttendanceInfo();
                AttendanceSP attendanceSp = new AttendanceSP();


                for (int i = 0; i < dgvAttendance.RowCount-1; i++)
                {

                    if (dgvAttendance.Rows[i].Cells["dgvcmbstudent"].Value.ToString() != string.Empty && dgvAttendance.Rows[i].Cells["dgvcmbstudent"].Value != null)
                    {
                        attendanceInfo.StudentId = Convert.ToInt32(dgvAttendance.Rows[i].Cells["dgvcmbstudent"].Value);
                       
                    }

                    if (dgvAttendance.Rows[i].Cells["dgvstatus"].Value.ToString() != string.Empty && dgvAttendance.Rows[i].Cells["dgvstatus"].Value != null)
                    {
                        attendanceInfo.Status = Convert.ToString(dgvAttendance.Rows[i].Cells["dgvstatus"].Value);
                       
                    }

                    attendanceInfo.Date = Convert.ToDateTime(datePicker.Text);
                  
                    attendanceInfo.ClassId = Convert.ToInt32(cmbClass.SelectedValue);
                
                    attendanceInfo.TermId = Convert.ToInt32(cmbTerm.SelectedValue);
               

                    attendanceSp.AttendanceAdd(attendanceInfo);

                }

                clearfielsd();
                Messages.SavedMessage();
              


            }
            catch (Exception ex)
            {

                MessageBox.Show( " SaveFunction " + ex.Message);
            }

        }


        public void SaveOrEdit()
        {
            try
            {


               // lblinfo.Text = "";
                if (remove_incomplete_rows())
                {
                    if (dgvAttendance.Rows[0].Cells["dgvcmbstudent"].Value == null && dgvAttendance.Rows[0].Cells["dgvstatus"].Value == null)
                    {

                       // lblinfo.Text = "Error! Can't save Transaction without complete entry";
                        MessageBox.Show("Can't save Transaction without complete entry", "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvAttendance.ClearSelection();
                        dgvAttendance.Focus();
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
            SaveOrEdit();
        }


        private void frmAttendance_Load(object sender, EventArgs e)
        {
            try
            {

              FillComboClass();
             
              FillComboTerm();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
            
        }

        private void dgvAttendance_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
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



        /// <summary>
        /// Function to check invalid entries in datagrid_view
        /// </summary>
        /// <param name="e"></param>
        public void check_invalid_entries(DataGridViewCellEventArgs e)
        {
            Boolean isvaluechanged = false;
            try
            {
                if (dgvAttendance.CurrentRow != null)
                {



                    if (!isvaluechanged)
                    {
                        if (dgvAttendance.CurrentRow.Cells["dgvcmbstudent"].Value == null || dgvAttendance.CurrentRow.Cells["dgvcmbstudent"].Value.ToString().Trim() == "")
                        {
                            isvaluechanged = true;
                            dgvAttendance.CurrentRow.HeaderCell.Value = "x";
                            dgvAttendance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isvaluechanged = true;
                            dgvAttendance.CurrentRow.Cells["dgv_check"].Value = "x";
                            dgvAttendance["dgv_check", e.RowIndex].Style.ForeColor = Color.Red;


                        }

                        else if (dgvAttendance.CurrentRow.Cells["dgvstatus"].Value == null || dgvAttendance.CurrentRow.Cells["dgvstatus"].Value.ToString().Trim() == "")
                        {
                            isvaluechanged = true;
                            dgvAttendance.CurrentRow.HeaderCell.Value = "x";
                            dgvAttendance.CurrentRow.HeaderCell.Style.ForeColor = Color.Red;
                            isvaluechanged = true;
                            dgvAttendance.CurrentRow.Cells["dgv_check"].Value = "x";
                            dgvAttendance["dgv_check", e.RowIndex].Style.ForeColor = Color.Red;
                        }
                      
                        else
                        {
                            isvaluechanged = true;
                            dgvAttendance.CurrentRow.HeaderCell.Value = "";
                            isvaluechanged = true;
                            dgvAttendance.CurrentRow.Cells["dgv_check"].Value = "";
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

        private void dgvAttendance_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    object value = dgvAttendance.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    if (!((DataGridViewComboBoxColumn)dgvAttendance.Columns[e.ColumnIndex]).Items.Contains(value))
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
        private void dgvAttendance_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvAttendance.Rows[e.RowIndex].Cells.Count; i++)
            {

                dgvAttendance[i, e.RowIndex].Style.BackColor = Color.Azure;
            }
        }


        /// <summary>
        /// Function to remove color on leaving of grid column
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAttendance_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvAttendance.Rows[e.RowIndex].Cells.Count; i++)
            {
                dgvAttendance[i, e.RowIndex].Style.BackColor = Color.Empty;
            }
        }


        /// Function to check invalid entries on cell changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAttendance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
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
        ///  dgvAttendance grid cell begin edit for Combo box student fill and remove from the list once it has selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAttendance_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if (dgvAttendance.RowCount > 1)
                {
                    DataTable dtbl = new DataTable();
                    CommonSP studentSp = new CommonSP();

                    if (dgvAttendance.CurrentCell.ColumnIndex == dgvAttendance.Columns["dgvcmbstudent"].Index)
                    {
                        dtbl = studentSp.FillStudents(classId);
                        if (dtbl.Rows.Count > 0)
                        {
                            if (dgvAttendance.RowCount > 1)
                            {
                                int inGridRowCount = dgvAttendance.RowCount;
                                for (int inI = 0; inI < inGridRowCount - 1; inI++)
                                {
                                    if (inI != e.RowIndex)
                                    {
                                        int inTableRowcount = dtbl.Rows.Count;
                                        for (int inJ = 0; inJ < inTableRowcount; inJ++)
                                        {
                                            if (dgvAttendance.Rows[inI].Cells["dgvcmbstudent"].Value != null && dgvAttendance.Rows[inI].Cells["dgvcmbstudent"].Value.ToString() != string.Empty)
                                            {
                                                if (dtbl.Rows[inJ]["ledgerId"].ToString() == dgvAttendance.Rows[inI].Cells["dgvcmbstudent"].Value.ToString())
                                                {
                                                    dtbl.Rows.RemoveAt(inJ);
                                                    break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            DataGridViewComboBoxCell dgvccStudent = (DataGridViewComboBoxCell)dgvAttendance[dgvAttendance.Columns["dgvcmbstudent"].Index, e.RowIndex];
                            dgvccStudent.DataSource = dtbl;
                            dgvccStudent.ValueMember = "ledgerId";
                            dgvccStudent.DisplayMember = "ledgerName";
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
