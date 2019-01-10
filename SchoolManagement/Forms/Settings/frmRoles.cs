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
using SchoolManagement.Settings;
using SchoolManagement.Classes.General;

namespace SchoolManagement.Forms.Settings
{
    public partial class frmRoles : Form
    {
        public frmRoles()
        {
            InitializeComponent();
        }

        #region PublicVeriable
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        decimal decRoleId;
        frmCreateUser frmUserCreationobj;
        #endregion



        /// <summary>
        /// Function to fill the controls
        /// </summary>
        public void FillControls()
        {
            try
            {
                RoleInfo roleinfo = new RoleInfo();
                RoleSP spRole = new RoleSP();
                roleinfo = spRole.RoleView(decRoleId);
                txtRole.Text = roleinfo.Role;
                txtNarration.Text = roleinfo.Narration;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }





        /// <summary>
        /// Function to fill the grid
        /// </summary>
        public void Gridfill()
        {
            try
            {
                DataTable dtbl = new DataTable();
                RoleSP spRole = new RoleSP();
                dtbl = spRole.RoleViewGridFill();
                dgvRole.DataSource = dtbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }




        /// <summary>
        /// Function to Clear the controls in form
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                txtRole.Clear();
                txtNarration.Clear();
                Gridfill();
                txtRole.Focus();
                btnSave.Text = "Save";
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public void EditFunction()
        {
            try
            {
                RoleInfo roleinfo = new RoleInfo();
                RoleSP rolesp = new RoleSP();
                roleinfo.Role = txtRole.Text.Trim();
                roleinfo.Narration = txtNarration.Text.Trim();
                rolesp.RoleUpdate(roleinfo,decRoleId);
                Messages.UpdatedMessage();
                ClearFunction();
                txtRole.Focus();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        public void SaveOrEdit()
        {

            if (txtRole.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a role");
                txtRole.Focus();
            }

            else if (txtNarration.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter a narration");
                txtNarration.Focus();
            }

            else
            {
                if (btnSave.Text == "Save")
                {
                    if (Messages.SaveMessage())
                    {
                        SaveFunction();
                        ClearFunction();
                        Gridfill();
                    }
                }

                else
                {
                    if (Messages.UpdateMessage())
                    {
                        EditFunction();
                        ClearFunction();
                        Gridfill();
                    }
                }

            }


        }




        public void SaveFunction()
        {
            try
            {

                RoleInfo infoRole = new RoleInfo();

                RoleSP spRole = new RoleSP();
                infoRole.Role = txtRole.Text.Trim();
                infoRole.Narration = txtNarration.Text.Trim();

                string strRole = txtRole.Text.Trim();

                decRoleId = spRole.RoleAdd(infoRole);
                Messages.SavedMessage();
                ClearFunction();
                txtRole.Focus();
               


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




        /// <summary>
        /// Function to call this form from frmUserCreation to view details and for updation
        /// </summary>
        /// <param name="frmUserCreation"></param>
        public void CallfrmCreateUser(frmCreateUser frmUserCreation)
        {
            try
            {
                dgvRole.Enabled = false;
                this.frmUserCreationobj =  frmUserCreation;
                base.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRoles_Load(object sender, EventArgs e)
        {
            try
            {
                Gridfill();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmRoles_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (frmUserCreationobj != null)
                {
                    frmUserCreationobj.ReturnFromRoleForm(decRoleId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRole_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {


                    decRoleId = Convert.ToDecimal(dgvRole.CurrentRow.Cells["dgvtxtRoleId"].Value);
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
                txtRole.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
