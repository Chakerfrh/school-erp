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
    class JournalSP:DBConnection
    {
        ///<summary>
        ///Function to add values to tblJournalType 
        /// </summary>
        
        public void JournalTypeAdd(JournalTypeInfo journalTypeInfo)
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();


                }

                MySqlCommand sqlcmd = new MySqlCommand("JournalTypeAdd", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?journalName",MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.JournalTypeName;
                sqlparam = sqlcmd.Parameters.Add("?abbreviation", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Abbreviation;
                sqlparam = sqlcmd.Parameters.Add("?isActive", MySqlDbType.Bit);
                sqlparam.Value = journalTypeInfo.IsActive;
                sqlparam = sqlcmd.Parameters.Add("?narration", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Narration;
                sqlparam = sqlcmd.Parameters.Add("?heading1", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Heading1;
                sqlparam = sqlcmd.Parameters.Add("?heading2", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Heading2;
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
        ///Function to update values to tblJournalType 
        /// </summary>

        public void JournalTypeUpdate(JournalTypeInfo journalTypeInfo)
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();


                }

                MySqlCommand sqlcmd = new MySqlCommand("JournalTypeUpdate", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("?journalId", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.JournalTypeId;
                sqlparam = sqlcmd.Parameters.Add("?journalName", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.JournalTypeName;
                sqlparam = sqlcmd.Parameters.Add("?abbreviation", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Abbreviation;
                sqlparam = sqlcmd.Parameters.Add("?isActive", MySqlDbType.Bit);
                sqlparam.Value = journalTypeInfo.IsActive;
                sqlparam = sqlcmd.Parameters.Add("?narration", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Narration;
                sqlparam = sqlcmd.Parameters.Add("?heading1", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Heading1;
                sqlparam = sqlcmd.Parameters.Add("?heading2", MySqlDbType.VarChar);
                sqlparam.Value = journalTypeInfo.Heading2;
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
        ///Function to get values from tblJournalType based on parameters 
        /// </summary>
        /// <param name="journalId"></param>
        public JournalTypeInfo JournalTypeViewOne(decimal journalId)
        {

            JournalTypeInfo journalTypeInfo = new JournalTypeInfo();
            MySqlDataReader sqlreader = null;
            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand sqlcmd = new MySqlCommand("JournalTypeViewOne",sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = sqlcmd.Parameters.Add("journalId",MySqlDbType.Int32);
                sqlparam.Value = journalId;
                sqlreader = sqlcmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    journalTypeInfo.JournalTypeName = sqlreader["journalTypeName"].ToString();
                    journalTypeInfo.Abbreviation = sqlreader["abbreviation"].ToString();
                    journalTypeInfo.IsActive = bool.Parse(sqlreader["isActive"].ToString());
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



            return journalTypeInfo;
        }















    }
}
