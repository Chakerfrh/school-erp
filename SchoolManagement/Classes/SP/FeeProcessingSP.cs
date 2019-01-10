using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;


namespace SchoolManagement.Classes.SP
{
    class FeeProcessingSP:DBConnection
    {


        ///<summary>
        ///Function to fill the 
        /// </summary>

        public AccountLedgerInfo AccountLedgerViewFilter(decimal ledgerId)
        {

            AccountLedgerInfo ledgerInfo = new AccountLedgerInfo();
            MySqlDataReader sqlreader = null;
            try
            {
               

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("AccountLedgerViewFilter", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?ledgerId",MySqlDbType.Int32);
                sqlparam.Value = ledgerId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    ledgerInfo.LedgerName = sqlreader["ledgerName"].ToString();
                    ledgerInfo.OtherName = sqlreader["otherName"].ToString();
                    ledgerInfo.AdminNumber = sqlreader["adminNumber"].ToString();
                    ledgerInfo.Extra1 = sqlreader["classNo"].ToString();
                    ledgerInfo.ClassNo = Convert.ToInt32(sqlreader["classNo"].ToString());
                    ledgerInfo.HomePhone = sqlreader["homePhone"].ToString();
                    ledgerInfo.Email = sqlreader["email"].ToString();
                    ledgerInfo.OpeningBalance = Convert.ToDecimal(sqlreader["openingBalance"].ToString());


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

            return ledgerInfo;

        }


        ///<summary>
        ///Function get the openingBalance and fill txtOpeningBalance
        /// </summary>

        public FeeMasterInfo FeeMasterViewAmount(decimal ledgerId)
        {

            FeeMasterInfo feeInfo = new FeeMasterInfo();
            MySqlDataReader sqlreader = null;
            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("FeeMasterViewAmount", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?ledgerId", MySqlDbType.Int32);
                sqlparam.Value = ledgerId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {



                    feeInfo.Total=Convert.ToDecimal(sqlreader["total"].ToString());
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

            return feeInfo;

        }








    }
}
