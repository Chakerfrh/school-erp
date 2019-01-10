using System;
using System.Windows.Forms;
using System.Data;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;



using SchoolManagement.Forms.Settings;


namespace SchoolManagement.Settings
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }

        #region Public Variables
        /// <summary>
        /// Public variable Declaration Part
        /// </summary>
        
        decimal decUserId;
        string strRole;
        #endregion


        /// <summary>
        /// Function to fill the Role ComboFill
        /// </summary>
        public void RoleComboFill()
        {
            try
            {
                RoleSP spRole = new RoleSP();
                DataTable dtblRoleCombo = new DataTable();
                dtblRoleCombo = spRole.RoleViewAll();
                cmbRole.DataSource = dtblRoleCombo;
                cmbRole.ValueMember = "roleId";
                cmbRole.DisplayMember = "role";
                cmbRole.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



        



        /// <summary>
        /// Save Function
        /// </summary>
        private void SaveFunction()
        {
            try
            {
                UserInfo infoUser = new UserInfo();

                UserSp spUser = new UserSp();
                
                infoUser.UserName = txtUserName.Text.Trim();
                infoUser.Password = txtPassword.Text.Trim();
                if (cbxActive.Checked)
                {
                    infoUser.Active = true;
                }
                else
                {
                    infoUser.Active = false;
                }
                infoUser.RoleId = Convert.ToDecimal(cmbRole.SelectedValue);
                infoUser.Narration = txtNarration.Text.Trim();
               
                string strUserName = txtUserName.Text.Trim();
                if (spUser.UserCreationCheckExistence(decUserId, strUserName) == false)
                {
                    spUser.UserAdd(infoUser);
                    Messages.SavedMessage();
                    ClearFunction();
                    GridFill();
                    txtUserName.Focus();
                }
                else
                {
                    MessageBox.Show("User name already exists");
                    txtUserName.Focus();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Update Function
        /// </summary>
        public void EditFunction()
        {
            try
            {
                UserInfo infoUser = new UserInfo();
                UserSp spUser = new UserSp();
                infoUser.UserId = Convert.ToDecimal(dgvUserCreation.CurrentRow.Cells["dgvtxtUserId"].Value);
                infoUser.UserName = txtUserName.Text.Trim();
                infoUser.Password = txtPassword.Text.Trim();
                if (cbxActive.Checked)
                {
                    infoUser.Active = true;
                }
                else
                {
                    infoUser.Active = false;
                }
                infoUser.RoleId = Convert.ToDecimal(cmbRole.SelectedValue);
                infoUser.Narration = txtNarration.Text.Trim();
               
                string strUserName = txtUserName.Text.Trim();
                if (spUser.UserCreationCheckExistence(decUserId, strUserName) == false)
                {
                    spUser.UserEdit(infoUser);
                    Messages.UpdatedMessage();
                    ClearFunction();
                    GridFill();
                    txtUserName.Focus();
                }
                else
                {
                    MessageBox.Show("User name already exists");
                    txtUserName.Focus();
                }
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
                if (txtUserName.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter username");
                    txtUserName.Focus();
                }
                else if (txtPassword.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("Enter password");
                    txtPassword.Focus();
                }
                else if (txtPassword.Text != txtRetype.Text)
                {
                    MessageBox.Show("Password and confirm password should match");
                    txtRetype.Focus();
                    txtRetype.Clear();
                }
                else if (cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Select role");
                    cmbRole.Focus();
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

        /// <summary>
        /// Function to clear the controls in form
        /// </summary>
        public void ClearFunction()
        {
            try
            {
                txtUserName.Clear();
                cmbRole.SelectedIndex = -1;
                txtPassword.Clear();
                txtRetype.Clear();
                txtNarration.Clear();
                btnSave.Text = "Save";
                btnDelete.Enabled = false;
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// User Creation GridFill
        /// </summary>
        public void GridFill()
        {
            try
            {
                UserSp spUser = new UserSp();
                DataTable dtblUserCreation = new DataTable();
                dtblUserCreation = spUser.UserCreationViewForGridFill();
                dgvUserCreation.DataSource = dtblUserCreation;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Delete Function
        /// </summary>
        public void DeleteFunction()
        {

            bool isMessageDelete = true;
            try
            {
                if (isMessageDelete)
                {
                    if (Messages.DeleteMessage())
                    {
                        UserInfo infoUser = new UserInfo();
                        UserSp spUser = new UserSp();
                        if ((spUser.UserCreationReferenceDelete(decUserId) == -1))
                        {
                            Messages.ReferenceExistsMessage();
                        }
                        else
                        {
                            Messages.DeletedMessage();
                            btnSave.Text = "Save";
                            btnDelete.Enabled = false;
                            ClearFunction();
                            GridFill();
                        }
                    }
                }
                else
                {
                    UserInfo infoUser = new UserInfo();
                    UserSp spUser = new UserSp();
                    if ((spUser.UserCreationReferenceDelete(decUserId) == -1))
                    {
                        Messages.ReferenceExistsMessage();
                    }
                    else
                    {
                        Messages.DeletedMessage();
                        btnSave.Text = "Save";
                        btnDelete.Enabled = false;
                        ClearFunction();
                    }
                }
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
              
                UserInfo infoUser = new UserInfo();
                UserSp spUser = new UserSp();
                infoUser = spUser.UserView(decUserId);
                txtUserName.Text = infoUser.UserName;
                txtPassword.Text = infoUser.Password;
                cmbRole.SelectedValue = infoUser.RoleId;
                txtNarration.Text = infoUser.Narration;
                if (infoUser.Active)
                {
                    cbxActive.Checked = true;
                }
                else
                {
                    cbxActive.Checked = false;
                }
                txtRetype.Text = txtPassword.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        /// <summary>
        /// Function to fill Role combobox while return from Role creation when creating new Role 
        /// </summary>
        /// <param name="decRoleId"></param>
        public void ReturnFromRoleForm(decimal decRoleId)
        {
            try
            {
                RoleComboFill();
                if (decRoleId != 0)
                {
                    cmbRole.SelectedValue = decRoleId.ToString();
                }
                else if (strRole != string.Empty)
                {
                    cmbRole.SelectedValue = strRole;
                }
                else
                {
                    cmbRole.SelectedIndex = -1;
                }
                this.Enabled = true;
                cmbRole.Focus();
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

        private void btnRoleAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRole.SelectedValue != null)
                {
                    strRole = cmbRole.SelectedValue.ToString();
                }
                else
                {
                    strRole = string.Empty;
                }
                frmRoles Roleobj = new frmRoles();
               // Roleobj.MdiParent = frmMDI.MDIObj;
                Roleobj.CallfrmCreateUser(this);
                this.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            try
            {
                if (cbxActive.Checked == false)
                {
                    cbxActive.Checked = true;
                }
                btnDelete.Enabled = false;
           
                GridFill();
                RoleComboFill();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void dgvUserCreation_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {

                    
                    decUserId = Convert.ToDecimal(dgvUserCreation.CurrentRow.Cells["dgvtxtUserId"].Value);
                    FillControls();
                    btnSave.Text = "Update";
                    btnDelete.Enabled = true;
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
                cmbRole.SelectedIndex = -1;
                ClearFunction();
                txtUserName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
               
               DeleteFunction();
               
               
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
