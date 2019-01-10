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
    class AccountLedgerSP:DBConnection
    {

        ///<summary>
        ///Function to add values to tblAccountLedger
        /// </summary>

        public void AccountLedgerAdd(AccountLedgerInfo accountLedgerInfo)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("AccountLedgerAdd", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?ledgerName", MySqlDbType.VarChar);
                sqlparam.Value = accountLedgerInfo.LedgerName;
                sqlparam = sqlcmd.Parameters.Add("?accountGroupId", MySqlDbType.Decimal);
                sqlparam.Value = accountLedgerInfo.AccountGroupId;
                sqlparam = sqlcmd.Parameters.Add("?openingBalance", MySqlDbType.Decimal);
                sqlparam.Value = accountLedgerInfo.OpeningBalance;
                sqlparam = sqlcmd.Parameters.Add("?crOrDr", MySqlDbType.VarChar);
                sqlparam.Value = accountLedgerInfo.CrOrDr;
                sqlparam = sqlcmd.Parameters.Add("?active", MySqlDbType.Bit);
                sqlparam.Value = accountLedgerInfo.Active;
                sqlcmd.ExecuteNonQuery();


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


        ///<summary>
        ///Function to update values to tblAccountLedger
        /// </summary>

        public void AccountLedgerUpdate(AccountLedgerInfo accountLedgerInfo)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("AccountLedgerUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?ledgerId", MySqlDbType.VarChar);
                sqlparam.Value = accountLedgerInfo.LedgerId;
                sqlparam = sqlcmd.Parameters.Add("?ledgerName", MySqlDbType.VarChar);
                sqlparam.Value = accountLedgerInfo.LedgerName;
                sqlparam = sqlcmd.Parameters.Add("?accountGroupId", MySqlDbType.Decimal);
                sqlparam.Value = accountLedgerInfo.AccountGroupId;
                sqlparam = sqlcmd.Parameters.Add("?openingBalance", MySqlDbType.Decimal);
                sqlparam.Value = accountLedgerInfo.OpeningBalance;
                sqlparam = sqlcmd.Parameters.Add("?crOrDr", MySqlDbType.VarChar);
                sqlparam.Value = accountLedgerInfo.CrOrDr;
                sqlparam = sqlcmd.Parameters.Add("?active", MySqlDbType.Bit);
                sqlparam.Value = accountLedgerInfo.Active;
                sqlcmd.ExecuteNonQuery();



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




        ///<summary>
        ///Function to get values from tblAccountLedger based on parameter
        ///<param name="ledgerId"  ></param>
        /// </summary>
        public AccountLedgerInfo AccountLedgerViewOne(decimal ledgerId)
        {

            AccountLedgerInfo accountLedgerInfo = new AccountLedgerInfo();
            MySqlDataReader sqlreader = null;
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("AccountLedgerViewOne", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?ledgerId", MySqlDbType.Int32);
                sqlparam.Value = ledgerId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    accountLedgerInfo.LedgerName = sqlreader["ledgerName"].ToString();
                    accountLedgerInfo.OpeningBalance = Convert.ToDecimal(sqlreader["openingBalance"].ToString());
                    accountLedgerInfo.CrOrDr = sqlreader["crOrDr"].ToString();
                    accountLedgerInfo.AccountGroupId =Convert.ToDecimal(sqlreader["accountGroupId"].ToString());
                    accountLedgerInfo.Active =bool.Parse(sqlreader["active"].ToString());
                   


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


            return accountLedgerInfo;

        }



        /// <summary>
        /// Function to get all the values from account ledger table
        /// </summary>
        /// <returns></returns>
        public DataTable AccountLedgerViewAll()
        {
            DataTable dtbl = new DataTable();
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlDataAdapter sdaadapter = new MySqlDataAdapter("AccountLedgerViewAll", sqlcon);
                sdaadapter.SelectCommand.CommandType = CommandType.StoredProcedure;
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









    }
}
