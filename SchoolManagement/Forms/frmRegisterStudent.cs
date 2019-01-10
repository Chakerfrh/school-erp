using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Classes.SP;
using System.IO;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.General;

namespace SchoolManagement
{
    public partial class frmStudentRegister : Form 
    {
        public frmStudentRegister()
        {
            InitializeComponent();
        }


        #region Public Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        string photoPath = null;
        public decimal studentId;
        public decimal balance = 0;
        #endregion





        public void ComboLevelFill()
        {
            try
            {
                StudentSP stud = new StudentSP();
                DataTable dt = new DataTable();
                dt  = stud.FillStudentClass();
                cboLevel.DataSource = dt;
                cboLevel.ValueMember = "ClassNo";
                cboLevel.DisplayMember = "ClassNo";
                cboLevel.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        public void ComboSearchFill()
        {
            try
            {
                StudentSP stud = new StudentSP();
                DataTable dt = new DataTable();
                dt = stud.FillStudentClass();
                cboSearch.DataSource = dt;
                cboSearch.ValueMember = "ClassNo";
                cboSearch.DisplayMember = "ClassNo";
                cboSearch.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        /// <summary>
        /// Function to fill the values in curresponding controls for updation
        /// </summary>
        public void FillControls()
        {
            try
            {

                AccountLedgerInfo student = new AccountLedgerInfo();
                StudentSP studentSP = new StudentSP();
                student = studentSP.StudentView(studentId);

                if (student.Active)
                {
                    cbxActive.Checked = true;
                }
                else
                {
                    cbxActive.Checked = false;
                }

               
                txtFirstName.Text = student.LedgerName;
                txtLastName.Text = student.OtherName;
                txtDateOfBirth.Text = student.DateOfBirth.ToString("dd-MMM-yyyy");

                txtPhone.Text = student.HomePhone;
                txtEmail.Text = student.Email;

                txtAdmision.Text = student.AdminNumber;
                cboLevel.SelectedValue = student.ClassNo;
                txtDateJoined.Text = student.DateJoined.ToString("dd-MMM-yyyy");
                cboGender.SelectedItem = student.Gender;
     

                txtOpeningBalance.Text =Convert.ToString(student.OpeningBalance);
                cmbDrorCr.SelectedItem = student.CrOrDr;
                

                if (student.Photo != string.Empty && student.Photo != null)
                {
                   
                    photoPath = student.Photo;
                    pictureBox.Image = Image.FromFile(photoPath);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pictureBox.Image = null;
                }


                txtGuardianName.Text = student.GuardianName;
                txtGuardianEmail.Text = student.GuardianEmail;
                txtRelatioship.Text = student.GuardianRelationship;
                txtGuardianPhone.Text = student.GuardianPhone;

            }
            catch (Exception ex)
            {

                MessageBox.Show( "FillControlMthd "+ ex.Message);
            }


        }

        /// <summary>
        /// Function to clear the controls in form
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                txtFirstName.Clear();
                txtLastName.Clear();
               

                txtPhone.Clear();
                txtEmail.Clear();
                txtOpeningBalance.Clear();
                txtAdmision.Clear();
                cboLevel.SelectedIndex = -1;
               

                pictureBox.Image=null;
               

                txtGuardianName.Clear();
                txtGuardianEmail.Clear();
                txtRelatioship.Clear();
                txtGuardianPhone.Clear();
                btnSave.Text = "Save";

                txtFirstName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Student Creation GridFill
        /// </summary>
        public void GridFill()
        {
            try
            {
                StudentSP spStudent = new StudentSP();
                DataTable dtblStudentCreation = new DataTable();
                dtblStudentCreation = spStudent.StudentCreationViewForGridFill();
                dgvStudent.DataSource = dtblStudentCreation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Student Creation GridFill
        /// </summary>
        public void GridFillSearch()
        {
            try
            {

               int search_item = Convert.ToInt32(cboSearch.SelectedValue.ToString());
                StudentSP spStudent = new StudentSP();
                DataTable dtblStudentCreation = new DataTable();
                dtblStudentCreation = spStudent.StudentSearchViewForGridFill(search_item);
                dgvStudent.DataSource = dtblStudentCreation;
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


                if (cboLevel.SelectedIndex==-1)
                {
                    MessageBox.Show("Select a class");
                    cboLevel.Focus();
                }

                else if (txtFirstName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter FirstName");
                    txtFirstName.Focus();
                }
                else if (txtLastName.Text.Trim()== string.Empty)
                {
                    MessageBox.Show("Enter OtherName");
                    txtLastName.Focus();
                }

                else if (txtAdmision.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter Admission Number");
                    txtAdmision.Focus();
                }

                else if (cboGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Select a Gender");
                    cboGender.Focus();
                }

               
                else
                {

                    AccountLedgerInfo student = new AccountLedgerInfo();
                    StudentSP studentSP = new StudentSP();
                    if (cbxActive.Checked)
                    {
                        student.Active = true;
                    }
                    else
                    {
                        student.Active = false;
                    }

                    student.AccountGroupId = 15;
                    student.CrOrDr = cmbDrorCr.Text.Trim();
             

                    student.LedgerName = txtFirstName.Text.Trim();
                    student.OtherName = txtLastName.Text.Trim();
                    student.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text.Trim());
                    student.OpeningBalance = txtOpeningBalance.Text.Trim() == string.Empty? balance : Convert.ToDecimal(txtOpeningBalance.Text.Trim());
                    student.HomePhone = txtPhone.Text.Trim();
                    student.Email = txtEmail.Text.Trim();
                    student.Gender = cboGender.SelectedItem.ToString();

                    student.AdminNumber = txtAdmision.Text.Trim();
                    student.ClassNo = Convert.ToInt32(cboLevel.SelectedValue.ToString());
                    student.DateJoined = Convert.ToDateTime(txtDateJoined.Text.Trim());
                    student.Photo = photoPath;

                    student.GuardianName = txtGuardianName.Text.Trim();
                    student.GuardianEmail = txtGuardianEmail.Text.Trim();
                    student.GuardianRelationship = txtRelatioship.Text.Trim();
                    student.GuardianPhone = txtGuardianPhone.Text.Trim();

                   
                    if (btnSave.Text == "Save")
                    {
                        if (Messages.SaveMessage())
                        {
                            studentSP.StudentAdd(student);
                            Messages.SavedMessage();
                            ClearFunction();
                            txtFirstName.Focus();
                        }

                    }
                    else
                    {

                        if (Messages.UpdateMessage())
                        {
                            studentSP.StudentEdit(student, studentId);
                            Messages.UpdatedMessage();
                            ClearFunction();
                            txtFirstName.Focus();
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
        /// Function to fill dgvStudent based on txtSearch
        /// </summary>
        public void fill_update_transactions_grid()
        {
            StudentSP studSp = new StudentSP();
            dgvStudent.AutoGenerateColumns = false;
            DataTable dt2 = new DataTable();
           
            dt2 = studSp.get_student_details(Convert.ToString(txtSearch.Text));
            dgvStudent.DataSource = dt2;


        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void btnBrowsePhoto_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\StudentImages\"; 
            if (Directory.Exists(appPath) == false)                                              
            {                                                                                   
                Directory.CreateDirectory(appPath);                                              
            }                                                                                   

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;
                    string filepath = opFile.FileName;
                  
                    File.Copy(filepath, appPath + iName);
                    pictureBox.Image = new Bitmap(opFile.OpenFile());
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    photoPath = appPath + iName;
                   
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to open file " + ex.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void frmStudentRegister_Load(object sender, EventArgs e)
        {
            try
            {
                ComboLevelFill();
                ComboSearchFill();
                //GridFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {


                    studentId = Convert.ToDecimal(dgvStudent.CurrentRow.Cells["dgvtxtStudentId"].Value);
                    FillControls();
                    btnSave.Text = "Update";
                  
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
                cboLevel.SelectedIndex = -1;
                ClearFunction();
               
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridFillSearch();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            fill_update_transactions_grid();
        }

        
    }
}
