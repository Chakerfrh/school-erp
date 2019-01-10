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
    public partial class frmClass : Form
    {
        public frmClass()
        {
            InitializeComponent();
        }

        decimal classid;

       



        /// <summary>
        /// Function for Fill Controls
        /// </summary>

        public void FillControls()
        {
            StudentLevel studLevel = new StudentLevel();
            StudentClassSP studentClassSp = new StudentClassSP();
            studLevel = studentClassSp.StudentClassView(classid);
            txtClassNo.Text = Convert.ToString(studLevel.ClassNo);
            txtClassSection.Text = studLevel.ClassSection;
            
           
        }



        /// <summary>
        /// Function for Fill StudentGrid 
        /// </summary>
        public void GridFill()
        {
            DataTable dtbl = new DataTable();
            StudentClassSP studentsp = new StudentClassSP();
            dtbl = studentsp.FillGridClass();
            dgvClass.DataSource = dtbl;


        }


        public void ClearFunction()
        {
            txtClassNo.Clear();
            txtClassSection.Clear();
            btnSave.Text = "Save";
            txtClassNo.Focus();
          


        }

        /// <summary>
        /// Function for Save StudentInformation
        /// </summary>
        public void Save()
        {

            StudentLevel studLevel = new StudentLevel();
            StudentClassSP studentClassSp = new StudentClassSP();
            studLevel.ClassNo =Convert.ToInt32(txtClassNo.Text.Trim());
            studLevel.ClassSection = txtClassSection.Text.Trim();
            studentClassSp.InsertClass(studLevel);
            Messages.SavedMessage();
            GridFill();
            ClearFunction();


        }



        public void EditFuntion()
        {

            StudentLevel studLevel = new StudentLevel();
            StudentClassSP studentClassSp = new StudentClassSP();
            studLevel.ClassNo =Convert.ToInt32(txtClassNo.Text.Trim());
            studLevel.ClassSection = txtClassSection.Text.Trim();
            studentClassSp.UpdateStudentClass(studLevel,classid);
            Messages.UpdatedMessage();
            GridFill();
            ClearFunction();


        }



        public void SaveOrEdit()
        {
            if (txtClassNo.Text.Trim() == string .Empty)
            {
                MessageBox.Show("Enter Class Name");
            }

            else if (txtClassSection.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Class Section");
            }

            else
            {

                int parsedValue;
                if (!int.TryParse(txtClassNo.Text, out parsedValue))
                {
                    MessageBox.Show("Class No is expected to be a number");
                    txtClassNo.Focus();
                }

                if (int.Parse(txtClassNo.Text) > 8)
                {
                    MessageBox.Show("Class No is expected to be between 1 and 8");

                }

                // To Do: check if class exists

                else
                {
                    if (btnSave.Text == "Save")
                    {
                        if (Messages.SaveMessage())
                        {
                            Save();

                        }


                    }
                    else
                    {
                        if (Messages.UpdateMessage())
                        {
                            EditFuntion();
                        }


                    }
                }
                

            }

        }





        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void frmClass_Load(object sender, EventArgs e)
        {
            try
            {
                GridFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    classid = Convert.ToDecimal(dgvClass.CurrentRow.Cells["dgvtxtClassid"].Value);
                    
                    if (classid > 0)
                    {
                        
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

        
    }
}
