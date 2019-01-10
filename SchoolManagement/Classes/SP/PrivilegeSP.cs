using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SchoolManagement.Classes.General;

namespace SchoolManagement.Classes.SP
{
    class PrivilegeSP:DBConnection
    {

        /// <summary>
        /// This function To use the PrivilegeCheck
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="formName"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool PrivilegeCheck(decimal userId, string formName, string action)
        {
            bool isCheck = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string sql = "SELECT * FROM tblprivilege";

                MySqlCommand sqlCmd = new MySqlCommand(sql, sqlcon);
              
                sqlCmd.Parameters.Add("?S_userId", MySqlDbType.Decimal).Value = userId;
                sqlCmd.Parameters.Add("?S_formName", MySqlDbType.VarChar).Value = formName;
                sqlCmd.Parameters.Add("?S_action", MySqlDbType.VarChar).Value = action;
                object obj = sqlCmd.ExecuteScalar();
                if (obj != null)
                    isCheck = true;
                else
                    isCheck = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return isCheck;
        }




    }
}
