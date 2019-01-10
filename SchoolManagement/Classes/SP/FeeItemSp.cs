using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;


namespace SchoolManagement.Classes.SP
{
    class FeeItemSp : DBConnection
    {


        /// <summary>
        /// Function to add values into tblfeeitem
        /// </summary>

        public void FeeItemAdd(FeeItemInfo feeItemInfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("FeeItemAdd",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?feeTitle",MySqlDbType.VarChar);
                sqlparam.Value = feeItemInfo.FeeTitle;
                sqlparam = sqlcmd.Parameters.Add("?classNo", MySqlDbType.Int32);
                sqlparam.Value = feeItemInfo.ClassId;
                sqlparam = sqlcmd.Parameters.Add("?termId", MySqlDbType.Int32);
                sqlparam.Value = feeItemInfo.TermId;
                sqlparam = sqlcmd.Parameters.Add("?active", MySqlDbType.Bit);
                sqlparam.Value = feeItemInfo.Active;
                sqlparam = sqlcmd.Parameters.Add("?amount", MySqlDbType.Decimal);
                sqlparam.Value = feeItemInfo.FeeAmount;
                sqlcmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        /// <summary>
        /// Function to update values in tblfeeitem
        /// </summary>

        public void FeeItemUpdate(FeeItemInfo feeItemInfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("FeeItemUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?feeItemId", MySqlDbType.Int32);
                sqlparam.Value = feeItemInfo.FeeItemId;
                sqlparam = sqlcmd.Parameters.Add("?feeTitle", MySqlDbType.VarChar);
                sqlparam.Value = feeItemInfo.FeeTitle;
                sqlparam = sqlcmd.Parameters.Add("?classNo", MySqlDbType.Int32);
                sqlparam.Value = feeItemInfo.ClassId;
                sqlparam = sqlcmd.Parameters.Add("?termId", MySqlDbType.Int32);
                sqlparam.Value = feeItemInfo.TermId;
                sqlparam = sqlcmd.Parameters.Add("?active", MySqlDbType.Bit);
                sqlparam.Value = feeItemInfo.Active;
                sqlparam = sqlcmd.Parameters.Add("?amount", MySqlDbType.Decimal);
                sqlparam.Value = feeItemInfo.FeeAmount;
                sqlcmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }







        // <summary>
        /// Function to fill datatable for dgvFeeItem
        /// </summary>
        public DataTable FillDataGridViewFeeItem()
        {
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(int));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("FeeItemViewAll", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dtbl);
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


        // <summary>
        /// Function to fill datatable for dgvFeeItem
        /// </summary>
        public FeeItemInfo FillDataGridViewFeeItemOne(decimal feeItemid)
        {
            FeeItemInfo feeItemInfo = new FeeItemInfo();
            MySqlDataReader sqlreader = null;

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("FillDataGridViewFeeItemOne",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("feeItemId",MySqlDbType.Int32);
                sqlparam.Value = feeItemid;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    feeItemInfo.FeeTitle = sqlreader["feeTitle"].ToString();
                    feeItemInfo.ClassId = Convert.ToDecimal(sqlreader["classNo"].ToString());
                    feeItemInfo.TermId = Convert.ToDecimal(sqlreader["termId"].ToString());
                    feeItemInfo.Active =bool.Parse(sqlreader["active"].ToString());
                    feeItemInfo.FeeAmount = Convert.ToDecimal(sqlreader["feeAmount"].ToString());

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            return feeItemInfo;

        }











    }
}
