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


namespace SchoolManagement.Forms
{
    public partial class frmLedgerPopup : Form
    {
        public frmLedgerPopup()
        {
            InitializeComponent();
        }

    
        int inCurrenRowIndex = 0;


        public void FilldgvLedgerPopup()
        {
            CommonSP spCommon = new CommonSP();
            DataTable dt = new DataTable();
            dt = spCommon.FilldgvLedgerPopup();
            dgvLedgerPopup.DataSource = dt;

        }


        /// <summary>
        /// Function to filter dgvStudent based on Search Item
        /// </summary>
        public void FilterdgvledgerPopup()
        {
            CommonSP spCommon = new CommonSP();
            dgvLedgerPopup.AutoGenerateColumns = false;
            DataTable dt = new DataTable();

            if (txtAdminNumber.Text != string.Empty)
            {
                dt = spCommon.filterDetailsFordgvLedgerPopup(Convert.ToString(txtAdminNumber.Text));
                dgvLedgerPopup.DataSource = dt;
            }
        }



        private void frmLedgerPopup_Load(object sender, EventArgs e)
        {
            FilldgvLedgerPopup();
        }

        private void txtAdminNumber_TextChanged(object sender, EventArgs e)
        {
            FilterdgvledgerPopup();
        }

        private void dgvLedgerPopup_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (dgvLedgerPopup.CurrentRow != null && dgvLedgerPopup.CurrentRow.Index != 0 || dgvLedgerPopup.CurrentRow != null && dgvLedgerPopup.CurrentRow.Index == 0)
                {
                    if (dgvLedgerPopup.CurrentCell != null && dgvLedgerPopup.CurrentCell.Value != null)
                    {
                       
                           frmFeeProcessing objEmployeeCreation = new frmFeeProcessing();
                            objEmployeeCreation.MdiParent = frmMDI.MDIObj;
                           frmFeeProcessing open = Application.OpenForms["frmFeeProcessing"] as frmFeeProcessing;
                            if (open == null)
                            {
                                objEmployeeCreation.WindowState = FormWindowState.Normal;
                                objEmployeeCreation.MdiParent = frmMDI.MDIObj;
                                objEmployeeCreation.CallFromLedgerPopup(decimal.Parse(dgvLedgerPopup.Rows[e.RowIndex].Cells["dgvtxtLedgerId"].Value.ToString()), this);
                            }
                            else
                            {
                                open.MdiParent = frmMDI.MDIObj;
                                open.BringToFront();
                                open.CallFromLedgerPopup(decimal.Parse(dgvLedgerPopup.Rows[e.RowIndex].Cells["dgvtxtLedgerId"].Value.ToString()), this);
                                if (open.WindowState == FormWindowState.Minimized)
                                {
                                    open.WindowState = FormWindowState.Normal;
                                }
                            }
                            inCurrenRowIndex = dgvLedgerPopup.CurrentRow.Index;
                            //this.Enabled = false;
                            this.Hide();
                    }
                }

            }
                    
         }










    }
}
