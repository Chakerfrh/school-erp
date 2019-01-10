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
    class GradingSP:DBConnection
    {

        ///<summary>
        ///Function to get Student
        /// </summary>
        public void GradingAdd(GradingInfo gradingInfo)
        {
           
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("GradingAdd",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?student_id",MySqlDbType.Int32);
                sqlparam.Value = gradingInfo.StudentId;
                sqlparam = sqlcmd.Parameters.Add("?class_id", MySqlDbType.Int32);
                sqlparam.Value = gradingInfo.ClassId;
                sqlparam = sqlcmd.Parameters.Add("?subject_id", MySqlDbType.Int32);
                sqlparam.Value = gradingInfo.SubjectId;
                sqlparam = sqlcmd.Parameters.Add("?term_id", MySqlDbType.Int32);
                sqlparam.Value = gradingInfo.TermId;
                sqlparam = sqlcmd.Parameters.Add("?marks", MySqlDbType.Decimal);
                sqlparam.Value = gradingInfo.Marks;
                sqlparam = sqlcmd.Parameters.Add("?total", MySqlDbType.Decimal);
                sqlparam.Value = gradingInfo.Total;
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

    }
}
