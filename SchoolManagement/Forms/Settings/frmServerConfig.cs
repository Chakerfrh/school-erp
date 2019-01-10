using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using SchoolManagement.Classes.General;
using MySql.Data.MySqlClient;
using SchoolManagement.Classes.SP;

namespace SchoolManagement.Settings
{
    public partial class frmServerConfig : Form
    {
        public frmServerConfig()
        {
            InitializeComponent();
        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void frmServerConfig_Load(object sender, EventArgs e)
        {
           
           
        }


        private void ConfigureDataBase(string serverName, string userId, string password)
        {
            ServerClass ClassS = new ServerClass();
            if (ClassS.CheckMySqlConnection(serverName, userId, password))
            {
                ClassS.UpdateAppConfig("MySqlServer", serverName);
                ClassS.UpdateAppConfig("MySqlUserId", userId);
                ClassS.UpdateAppConfig("MySqlPassword", password);
                //MessageBox.Show("Configuration was successfull");
                
            }
            else
            {
                MessageBox.Show("Sorry, Can't find your instance. Contact your administrator or try again.", "SchoolManagement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Text = "";
                txtServerName.Text = "";
                txtUserId.Text = "";
               
            }


        }



        /// <summary>
        /// Function for Check the Sql Path
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool CheckSqlPath(string ServerName, string UserId, string Password)
        {
            bool isTrue = false;
            ServerClass ClassS = new ServerClass();
            try
            {
                MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(string.Format("server={0};user id={1}; password={2};", ServerName, UserId, Password));
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand("SELECT @@basedir;", connection);
                object obj = command.ExecuteScalar();

                try
                {
                    ClassS.UpdateAppConfig("MySqlUrl", (obj != null) ? obj.ToString() : null);
                }
                catch { }

                MySql.Data.MySqlClient.MySqlCommand command1 = new MySql.Data.MySqlClient.MySqlCommand("select @@hostname;", connection);
                object obj1 = command1.ExecuteScalar();

                try
                {
                    ClassS.UpdateAppConfig("MySqlPathInstalledOn", (obj1 != null) ? obj1.ToString() : null);
                }
                catch { }

                isTrue = true;
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception)
            {
                isTrue = false;
            }
            return isTrue;
        }



        private void btnSave_Click(object sender, EventArgs e)
        {

            
            ConfigureDataBase(txtServerName.Text.Trim(), txtUserId.Text.Trim(), txtPassword.Text.Trim());

        }

     
    }
}
