using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;

namespace SchoolManagement.Classes.SP
{
    class AccountGroupSP:DBConnection
    {
        #region function
        /// <summary>
        /// Function to insert values to account group Table
        /// </summary>
        /// <param name="accountgroupinfo"></param>
        public void AccountGroupAdd(AccountGroupInfo accountgroupinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlCommand sccmd = new MySqlCommand("AccountGroupAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();
               
                sprmparam = sccmd.Parameters.Add("?accountName", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountName;
                sprmparam = sccmd.Parameters.Add("?accountCode", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountCode;
                sprmparam = sccmd.Parameters.Add("?accountGroup", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountGroup;
                sprmparam = sccmd.Parameters.Add("?accountSubGroup", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountSubGroup;
                sprmparam = sccmd.Parameters.Add("?narration", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("?isDefault", MySqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("?affects", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Affects;
                sprmparam = sccmd.Parameters.Add("?extraDate", MySqlDbType.DateTime);
                sprmparam.Value = accountgroupinfo.ExtraDate;

                sprmparam = sccmd.Parameters.Add("?extra1", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("?extra2", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra2;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("at here" + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }


        /// <summary>
        /// Function to update values to account group Table
        /// </summary>
        /// <param name="accountgroupinfo"></param>
    
        public void AccountGroupUpdate(AccountGroupInfo accountgroupinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlCommand sccmd = new MySqlCommand("AccountGroupUpdate", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?accountId", MySqlDbType.Int32);
                sprmparam.Value = accountgroupinfo.AccountId;
                sprmparam = sccmd.Parameters.Add("?accountName", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountName;
                sprmparam = sccmd.Parameters.Add("?accountCode", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountCode;
                sprmparam = sccmd.Parameters.Add("?accountGroup", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountGroup;
                sprmparam = sccmd.Parameters.Add("?accountSubGroup", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.AccountSubGroup;
                sprmparam = sccmd.Parameters.Add("?narration", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Narration;
                sprmparam = sccmd.Parameters.Add("?isDefault", MySqlDbType.Bit);
                sprmparam.Value = accountgroupinfo.IsDefault;
                sprmparam = sccmd.Parameters.Add("?affects", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Affects;
                sprmparam = sccmd.Parameters.Add("?extraDate", MySqlDbType.DateTime);
                sprmparam.Value = accountgroupinfo.ExtraDate;

                sprmparam = sccmd.Parameters.Add("?extra1", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("?extra2", MySqlDbType.VarChar);
                sprmparam.Value = accountgroupinfo.Extra2;
                sccmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("at here" + ex.Message);
            }
            finally
            {
                sqlcon.Close();
            }
        }










        /// <summary>
        ///  Function to get all the values from account group table for combobox fill
        /// </summary>
        /// <returns></returns>
        public DataTable AccountGroupViewAllComboFill()
        {
            DataTable dt = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("AccountGroupViewAllComboFill", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            return dt;
        }



        /// <summary>
        /// Function to get values from tblAccountGroup  based on the Search parameter
        /// </summary>
        /// <param name="strAccountGroupName"></param>
        /// <param name="strGroupUnder"></param>
        /// <returns></returns>
        public DataTable AccountGroupSearch(string strAccountGroupName, string strGroupUnder)
        {
            DataTable dtblAccountGroup = new DataTable();
            dtblAccountGroup.Columns.Add("Sl No", typeof(int));
            dtblAccountGroup.Columns["Sl No"].AutoIncrement = true;
            dtblAccountGroup.Columns["Sl No"].AutoIncrementSeed = 1;
            dtblAccountGroup.Columns["Sl No"].AutoIncrementStep = 1;

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlDataAdapter sqlda = new MySqlDataAdapter("AccountGroupSearch", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("?p_AccountName", MySqlDbType.VarChar).Value = strAccountGroupName;
                sqlda.SelectCommand.Parameters.Add("?p_Under", MySqlDbType.VarChar).Value = strGroupUnder;
                sqlda.Fill(dtblAccountGroup);


            }
            catch (Exception)
            {

                throw;
            }

            return dtblAccountGroup;
        }



        /// <summary>
        /// Function to get values from accountGroupTable based on parameter
        /// </summary>
        /// <param name="accountId"></param>
        /// <returns></returns>

        public AccountGroupInfo AccountGroupViewOne(decimal accountId)
        {

            AccountGroupInfo infoAccountGroup = new AccountGroupInfo();
            MySqlDataReader sqlreader = null;
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("AccountGroupViewOne", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?accountId",MySqlDbType.Int32);
                sqlparam.Value = accountId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    infoAccountGroup.AccountName = sqlreader["accountName"].ToString();
                    infoAccountGroup.AccountGroup = sqlreader["accountGroup"].ToString();
                    infoAccountGroup.AccountSubGroup = sqlreader["accountSubGroup"].ToString();
                    infoAccountGroup.AccountCode = sqlreader["accountCode"].ToString();
                    infoAccountGroup.Affects = sqlreader["affects"].ToString();
                    infoAccountGroup.IsDefault = bool.Parse(sqlreader["isDefault"].ToString());

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlreader.Close();
                sqlcon.Close();
            }

            return infoAccountGroup;
        }



        #endregion

    }
}
