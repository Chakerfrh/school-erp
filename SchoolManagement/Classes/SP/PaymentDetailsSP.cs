using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;

namespace SchoolManagement.Classes.SP
{
    class PaymentDetailsSP:DBConnection
    {
        /// <summary>
        /// Function to insert values to PaymentDetails Table
        /// </summary>
        /// <param name="paymentdetailsinfo"></param>
        /// <returns></returns>
        public decimal PaymentDetailsAdd(PaymentDetailsInfo paymentdetailsinfo)
        {
            decimal decPaymentDetailsId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlCommand sccmd = new MySqlCommand("PaymentDetailsAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?S_paymentMasterId", MySqlDbType.Decimal);
                sprmparam.Value = paymentdetailsinfo.PaymentMasterId;
                sprmparam = sccmd.Parameters.Add("?S_ledgerId", MySqlDbType.Decimal);
                sprmparam.Value = paymentdetailsinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("?S_amount", MySqlDbType.Decimal);
                sprmparam.Value = paymentdetailsinfo.Amount;
                sprmparam = sccmd.Parameters.Add("?S_exchangeRateId", MySqlDbType.Decimal);
                sprmparam.Value = paymentdetailsinfo.ExchangeRateId;
                sprmparam = sccmd.Parameters.Add("?S_chequeNo", MySqlDbType.VarChar);
                sprmparam.Value = paymentdetailsinfo.ChequeNo;
                sprmparam = sccmd.Parameters.Add("?S_chequeDate", MySqlDbType.DateTime);
                sprmparam.Value = paymentdetailsinfo.ChequeDate;
                sprmparam = sccmd.Parameters.Add("?S_extra1", MySqlDbType.VarChar);
                sprmparam.Value = paymentdetailsinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("?S_extra2", MySqlDbType.VarChar);
                sprmparam.Value = paymentdetailsinfo.Extra2;
                decPaymentDetailsId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                sqlcon.Close();
            }
            return decPaymentDetailsId;
        }
    }
}
