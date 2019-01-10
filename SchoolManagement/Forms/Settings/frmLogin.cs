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

namespace SchoolManagement.Settings
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }




        /// <summary>
        /// Function that validates user credentials
        /// </summary>
        public void _login()
        {


            UserInfo userinfo = new UserInfo();
            UserSp validate_user = new UserSp();

            userinfo.UserName = txtUserName.Text.Trim();
            userinfo.Password = txtPassword.Text.Trim();
            int dbresult = validate_user.accessdb(userinfo);

            if (txtPassword.Text.Length > 0 && txtUserName.Text.Length > 0)
            {
                if (dbresult == 1)
                {

                    frmMDI frm = new frmMDI();
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Wrong username or password", "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Focus();
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and Password values to continue", "Niambie School Management", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }



        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmServerConfig frmServer = new frmServerConfig();
            frmServer.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _login();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
            
                if (e.KeyCode == Keys.Enter)
                {
                    _login();
                }
               
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message);
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Application.Exit();



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
