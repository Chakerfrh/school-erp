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
    class SalaryPackageSP : DBConnection
    {

        /// <summary>
        /// Function to insert data in tblsalaryPackage
        /// </summary>
        public void SalaryPackageAdd(SalaryPackageInfo salaryInfo)
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sccmd = new MySqlCommand("SalaryPackageAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?PayHead", MySqlDbType.VarChar);
                sprmparam.Value = salaryInfo.PayHead;
                sprmparam = sccmd.Parameters.Add("?PayType", MySqlDbType.VarChar);
                sprmparam.Value = salaryInfo.PayType;
                sprmparam = sccmd.Parameters.Add("?Amount", MySqlDbType.Decimal);
                sprmparam.Value = salaryInfo.Amount;
                sprmparam = sccmd.Parameters.Add("?IsActive", MySqlDbType.Bit);
                sprmparam.Value = salaryInfo.IsActive;
               
                sccmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {


                MessageBox.Show(" attendance sql exception" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }



        }






    }
}
