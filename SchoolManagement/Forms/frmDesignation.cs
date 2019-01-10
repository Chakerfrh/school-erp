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
    public partial class frmDesignation : Form
    {
        public frmDesignation()
        {
            InitializeComponent();
        }

        decimal designationId;


        public void FillControls()
        {
            DesignationSP designationSp = new DesignationSP();
            DesignationInfo designationInfo = new DesignationInfo();
            designationInfo = designationSp.DesignationViewOne(designationId);
            txtDesignationName.Text = designationInfo.Designation;
            txtDescription.Text = designationInfo.Description;


        }

        public void GridFill()
        {
            DataTable dt = new DataTable();
            DesignationSP designationSp = new DesignationSP();
            dt = designationSp.DesignationFillGrid();
            dgvDesignation.DataSource = dt;

        }


        public void ClearFunction()
        {
            txtDescription.Clear();
            txtDesignationName.Clear();
            btnSave.Text = "Save";
            txtDesignationName.Focus();
            
        }


        public void SaveFunction()
        {
            DesignationSP designationSp = new DesignationSP();
            DesignationInfo designationInfo = new DesignationInfo();
            designationInfo.Designation = txtDesignationName.Text.Trim();
            designationInfo.Description = txtDescription.Text.Trim();
            designationSp.DesignationAdd(designationInfo);
            Messages.SavedMessage();
            GridFill();
            ClearFunction();

        }


        public void EditFunction()
        {
            DesignationSP designationSp = new DesignationSP();
            DesignationInfo designationInfo = new DesignationInfo();
            designationInfo.Designation = txtDesignationName.Text.Trim();
            designationInfo.Description = txtDescription.Text.Trim();
            designationSp.DesignationUpdate(designationInfo,designationId);
            Messages.UpdatedMessage();
            GridFill();
            ClearFunction();
        }

        public void SaveOrEdit()
        {

            if (txtDesignationName.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter designation name");
            }

            else if (txtDescription.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter description");
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

        private void dgvDesignation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    designationId = Convert.ToDecimal(dgvDesignation.CurrentRow.Cells["dgvtxtDesignationId"].Value);
                    FillControls();
                    btnSave.Text = "Update";
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

                ClearFunction();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void frmDesignation_Load(object sender, EventArgs e)
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
    }
}
