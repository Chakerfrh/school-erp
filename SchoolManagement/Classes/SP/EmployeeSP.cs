using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.General;


namespace SchoolManagement.Classes.SP
{
    class EmployeeSP:DBConnection
    {

        #region function
        /// <summary>
        /// Function to insert values to Employee Table
        /// </summary>
        /// <param name="employeeinfo"></param>
        public void EmployeeAdd(EmployeeInfo employeeinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }
                MySqlCommand sccmd = new MySqlCommand("EmployeeAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();

                sprmparam = sccmd.Parameters.Add("?S_designationId", MySqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DesignationId;
                sprmparam = sccmd.Parameters.Add("?S_employeeName", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeName;
                sprmparam = sccmd.Parameters.Add("?S_employeeCode", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.EmployeeCode;
                sprmparam = sccmd.Parameters.Add("?S_dob", MySqlDbType.DateTime);
                sprmparam.Value = employeeinfo.Dob;
                sprmparam = sccmd.Parameters.Add("?S_maritalStatus", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.MaritalStatus;
                sprmparam = sccmd.Parameters.Add("?S_gender", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Gender;
                sprmparam = sccmd.Parameters.Add("?S_qualification", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Qualification;
                sprmparam = sccmd.Parameters.Add("?S_address", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Address;
                sprmparam = sccmd.Parameters.Add("?S_mobileNumber", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.PhoneNumber;
                sprmparam = sccmd.Parameters.Add("?S_email", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Email;
                sprmparam = sccmd.Parameters.Add("?S_joiningDate", MySqlDbType.DateTime);
                sprmparam.Value = employeeinfo.JoiningDate;
              
                sprmparam = sccmd.Parameters.Add("?S_active", MySqlDbType.Bit);
                sprmparam.Value = employeeinfo.IsActive;
                sprmparam = sccmd.Parameters.Add("?S_salaryType", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.SalaryType;
                sprmparam = sccmd.Parameters.Add("?S_bankName", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankName;
                sprmparam = sccmd.Parameters.Add("?S_branchName", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BranchName;
                sprmparam = sccmd.Parameters.Add("?S_bankAccountNumber", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.BankAccountNumber;
                sprmparam = sccmd.Parameters.Add("?S_extraDate", MySqlDbType.DateTime);
                sprmparam.Value = employeeinfo.ExtraDate;
                sprmparam = sccmd.Parameters.Add("?S_extra1", MySqlDbType.VarChar);
                sprmparam.Value = employeeinfo.Extra1;
                sprmparam = sccmd.Parameters.Add("?S_defaultPackageId", MySqlDbType.Decimal);
                sprmparam.Value = employeeinfo.DefaultPackageId;
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
