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
    public partial class frmStudentImport : Form
    {
        public frmStudentImport()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files(*.xls;*.xlsx)|*.xls;*.xlsx";
                openFileDialog.Title = "Select an excel file";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txbExcelPath.Text = openFileDialog.FileName;
                }
            }
        }



        private void btnImport_Click(object sender, EventArgs e)
        {
            string sheetPath = txbExcelPath.Text;
            string sheetName = textSheetName.Text;

            DataTable dt = new DataTable();
            ExcelImport excelImport = new ExcelImport();
            dt = excelImport.FillDataFromExcelSheet(sheetPath, sheetName);

            //This loop Removes Null Or Empty DatatableRows
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                if (dt.Rows[i][1] == DBNull.Value)
                    dt.Rows[i].Delete();
            }
            dt.AcceptChanges();

            dataGridView1.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbExcelPath.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Browse for the excel path");
                txbExcelPath.Focus();
            }

            if (textSheetName.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter Sheet Name");
                textSheetName.Focus();
            }

            else
            {
              AccountLedgerInfo student = new AccountLedgerInfo();
                StudentSP studentSP = new StudentSP();

                int rowcounter = dataGridView1.RowCount;
                try
                {

                    for (int i = 0; i < rowcounter; i++)
                    {

                        if (dataGridView1.Rows[i].Cells["FirstName"].Value != null && dataGridView1.Rows[i].Cells["FirstName"].Value.ToString() != string.Empty)
                        {
                            student.LedgerName = Convert.ToString(dataGridView1.Rows[i].Cells["FirstName"].Value);
                        }

                        if (dataGridView1.Rows[i].Cells["LastName"].Value != null && dataGridView1.Rows[i].Cells["LastName"].Value.ToString() != string.Empty)
                        {
                            student.OtherName = Convert.ToString(dataGridView1.Rows[i].Cells["LastName"].Value);
                        }

                        if (dataGridView1.Rows[i].Cells["gender"].Value != null && dataGridView1.Rows[i].Cells["gender"].Value.ToString() != string.Empty)
                        {
                            student.Gender = Convert.ToString(dataGridView1.Rows[i].Cells["gender"].Value);
                        }

                        if (dataGridView1.Rows[i].Cells["dateOfBirth"].Value != null && dataGridView1.Rows[i].Cells["dateOfBirth"].Value.ToString() != string.Empty)
                        {
                            student.DateOfBirth = Convert.ToDateTime(dataGridView1.Rows[i].Cells["dateOfBirth"].Value.ToString());
                        }


                        if (dataGridView1.Rows[i].Cells["AdminNumber"].Value != null && dataGridView1.Rows[i].Cells["AdminNumber"].Value.ToString() != string.Empty)
                        {
                            student.AdminNumber = Convert.ToString(dataGridView1.Rows[i].Cells["AdminNumber"].Value);
                        }

                        if (dataGridView1.Rows[i].Cells["Class"].Value != null && dataGridView1.Rows[i].Cells["Class"].Value.ToString() != string.Empty)
                        {
                            student.ClassNo = Convert.ToInt32(dataGridView1.Rows[i].Cells["Class"].Value.ToString());
                        }

                        if (dataGridView1.Rows[i].Cells["AdmissionDate"].Value != null && dataGridView1.Rows[i].Cells["AdmissionDate"].Value.ToString() != string.Empty)
                        {
                            student.DateJoined = Convert.ToDateTime(dataGridView1.Rows[i].Cells["AdmissionDate"].Value);
                        }

                        student.AccountGroupId = 15;
                        student.CrOrDr = "Cr";
                        studentSP.StudentAdd(student);


                    }

                    MessageBox.Show("Saved succesfully");
                    btnSave.Enabled = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }

            
        }
    }
}
