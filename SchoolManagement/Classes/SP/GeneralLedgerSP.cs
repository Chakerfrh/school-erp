using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.General;


namespace SchoolManagement.Classes.SP


{
    class GeneralLedgerSP:DBConnection
    {

        ///<summary>
        ///Function to add values to tblGeneralLedger
        /// </summary>

        public void generaledgerAddAll(GeneraLedgerInfo generalLedgerInfo)
        {
            try
            {
         
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("generaledgerAddAll",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?transDate", MySqlDbType.DateTime);
                sqlparam.Value = generalLedgerInfo.TransDate;
                sqlparam = sqlcmd.Parameters.Add("?journalTypeId", MySqlDbType.Int32);
                sqlparam.Value = generalLedgerInfo.JournalTypeId;
                sqlparam = sqlcmd.Parameters.Add("?journalNo", MySqlDbType.Decimal);
                sqlparam.Value = generalLedgerInfo.JournalNo;
                sqlparam = sqlcmd.Parameters.Add("?ledgerId", MySqlDbType.Int32);
                sqlparam.Value = generalLedgerInfo.LedgerId;
                sqlparam = sqlcmd.Parameters.Add("?debit", MySqlDbType.Decimal);
                sqlparam.Value = generalLedgerInfo.Debit;
                sqlparam = sqlcmd.Parameters.Add("?credit", MySqlDbType.Decimal);
                sqlparam.Value = generalLedgerInfo.Credit;
                sqlparam = sqlcmd.Parameters.Add("?invoiceNo", MySqlDbType.VarChar);
                sqlparam.Value = generalLedgerInfo.InvoiceNo;
                sqlparam = sqlcmd.Parameters.Add("?chequeNo", MySqlDbType.VarChar);
                sqlparam.Value = generalLedgerInfo.ChequeNo;
                sqlparam = sqlcmd.Parameters.Add("?chequeDate", MySqlDbType.DateTime);
                sqlparam.Value = generalLedgerInfo.ChequeDate;
                sqlparam = sqlcmd.Parameters.Add("?extraDate", MySqlDbType.DateTime);
                sqlparam.Value = generalLedgerInfo.ExtraDate;
                sqlparam = sqlcmd.Parameters.Add("?extra1", MySqlDbType.VarChar);
                sqlparam.Value = generalLedgerInfo.Extra1;
                sqlparam = sqlcmd.Parameters.Add("?extra2", MySqlDbType.VarChar);
                sqlparam.Value = generalLedgerInfo.Extra2;
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



    }
}
