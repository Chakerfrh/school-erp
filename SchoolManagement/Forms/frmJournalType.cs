using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;

namespace SchoolManagement.Forms
{
    public partial class frmJournalType : Form
    {
        public frmJournalType()
        {
            InitializeComponent();
        }


        decimal journalId;




        public void FillControls()
        {
            try
            {
                JournalTypeInfo journalTypeInfo = new JournalTypeInfo();
                JournalSP spJournal = new JournalSP();
                journalTypeInfo = spJournal.JournalTypeViewOne(journalId);
                txtJournalName.Text = journalTypeInfo.JournalTypeName;
                txtAbbreviation.Text = journalTypeInfo.Abbreviation;
                cbxActive.Checked =Convert.ToBoolean(journalTypeInfo.IsActive) ? true : false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        /// <summary>
        /// Functoion to fill the dgvJournalType
        /// </summary>
        public void FilldgvJournalType()
        {
            CommonSP spCommon = new CommonSP();
            DataTable dt = new DataTable();
            dt = spCommon.FilldgvJournalType();
            dgvJournalType.DataSource = dt;

        }
        /// <summary>
        /// Functoion to clear values
        /// </summary>

        public void ClearFunction()
        {
            txtAbbreviation.Clear();
            txtJournalName.Clear();
            cbxActive.Checked = false;
            FilldgvJournalType();
            txtJournalName.Focus();

        }


        public void SaveOrEdit()
        {

            try
            {

                if (txtJournalName.Text == string.Empty)
                {
                    MessageBox.Show("Enter a journal name");
                }

                else if (txtAbbreviation.Text == string.Empty)
                {
                    MessageBox.Show("Enter an abbreviation");
                }

                else
                {

                    JournalTypeInfo journalTypeInfo = new JournalTypeInfo();
                    JournalSP spJournal = new JournalSP();
                    journalTypeInfo.JournalTypeName = txtJournalName.Text.Trim();
                    journalTypeInfo.Abbreviation = txtAbbreviation.Text.Trim();
                    journalTypeInfo.Narration = txtNarration.Text.Trim();
                    journalTypeInfo.Heading1 = txtHeading1.Text.Trim();
                    journalTypeInfo.Heading2 = txtHeading2.Text.Trim();                   
                    journalTypeInfo.IsActive = cbxActive.Checked ? true : false;
                       
                   
                    if (btnSave.Text == "Save")
                    {
                        if (Messages.SaveConfirmation())
                        {

                            spJournal.JournalTypeAdd(journalTypeInfo);
                            Messages.SavedMessage();
                            ClearFunction();
                        }


                    }
                    else
                    {
                        if (Messages.UpdateMessage())
                        {

                            journalTypeInfo.JournalTypeId = journalId;
                            spJournal.JournalTypeUpdate(journalTypeInfo);
                            Messages.UpdatedMessage();
                            ClearFunction();
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



        private void frmJournalType_Load(object sender, EventArgs e)
        {
            ClearFunction(); 
        }



        private void dgvJournalType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex != -1)
                {
                    if (dgvJournalType.CurrentRow.Cells["dgvtxtvoucherTypeId"].Value != null && dgvJournalType.CurrentRow.Cells["dgvtxtvoucherTypeId"].Value.ToString() != string.Empty)
                    {
                        journalId = Convert.ToDecimal(dgvJournalType.CurrentRow.Cells["dgvtxtvoucherTypeId"].Value);
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
    }
}
