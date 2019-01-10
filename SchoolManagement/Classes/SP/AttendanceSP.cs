using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;

namespace SchoolManagement.Classes.SP
{
    class AttendanceSP :DBConnection
    {



  

        /// <summary>
        /// Function to insert data in tblattendance
        /// </summary>
        public void AttendanceAdd(AttendanceInfo attendanceInfo)
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sccmd = new MySqlCommand("AttendanceAdd",sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?Date", MySqlDbType.DateTime);
                sprmparam.Value = attendanceInfo.Date;
                sprmparam = sccmd.Parameters.Add("?StudentId", MySqlDbType.Int32);
                sprmparam.Value = attendanceInfo.StudentId;
                sprmparam = sccmd.Parameters.Add("?TermId", MySqlDbType.Int32);
                sprmparam.Value = attendanceInfo.TermId;
                sprmparam = sccmd.Parameters.Add("?ClassNo", MySqlDbType.Int32);
                sprmparam.Value = attendanceInfo.ClassId;
                sprmparam = sccmd.Parameters.Add("?Status", MySqlDbType.VarChar);
                sprmparam.Value = attendanceInfo.Status;
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


        /// <summary>
        /// Function to pull data from tblattendance
        /// </summary>
        public DataSet AttendanceReport(decimal classId, DateTime date1, DateTime date2)
        {

            DataSet dsattendanceReport = new DataSet();

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter sqlda = new MySqlDataAdapter("AttendaceReport", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("?fromDate", MySqlDbType.DateTime).Value = date1;
                sqlda.SelectCommand.Parameters.Add("?toDate", MySqlDbType.DateTime).Value = date2;
                sqlda.SelectCommand.Parameters.Add("?classNo", MySqlDbType.Decimal).Value = classId;
                sqlda.Fill(dsattendanceReport);



            }
            catch (Exception ex)
            {


                MessageBox.Show(" attendance sql exception" + ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dsattendanceReport;
        }






    }
}
