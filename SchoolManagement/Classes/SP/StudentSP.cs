using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

using SchoolManagement.Classes.General;
using SchoolManagement.Classes.Info;

namespace SchoolManagement.Classes.SP
{
    class StudentSP:DBConnection
    {



        #region function

        /// <summary>
        /// Function to insert values to tblstudents
        /// </summary>
        /// <param name="Studentinfo"></param>
        public void StudentAdd(AccountLedgerInfo Studentinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                
                MySqlCommand sccmd = new MySqlCommand("AccountLedgerAdd", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();

                sprmparam = sccmd.Parameters.Add("?accountGroupId", MySqlDbType.Int32);
                sprmparam.Value = Studentinfo.AccountGroupId;
                sprmparam = sccmd.Parameters.Add("?ledgerName", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("?otherName", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.OtherName;
                sprmparam = sccmd.Parameters.Add("?openingBalance", MySqlDbType.Decimal);
                sprmparam.Value = Studentinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("?crOrDr", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("?active", MySqlDbType.Bit);
                sprmparam.Value = Studentinfo.Active;
                sprmparam = sccmd.Parameters.Add("?narration", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.Narration;

                sprmparam = sccmd.Parameters.Add("?email", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.Email;
                sprmparam = sccmd.Parameters.Add("?gender", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.Gender;
                sprmparam = sccmd.Parameters.Add("?dateOfBirth", MySqlDbType.Date);
                sprmparam.Value = Studentinfo.DateOfBirth;
                sprmparam = sccmd.Parameters.Add("?homePhone", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.HomePhone;
                sprmparam = sccmd.Parameters.Add("?adminNumber", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.AdminNumber;
                sprmparam = sccmd.Parameters.Add("?classNo", MySqlDbType.Int32);
                sprmparam.Value = Studentinfo.ClassNo;
                sprmparam = sccmd.Parameters.Add("?dateJoined", MySqlDbType.Date);
                sprmparam.Value = Studentinfo.DateJoined;
                sprmparam = sccmd.Parameters.Add("?photo", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.Photo;
 
                sprmparam = sccmd.Parameters.Add("?guardianEmail", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianEmail;
                sprmparam = sccmd.Parameters.Add("?guardianName", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianName;
                sprmparam = sccmd.Parameters.Add("?guardianRelationship", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianRelationship;
                sprmparam = sccmd.Parameters.Add("?guardianPhone", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianPhone;

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




        /// <summary>
        /// Function to update values to tblstudents
        /// </summary>
        /// <param name="Studentinfo"></param>
        public void StudentEdit(AccountLedgerInfo Studentinfo, decimal studentId)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }


                string sql = "UPDATE tblaccountLedger SET ledgerName=@firstName,otherName=@lastName,openingBalance=@openingBalance,crOrDr=@crOrDr,dateOfBirth=@dateOfBirth,active=@active,photo=@photo,adminNumber=@adminNumber,dateJoined=@dateJoined,email=@email,homePhone=@homePhone,guardianEmail=@guardianEmail,guardianName=@guardianName,guardianRelationship=@guardianRelationship,guardianPhone=@guardianPhone,classNo=@level WHERE ledgerId=@studentId;";
                                                                                                                                                                                                               


                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);
                MySqlParameter sprmparam = new MySqlParameter();

                sprmparam = sccmd.Parameters.Add("?firstName", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.LedgerName;
                sprmparam = sccmd.Parameters.Add("?lastName", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.OtherName;
                sprmparam = sccmd.Parameters.Add("?openingBalance", MySqlDbType.Decimal);
                sprmparam.Value = Studentinfo.OpeningBalance;
                sprmparam = sccmd.Parameters.Add("?crOrDr", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.CrOrDr;
                sprmparam = sccmd.Parameters.Add("?email", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.Email;
                sprmparam = sccmd.Parameters.Add("?dateOfBirth", MySqlDbType.DateTime);
                sprmparam.Value = Studentinfo.DateOfBirth;
                sprmparam = sccmd.Parameters.Add("?homePhone", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.HomePhone;
                sprmparam = sccmd.Parameters.Add("?adminNumber", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.AdminNumber;
                sprmparam = sccmd.Parameters.Add("?level", MySqlDbType.Int24);
                sprmparam.Value = Studentinfo.ClassNo;
                sprmparam = sccmd.Parameters.Add("?dateJoined", MySqlDbType.DateTime);
                sprmparam.Value = Studentinfo.DateJoined;
                sprmparam = sccmd.Parameters.Add("?photo", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.Photo;
                sprmparam = sccmd.Parameters.Add("?active", MySqlDbType.Bit);
                sprmparam.Value = Studentinfo.Active;

                sprmparam = sccmd.Parameters.Add("?guardianEmail", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianEmail;
                sprmparam = sccmd.Parameters.Add("?guardianName", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianName;
                sprmparam = sccmd.Parameters.Add("?guardianRelationship", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianRelationship;
                sprmparam = sccmd.Parameters.Add("?guardianPhone", MySqlDbType.VarChar);
                sprmparam.Value = Studentinfo.GuardianPhone;

                sprmparam = sccmd.Parameters.Add("?studentId", MySqlDbType.Decimal);
                sprmparam.Value = studentId;

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


        /// <summary>
        /// Function to fill gridstudentClass
        /// </summary>
        public DataTable FillStudentClass()
        {

            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {
                

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("ViewStudentClass", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dtbl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtbl;
        }



        /// <summary>
        /// Function to fill dgvPromotion
        /// </summary>
        public DataTable FillDatagridViewPromotion()
        {

            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("ViewStudentsToPromote", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dtbl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtbl;
        }



        /// <summary>
        /// Function to view all details from tblstudents
        /// </summary>
        /// <returns></returns>
        public DataTable get_student_details(string adminNo)
        {
            DataTable dtblstudent = new DataTable();
           

            try
            {
                string sql = "SELECT tblstudentclass.ClassNo,tblaccountLedger.ledgerId,tblaccountLedger.OtherName,tblaccountLedger.adminNumber FROM tblstudentclass INNER JOIN tblaccountLedger ON tblstudentclass.classNo=tblaccountLedger.classNo WHERE tblaccountLedger.adminNumber=@_adminNo;";

                MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, sqlcon);
                sqlda.SelectCommand.Parameters.Add("?_adminNo", MySqlDbType.VarChar).Value = adminNo;
                sqlda.Fill(dtblstudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtblstudent;
        }



        /// <summary>
        /// Function to view all details from tblstudents
        /// </summary>
        /// <returns></returns>
        public DataTable StudentCreationViewForGridFill()
        {
            DataTable dtblstudent = new DataTable();
            dtblstudent.Columns.Add("SL.NO", typeof(decimal));
            dtblstudent.Columns["SL.NO"].AutoIncrement = true;
            dtblstudent.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtblstudent.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {
                string sql = "SELECT tblstudentclass.ClassNo,tblaccountLedger.ledgerId,tblaccountLedger.otherName,tblaccountLedger.adminNumber FROM tblstudentclass INNER JOIN tblaccountLedger ON tblstudentclass.classNo=tblaccountLedger.classNo;";

                MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, sqlcon);
                sqlda.Fill(dtblstudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtblstudent;
        }


        /// <summary>
        /// Function to view all details from tblstudents
        /// </summary>
        /// <returns></returns>
        public DataTable StudentPromotionViewForGridFill(int classid)
        {
            DataTable dtblstudent = new DataTable();
            dtblstudent.Columns.Add("SL.NO", typeof(decimal));
            dtblstudent.Columns["SL.NO"].AutoIncrement = true;
            dtblstudent.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtblstudent.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {
              

                MySqlDataAdapter sqlda = new MySqlDataAdapter("PromoteStudentView", sqlcon);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.Add("?classNo", MySqlDbType.VarChar).Value = classid;
                sqlda.Fill(dtblstudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtblstudent;
        }


        



      
        /// <summary>
        /// Function to insert values to tblstudents
        /// </summary>
        /// <param name="Studentinfo"></param>
        public void PromotedStudentAdd(AccountLedgerInfo Studentinfo)
        {
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                
                MySqlCommand sccmd = new MySqlCommand("PromoteStudent", sqlcon);
                sccmd.CommandType = CommandType.StoredProcedure;
                MySqlParameter sprmparam = new MySqlParameter();

                sprmparam = sccmd.Parameters.Add("?ledgerId", MySqlDbType.Int32);
                sprmparam.Value = Studentinfo.LedgerId;
                //sprmparam = sccmd.Parameters.Add("?ledgerName", MySqlDbType.VarChar);
                //sprmparam.Value = Studentinfo.LedgerName;
               // sprmparam = sccmd.Parameters.Add("?adminNumber", MySqlDbType.VarChar);
               // sprmparam.Value = Studentinfo.AdminNumber;
               // sprmparam = sccmd.Parameters.Add("?classNo", MySqlDbType.Int32);
               // sprmparam.Value = Studentinfo.ClassNo;
               // sprmparam = sccmd.Parameters.Add("?isPromoted", MySqlDbType.Bit);
               // sprmparam.Value = Studentinfo.IsPromoted;
          

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






        /// <summary>
        /// Function to view all details from tblstudents
        /// </summary>
        /// <returns></returns>
        public DataTable StudentSearchViewForGridFill(int classid)
        {
            DataTable dtblstudent = new DataTable();
            dtblstudent.Columns.Add("SL.NO", typeof(decimal));
            dtblstudent.Columns["SL.NO"].AutoIncrement = true;
            dtblstudent.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtblstudent.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {
                string sql = "SELECT tblstudentclass.ClassNo,tblaccountLedger.gender,tblaccountLedger.ledgerId,tblaccountLedger.otherName,tblaccountLedger.adminNumber FROM tblstudentclass INNER JOIN tblaccountLedger ON tblstudentclass.classNo=tblaccountLedger.classNo WHERE tblaccountLedger.classNo=@_classId;";

                MySqlDataAdapter sqlda = new MySqlDataAdapter(sql, sqlcon);
                sqlda.SelectCommand.Parameters.Add("?_classId", MySqlDbType.VarChar).Value = classid;
                sqlda.Fill(dtblstudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtblstudent;
        }


        /// <summary>
        /// Function to get particular values from tblStudents table based on the parameter
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public AccountLedgerInfo StudentView(decimal ledgerId)
        {
          AccountLedgerInfo studentinfo = new AccountLedgerInfo();
            MySqlDataReader sdrreader = null;
            try
            {
                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }


                string sql = "SELECT * FROM tblaccountLedger WHERE (ledgerId=@_ledgerId);";
                MySqlCommand sccmd = new MySqlCommand(sql, sqlcon);

                MySqlParameter sprmparam = new MySqlParameter();
                sprmparam = sccmd.Parameters.Add("?_ledgerId", MySqlDbType.Int32);
                sprmparam.Value = ledgerId;
                sdrreader = sccmd.ExecuteReader();

                while (sdrreader.Read())
                {


                    studentinfo.LedgerName = sdrreader["ledgerName"].ToString();
                    studentinfo.OtherName = sdrreader["otherName"].ToString();
                    studentinfo.DateOfBirth = DateTime.Parse(sdrreader["dateOfBirth"].ToString());
                    studentinfo.Active= bool.Parse(sdrreader["active"].ToString());

                    studentinfo.Photo  = sdrreader["photo"].ToString();
                    studentinfo.AdminNumber = sdrreader["adminNumber"].ToString();
                    studentinfo.DateJoined = DateTime.Parse(sdrreader["dateJoined"].ToString());
                    studentinfo.Email = sdrreader["email"].ToString();
                    studentinfo.HomePhone = sdrreader["homePhone"].ToString();
                    studentinfo.Gender = sdrreader["gender"].ToString();
                    studentinfo.GuardianEmail = sdrreader["guardianEmail"].ToString();
                    studentinfo.GuardianName = sdrreader["guardianName"].ToString();
                    studentinfo.GuardianRelationship = sdrreader["guardianRelationship"].ToString();
                    studentinfo.GuardianPhone = sdrreader["guardianPhone"].ToString();
                    studentinfo.ClassNo =Int32.Parse(sdrreader["classNo"].ToString());
                    studentinfo.OpeningBalance = Convert.ToDecimal(sdrreader["openingBalance"].ToString());
                    studentinfo.CrOrDr = sdrreader["crOrDr"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show( " " + ex.Message);
            }
            finally
            {
                sdrreader.Close();
                sqlcon.Close();
            }
            return studentinfo;
        }


        /// <summary>
        /// Function to fill dgvPromotion
        /// </summary>
        public DataTable FillDatagridViewStudentBalance(int classNo)
        {

            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(decimal));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;
            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("StudentBalanceViewAll", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("?classNo", MySqlDbType.VarChar).Value = classNo;
                da.Fill(dtbl);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            finally
            {
                sqlcon.Close();
            }

            return dtbl;
        }



        #endregion

    }
}
