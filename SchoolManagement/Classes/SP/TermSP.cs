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
    class TermSP : DBConnection
    {
        ///<summary>Function to insert data to tblTerm</summary>
        ///<param name="TermInfo"></param>

        public void TermAdd(TermInfo termInfo)
        {
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("TermAdd", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?termName",MySqlDbType.VarChar);
                sqlparam.Value = termInfo.TermName;
                sqlparam = sqlcmd.Parameters.Add("?dateStart", MySqlDbType.DateTime);
                sqlparam.Value = termInfo.DateStart;
                sqlparam = sqlcmd.Parameters.Add("?dateEnd", MySqlDbType.DateTime);
                sqlparam.Value = termInfo.DateEnd;
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

        ///<summary>
        ///Function to fetch data from tblTerm to fill in the grid
        ///</summary>
        ///<param></param>
        public DataTable TermViewGridFill()
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

                MySqlDataAdapter da = new MySqlDataAdapter("TermViewGridFill", sqlcon);
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


        ///<summary>Function to fetch data from tblTerm based on parameters</summary>
        ///<param name="termId"></param>

        public TermInfo TermViewOne(decimal termId)
        {
            TermInfo termInfo = new TermInfo();

            try
            {
                MySqlDataReader sqlreader = null;


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("TermViewOne",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?termId",MySqlDbType.Int32);
                sqlparam.Value = termId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    termInfo.TermName = sqlreader[1].ToString();
                    termInfo.DateStart = Convert.ToDateTime(sqlreader[2].ToString());
                    termInfo.DateEnd = Convert.ToDateTime(sqlreader[3].ToString());


                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();

            }
            return termInfo;
        }

        ///<summary>Function to update data from tblTerm based on parameters</summary>
        ///<param name="termId"></param>

        public void TermUpdate(TermInfo termInfo,decimal termId)
        {

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("TermUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?termName", MySqlDbType.VarChar);
                sqlparam.Value = termInfo.TermName;
                sqlparam = sqlcmd.Parameters.Add("?dateStart", MySqlDbType.DateTime);
                sqlparam.Value = termInfo.DateStart;
                sqlparam = sqlcmd.Parameters.Add("?dateEnd", MySqlDbType.DateTime);
                sqlparam.Value = termInfo.DateEnd;
                sqlparam = sqlcmd.Parameters.Add("?termId", MySqlDbType.Int32);
                sqlparam.Value = termId;
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
