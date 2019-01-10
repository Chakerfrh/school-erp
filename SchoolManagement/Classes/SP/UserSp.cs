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
    class UserSp: DBConnection
    {

     
        #region function
        /// <summary>
        /// Function to insert values to account group Table
        /// </summary>
        /// <param name="userinfo"></param>
        public void UserAdd(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string sql = "INSERT INTO tblusers (username,password,active,roleId,narration) VALUES(@_userName,@_password,@_active,@_roleId,@_narration);";
                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_userName", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("?_password", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
                sprmparam = sccmd.Parameters.Add("?_active", MySqlDbType.Bit);
                sprmparam.Value = userinfo.Active;
                sprmparam = sccmd.Parameters.Add("?_roleId", MySqlDbType.Decimal);
                sprmparam.Value = userinfo.RoleId;
                sprmparam = sccmd.Parameters.Add("?_narration", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.Narration;
               
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
        /// Function to Update values in account group Table
        /// </summary>
        /// <param name="userinfo"></param>
        public void UserEdit(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string sql = "UPDATE tblusers SET username=@_userName,password=@_password,active=@_active,roleId=@_roleId,narration=@_narration WHERE userId=@_userId;";
                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
             
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_userId", MySqlDbType.Int32);
                sprmparam.Value = userinfo.UserId;
                sprmparam = sccmd.Parameters.Add("?_userName", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("?_password", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
                sprmparam = sccmd.Parameters.Add("?_active", MySqlDbType.Bit);
                sprmparam.Value = userinfo.Active;
                sprmparam = sccmd.Parameters.Add("?_roleId", MySqlDbType.Int32);
                sprmparam.Value = userinfo.RoleId;
                sprmparam = sccmd.Parameters.Add("?_narration", MySqlDbType.Text);
                sprmparam.Value = userinfo.Narration;
               
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
        /// Function to get particular values from account group table based on the parameter
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public UserInfo UserView(decimal userId)
        {
            UserInfo userinfo = new UserInfo();
            MySqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
               
               
                 string sql = "SELECT * FROM tblusers WHERE (userId=@_userId);";
                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
           
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_userId", MySqlDbType.Int32);
                sprmparam.Value = userId;
                sdrreader = sccmd.ExecuteReader();

                while (sdrreader.Read())
                {

                    
                    userinfo.UserId = decimal.Parse(sdrreader[0].ToString());
                    userinfo.UserName = sdrreader[1].ToString();
                    userinfo.Password = sdrreader[2].ToString();
                    userinfo.RoleId = decimal.Parse(sdrreader[3].ToString());
                    userinfo.Narration = sdrreader[4].ToString();
                    userinfo.Active = bool.Parse(sdrreader[5].ToString());


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
            return userinfo;
        }




        /// <summary>
        /// Function for check refernce and delete based on parameter
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public decimal UserCreationReferenceDelete(decimal userId)
        {
            decimal decUser = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string sql = "DELETE FROM tblusers WHERE(userId=@_userId);";
                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
            
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_userId", MySqlDbType.Int32);
                sprmparam.Value = userId;
                decUser = Convert.ToDecimal(sccmd.ExecuteNonQuery().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return decUser;
        }



        /// <summary>
        /// Function to check existence of User based on parameter
        /// </summary>
        /// <param name="decUserId"></param>
        /// <param name="strUserName"></param>
        /// <returns></returns>
        public bool UserCreationCheckExistence(decimal decUserId, string strUserName)
        {
            bool isEdit = false;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                string sql = "SELECT userId,username FROM tblusers WHERE(userId=@_userId AND username=@_username)";
                MySqlCommand sqlcmd = new MySqlCommand(sql, sqlcon);
      
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sqlcmd.Parameters.Add("?_userId", MySqlDbType.Decimal);
                sprmparam.Value = decUserId;
                sprmparam = sqlcmd.Parameters.Add("?_userName", MySqlDbType.VarChar);
                sprmparam.Value = strUserName;
                object obj = sqlcmd.ExecuteScalar();
                if (obj != null)
                {
                    if (int.Parse(obj.ToString()) == 1)
                    {
                        isEdit = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
            return isEdit;
        }
        /// <summary>
        /// Function to view all details from user Table based on parameter
        /// </summary>
        /// <returns></returns>
        public DataTable UserCreationViewForGridFill()
        {
            DataTable dtbluser = new DataTable();
            dtbluser.Columns.Add("SL.NO", typeof(decimal));
            dtbluser.Columns["SL.NO"].AutoIncrement = true;
            dtbluser.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbluser.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {
                string sql = "SELECT tblrole.role,tblusers.userId,tblusers.username FROM tblrole INNER JOIN tblusers ON tblrole.roleId =tblusers.roleId;";
                
                MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, sqlcon);
                sqlda.Fill(dtbluser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();

            }

            return dtbluser;
        }





        /// <summary>
        ///  //To access the database  with correct login credentials
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        public int accessdb(UserInfo userInfo)
        {

             int counter = 0;
             MySqlDataReader sdrreader = null;
             if (sqlcon.State == ConnectionState.Closed)
             {
                 sqlcon.Open();
             }

             try
             {
                 string sql = "SELECT * FROM tblusers WHERE (username=@user AND password=@paswrd);";
                 MySqlCommand cmd = new MySqlCommand(sql,sqlcon);
                 MySqlParameter sprmparam = new MySqlParameter();

                 sprmparam = cmd.Parameters.Add("@paswrd", MySqlDbType.VarChar);
                 sprmparam.Value = userInfo.Password;
                 sprmparam = cmd.Parameters.Add("@user", MySqlDbType.VarChar);
                 sprmparam.Value = userInfo.UserName;
                 sdrreader = cmd.ExecuteReader();

                 while (sdrreader.Read())
                 {
                     counter += 1;
                 }



             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }

             finally
             {

                 sqlcon.Close();
                 sdrreader.Close();

             }


             return counter;
             

        }








        /// <summary>
        /// Function to Update password
        /// </summary>
        /// <param name="userinfo"></param>
        public void ChangePasswordEdit(UserInfo userinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                string sql = "UPDATE tblusers SET username=@_userName,password=@_password WHERE userId=@_userId;";

                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
      
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?S_userId", MySqlDbType.Decimal);
                sprmparam.Value = userinfo.UserId;
                sprmparam = sccmd.Parameters.Add("?S_userName", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.UserName;
                sprmparam = sccmd.Parameters.Add("?S_password", MySqlDbType.VarChar);
                sprmparam.Value = userinfo.Password;
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
        #endregion
    }
}
