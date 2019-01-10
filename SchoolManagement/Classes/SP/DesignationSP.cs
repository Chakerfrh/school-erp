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
    class DesignationSP:DBConnection
    {

        ///<summary>
        ///Function to insert data to tblDesignation
        ///</summary>

        public void DesignationAdd(DesignationInfo designationInfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("DesignationAdd", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?designationName", MySqlDbType.VarChar);
                sqlparam.Value = designationInfo.Designation;
                sqlparam = sqlcmd.Parameters.Add("?description", MySqlDbType.VarChar);
                sqlparam.Value = designationInfo.Description;
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


        public void DesignationUpdate(DesignationInfo designationInfo,decimal designationId)
        {

            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("DesignationUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?designationName", MySqlDbType.VarChar);
                sqlparam.Value = designationInfo.Designation;
                sqlparam = sqlcmd.Parameters.Add("?description", MySqlDbType.VarChar);
                sqlparam.Value = designationInfo.Description;
                sqlparam = sqlcmd.Parameters.Add("?designationId", MySqlDbType.Int32);
                sqlparam.Value = designationId;
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


        public DataTable DesignationFillGrid()
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

                MySqlDataAdapter da = new MySqlDataAdapter("DesignationViewAll", sqlcon);
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


        public DesignationInfo DesignationViewOne(decimal designationId)
        {

            DesignationInfo designationInfo = new DesignationInfo();

            try
            {

                MySqlDataReader sqlreader = null;
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("DesignationViewOne", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?designationId",MySqlDbType.Int32);
                sqlparam.Value = designationId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    designationInfo.Designation = sqlreader[1].ToString();
                    designationInfo.Description = sqlreader[2].ToString();
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

            return designationInfo;

        }







    }
}
