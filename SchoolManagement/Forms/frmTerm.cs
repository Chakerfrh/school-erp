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
    public partial class frmTerm : Form
    {
        public frmTerm()
        {
            InitializeComponent();
        }



        decimal termId;

        public void GridFill()
        {
            DataTable dt = new DataTable();
            TermSP termSp = new TermSP();
            dt = termSp.TermViewGridFill();
            dgvTerm.DataSource = dt;


        }


        public void ClearFunction()
        {

            txtTerm.Clear();
            txtdatePicker1.Text = "";
            txtdatePicker2.Text = "";
            btnSave.Text = "Save";
        }

        public void FillControls()
        {
            TermInfo termInfo = new TermInfo();
            TermSP termSp = new TermSP();
            termInfo = termSp.TermViewOne(termId);
            txtTerm.Text = termInfo.TermName;
            txtdatePicker1.Text = termInfo.DateStart.ToString();
            txtdatePicker2.Text = termInfo.DateEnd.ToString();


        }

        public void SaveFunction()
        {

            TermInfo termInfo = new TermInfo();
            TermSP termSp = new TermSP();
            termInfo.TermName = txtTerm.Text.Trim();
            termInfo.DateStart =Convert.ToDateTime( txtdatePicker1.Text.Trim().ToString());
            termInfo.DateEnd = Convert.ToDateTime(txtdatePicker2.Text.Trim().ToString());
            termSp.TermAdd(termInfo);
            Messages.SavedMessage();
            ClearFunction();
            GridFill();

        }



        public void EditFunction()
        {

            TermInfo termInfo = new TermInfo();
            TermSP termSp = new TermSP();
            termInfo.TermName = txtTerm.Text.Trim();
            termInfo.DateStart = Convert.ToDateTime(txtdatePicker1.Text.Trim().ToString());
            termInfo.DateEnd = Convert.ToDateTime(txtdatePicker2.Text.Trim().ToString());
            termSp.TermUpdate(termInfo,termId);
            Messages.UpdatedMessage();
            ClearFunction();
            GridFill();
        }

        public void SaveOrEdit()
        {

            try
            {

                if (txtTerm.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter Term");
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();
        }

        private void dgvTerm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            termId = Convert.ToDecimal(dgvTerm.CurrentRow.Cells["dgvTermId"].Value.ToString());
            FillControls();
            btnSave.Text = "Update";
        }

        private void frmTerm_Load(object sender, EventArgs e)
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
