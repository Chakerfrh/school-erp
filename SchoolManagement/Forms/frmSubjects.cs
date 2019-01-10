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
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.General;

namespace SchoolManagement.Forms
{
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }

        decimal subjectid;



        public void ClearFunction()
        {
            txtSubjectName.Clear();
            txtDescription.Clear();
            btnSave.Text = "Save";
            txtSubjectName.Focus();
           

        }

        public void FillControls()
        {
            SubjectSP subjectsp = new SubjectSP();
            SubjectsInfo subjectinfo = new SubjectsInfo();
            subjectinfo = subjectsp.SubjectViewOne(subjectid);
            txtSubjectName.Text = subjectinfo.SubjectName;
            txtDescription.Text = subjectinfo.SubjectDescription;


        }

       public void FillSubjectGrid()
        {
            DataTable dt = new DataTable();
            SubjectSP subjectsp = new SubjectSP();
            dt = subjectsp.SubjectGridFill();
            dgvSubjects.DataSource = dt;

        }


       public void SaveFunction()
        {
            SubjectSP subjectsp = new SubjectSP();
            SubjectsInfo subjectinfo = new SubjectsInfo();
            subjectinfo.SubjectName = txtSubjectName.Text.Trim();
            subjectinfo.SubjectDescription = txtDescription.Text.Trim();
            subjectsp.SubjectAdd(subjectinfo);
            Messages.SavedMessage();
            FillSubjectGrid();
            ClearFunction();
           
          


        }


        public void EditFunction()
        {
            SubjectSP subjectsp = new SubjectSP();
            SubjectsInfo subjectinfo = new SubjectsInfo();
            subjectinfo.SubjectName = txtSubjectName.Text.Trim();
            subjectinfo.SubjectDescription = txtDescription.Text.Trim();
            subjectsp.SubjectUpdate(subjectinfo,subjectid);
            Messages.UpdatedMessage();
            FillSubjectGrid();
            ClearFunction();
           
        }

        public void SaveOrEdit()
        {
            if (txtSubjectName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a Subject");
            }

            else if (txtDescription.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a Description");
            }

            else
            {
                if (btnSave.Text == "Save")
                {
                    if (Messages.SaveMessage())
                    {
                        SaveFunction();
                    }
                }
                else
                {
                    if (Messages.UpdateMessage())
                    {
                        EditFunction();
                    }
                }
               



            }

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void frmSubjects_Load(object sender, EventArgs e)
        {
            try
            {

                FillSubjectGrid();


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

        private void dgvSubjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvSubjects.CurrentRow.Cells["dgvSubjectId"].Value != null && dgvSubjects.CurrentRow.Cells["dgvSubjectId"].Value.ToString() != string.Empty)
                {
                    subjectid = Convert.ToDecimal(dgvSubjects.CurrentRow.Cells["dgvSubjectId"].Value);
                    FillControls();
                    btnSave.Text = "Update";
                }

            }
        }
    }
}
