using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;

namespace SchoolManagement.Classes.SP
{
    class RoleSP: DBConnection
    {

        #region functions
        /// <summary>
        /// Function to insert values to Role Table
        /// </summary>
        /// <param name="infoRole"></param>
        /// <returns></returns>
        public decimal RoleAdd(RoleInfo infoRole)
        {
            decimal decRoleIdentity = 0;
            try
            {

             
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string sql = "INSERT INTO tblrole (role,narration) VALUES(@_role,@_narration)";

                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
         
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_role", MySqlDbType.VarChar);
                sprmparam.Value = infoRole.Role;
                sprmparam = sccmd.Parameters.Add("?_narration", MySqlDbType.Text);
                sprmparam.Value = infoRole.Narration;
               
                decRoleIdentity = Convert.ToDecimal(sccmd.ExecuteScalar());
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return decRoleIdentity;
        }



        /// <summary>
        /// Function to update values to Role Table
        /// </summary>
        /// <param name="infoRole"></param>
        /// <returns></returns>
       
        public void RoleUpdate(RoleInfo roleinfo,decimal roleId)
        {

          
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string sql = "UPDATE tblrole SET role=@_role,narration=@_narration WHERE roleId=@_roleId";
                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_role",MySqlDbType.VarChar);
                sprmparam.Value = roleinfo.Role;
                sprmparam = sccmd.Parameters.Add("?_narration", MySqlDbType.VarChar);
                sprmparam.Value = roleinfo.Narration;
                sprmparam = sccmd.Parameters.Add("?_roleId", MySqlDbType.Int32);
                sprmparam.Value = roleId;
                sccmd.ExecuteNonQuery();
              

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }


        /// <summary>
        /// Function to role details based on parameter
        /// </summary>
        /// <returns></returns>
         public RoleInfo RoleView(decimal roleid)
         {

            RoleInfo roleinfo = new RoleInfo();
            MySqlDataReader sdrreader = null;
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string sql = "SELECT * FROM tblrole WHERE roleId=@_roleId";
                MySqlCommand sccmd = new MySqlCommand(sql,sqlcon);
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_roleId", MySqlDbType.Int32);
                sprmparam.Value = roleid;
                sdrreader = sccmd.ExecuteReader();

                while (sdrreader.Read())
                {
                    roleinfo.Role = sdrreader[1].ToString();
                    roleinfo.Narration = sdrreader[2].ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sdrreader.Close();
                sqlcon.Close();
               
            }

            return roleinfo;
         }


        /// <summary>
        /// Function to get all role details
        /// </summary>
        /// <returns></returns>
        public DataTable RoleViewGridFill()
        {
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SlNo", typeof(int));
            dtbl.Columns["SlNo"].AutoIncrement = true;
            dtbl.Columns["SlNo"].AutoIncrementSeed = 1;
            dtbl.Columns["SlNo"].AutoIncrementStep = 1;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string sql = "SELECT * FROM tblrole";
                MySqlDataAdapter sdaadapter = new MySqlDataAdapter(sql, sqlcon);
                sdaadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }


        /// <summary>
        /// Function to get all the values from Role Table
        /// </summary>
        /// <returns></returns>
        public DataTable RoleViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string sql = "SELECT * FROM tblrole";
                MySqlDataAdapter sdaadapter = new MySqlDataAdapter(sql, sqlcon);
               
                sdaadapter.Fill(dtbl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return dtbl;
        }



        #endregion










    }
}
