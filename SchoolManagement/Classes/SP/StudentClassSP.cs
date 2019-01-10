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
    class StudentClassSP:DBConnection
    {
        /// <summary>
        /// Function for Save Student Classes
        /// </summary>

        public void InsertClass(StudentLevel studentlevel)
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand cmd = new MySqlCommand("StudentClassAdd",sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = cmd.Parameters.Add("?classNo",MySqlDbType.Int32);
                sqlparam.Value = studentlevel.ClassNo;
                sqlparam = cmd.Parameters.Add("?classSection", MySqlDbType.VarChar);
                sqlparam.Value = studentlevel.ClassSection;
                cmd.ExecuteNonQuery();


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
        /// Function for Update Student Classes
        /// </summary>

        public void UpdateStudentClass(StudentLevel studenClass,decimal studentid)
        {

            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand cmd = new MySqlCommand("StudentClassUpdate",sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = cmd.Parameters.Add("?classNo", MySqlDbType.Int32);
                sqlparam.Value = studenClass.ClassNo;
                sqlparam = cmd.Parameters.Add("?classSection", MySqlDbType.VarChar);
                sqlparam.Value = studenClass.ClassSection;
                sqlparam = cmd.Parameters.Add("?classid",MySqlDbType.Int32);
                sqlparam.Value = studentid;
                cmd.ExecuteNonQuery();


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
        /// Function for Update Student Classes
        /// </summary>
        public StudentLevel StudentClassView(decimal classid)
        {


            StudentLevel studentclass = new StudentLevel();
            MySqlDataReader sqlreader = null;

            try
            {
               
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlCommand cmd = new MySqlCommand("StudentClassViewOne", sqlcon);
                cmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sqlparam = new MySqlParameter();
                sqlparam = cmd.Parameters.Add("?classNo",MySqlDbType.Int32);
                sqlparam.Value = classid;
                sqlreader = cmd.ExecuteReader();

                while (sqlreader.Read())
                {
                    
                    studentclass.ClassNo =Convert.ToInt32(sqlreader[0].ToString());
                    studentclass.ClassSection = sqlreader[1].ToString();
                    
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

            return studentclass;
        }



        /// <summary>
        /// Function for Fill The Student Grid
        /// </summary>

        public DataTable FillGridClass()
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

                MySqlDataAdapter da = new MySqlDataAdapter("StudentClassView", sqlcon);
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




    }
}
