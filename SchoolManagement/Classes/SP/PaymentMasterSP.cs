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
    class PaymentMasterSP:DBConnection
    {
        /// <summary>
        /// Function to insert values to PaymentMaster Table
        /// </summary>
        /// <param name="paymentmasterinfo"></param>
        /// <returns></returns>
        public decimal PaymentMasterAdd(PaymentMasterInfo paymentmasterinfo)
        {
            decimal decPaymentMasterId = 0;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlCommand sccmd = new MySqlCommand("PaymentMasterAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?S_voucherNo", MySqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.VoucherNo;
                sprmparam = sccmd.Parameters.Add("?S_invoiceNo", MySqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.InvoiceNo;
                sprmparam = sccmd.Parameters.Add("?S_suffixPrefixId", MySqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.SuffixPrefixId;
                sprmparam = sccmd.Parameters.Add("?S_date", MySqlDbType.DateTime);
                sprmparam.Value = paymentmasterinfo.Date;
                sprmparam = sccmd.Parameters.Add("?S_ledgerId", MySqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.LedgerId;
                sprmparam = sccmd.Parameters.Add("?S_totalAmount", MySqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.TotalAmount;
                sprmparam = sccmd.Parameters.Add("?S_narration", MySqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Narration;
                sprmparam = sccmd.Parameters.Add("?S_voucherTypeId", MySqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.VoucherTypeId;
                sprmparam = sccmd.Parameters.Add("?S_userId", MySqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.UserId;
                sprmparam = sccmd.Parameters.Add("?S_financialYearId", MySqlDbType.Decimal);
                sprmparam.Value = paymentmasterinfo.FinancialYearId;
                sprmparam = sccmd.Parameters.Add("?S_extra1", MySqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("?S_extra2", MySqlDbType.VarChar);
                sprmparam.Value = paymentmasterinfo.Extra2;
                decPaymentMasterId = Convert.ToDecimal(sccmd.ExecuteScalar().ToString());
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            finally
            {
                sqlcon.Close();
            }
            return decPaymentMasterId;
        }
    }
}
