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
using SchoolManagement.Classes.SP;

namespace SchoolManagement.Classes.General
{
    class FillComboBoxes:DBConnection
    {

        /// <summary>
        /// Function to fill AccountLedgers for combobox
        /// </summary>
        /// <returns></returns>
        public DataTable AccountLedgerComboFill()
        {
            DataTable dtbl = new DataTable();
            try
            {
                AccountLedgerSP spaccountledger = new AccountLedgerSP();
                dtbl = spaccountledger.AccountLedgerViewAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("legerdComboFill:" + ex.Message, "Niambie School ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return dtbl;
        }


        /// <summary>
        /// Function to fill All cash/Bank ledgers for Combobox
        /// </summary>
        /// <param name="isAll"></param>
        /// <returns></returns>
        public DataTable BankOrCashComboFill(bool isAll)
        {
            DataTable dtbl = new DataTable();
            MySqlDataAdapter sdaadapter = new MySqlDataAdapter("CashOrBankComboFill", sqlcon);
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
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
