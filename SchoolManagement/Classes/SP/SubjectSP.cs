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
    class SubjectSP:DBConnection
    {

        #region function
        /// <summary>
        /// Function to insert values to Subject Table
        /// </summary>
        /// <param name="subjectinfo"></param>
      
        public void SubjectAdd(SubjectsInfo subjectinfo)
        {

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("SubjectAdd",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?subject",MySqlDbType.VarChar);
                sqlparam.Value = subjectinfo.SubjectName;
                sqlparam = sqlcmd.Parameters.Add("?description", MySqlDbType.VarChar);
                sqlparam.Value = subjectinfo.SubjectDescription;
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



        /// <summary>
        /// Function to Edit values in Subject Table
        /// </summary>
        /// <param name="subjectinfo"></param>

        public void SubjectUpdate(SubjectsInfo subjectinfo,decimal subjectid)
        {

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("SubjectUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?subject", MySqlDbType.VarChar);
                sqlparam.Value = subjectinfo.SubjectName;
                sqlparam = sqlcmd.Parameters.Add("?description", MySqlDbType.VarChar);
                sqlparam.Value = subjectinfo.SubjectDescription;
                sqlparam = sqlcmd.Parameters.Add("?subjectid", MySqlDbType.VarChar);
                sqlparam.Value = subjectid;
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


        /// <summary>
        /// Function to Edit values in Subject Table to fill SubjectGrid
        /// </summary>
        /// <param name="subjectinfo"></param>

        public DataTable SubjectGridFill()
        {

            DataTable dt = new DataTable();
            dt.Columns.Add("SlNo", typeof(int));
            dt.Columns["SlNo"].AutoIncrement = true;
            dt.Columns["SlNo"].AutoIncrementSeed = 1;
            dt.Columns["SlNo"].AutoIncrementStep = 1;

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("SubjectViewAll",sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dt);
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dt;
        }



        public SubjectsInfo SubjectViewOne(decimal subjectid)
        {

            SubjectsInfo subjectinfo = new SubjectsInfo();
            MySqlDataReader sqlreader = null;

            try
            {

                

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("SubjectViewOne", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?subjectid",MySqlDbType.Int32);
                sqlparam.Value = subjectid;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    subjectinfo.SubjectName = sqlreader[1].ToString();
                    subjectinfo.SubjectDescription = sqlreader[2].ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
                sqlreader.Close();
            }
            return subjectinfo;
        }






















        #endregion




    }
}
