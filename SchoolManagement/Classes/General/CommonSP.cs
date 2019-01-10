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


namespace SchoolManagement.Classes.General
{
    class CommonSP : DBConnection
    {

        // <summary>
        /// Function to fill datatable for comboBox studentClass
        /// </summary>
        public DataTable FillStudentClassCombo()
        {
            DataTable dtbl = new DataTable();

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


        // <summary>
        /// Function to fill datatable forTerm
        /// </summary>
        public DataTable FillTermCombo()
        {
            DataTable dtbl = new DataTable();

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("TermViewAll", sqlcon);
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
        /// Function to fill datatable for comboBox studentNames
        /// </summary>
        public DataTable FillStudents(decimal classId)
        {
            DataTable dtbl = new DataTable();
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("StudentsViewAll", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("?classNo", MySqlDbType.Int32).Value = classId;

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



        // <summary>
        /// Function to fill datatable for comboBox subjects
        /// </summary>
        public DataTable FillSubjectsCombo()
        {
            DataTable dtbl = new DataTable();

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("SubjectViewAll", sqlcon);
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

        // <summary>
        /// Function to fill datatable for comboBox Group
        /// </summary>
        public DataTable FillAccountGroupCombo()
        {
            DataTable dtbl = new DataTable();

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("AccountGroupViewAllComboFill", sqlcon);
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




        // <summary>
        /// Function to fill datatable for dgvAccountLedger Group
        /// </summary>
        public DataTable FilldgvAccountLedger()
        {
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(int));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("AccountLedgerViewAll", sqlcon);
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



        // <summary>
        /// Function to fill datatable for dgvJournalType
        /// </summary>
        public DataTable FilldgvJournalType()
        {
            DataTable dtbl = new DataTable();
            dtbl.Columns.Add("SL.NO", typeof(int));
            dtbl.Columns["SL.NO"].AutoIncrement = true;
            dtbl.Columns["SL.NO"].AutoIncrementSeed = 1;
            dtbl.Columns["SL.NO"].AutoIncrementStep = 1;

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("JournalTypeViewAll", sqlcon);
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



        // <summary>
        /// Function to fill datatable for dgvLedgerPopup
        /// </summary>
        public DataTable FilldgvLedgerPopup()
        {
            DataTable dtbl = new DataTable();
            

            try
            {


                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("AccountLedgerPopUpViewAll", sqlcon);
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
        /// Function to fill datatable for comboBox studentNames
        /// </summary>
        public DataTable filterDetailsFordgvPromotion(string adminNumber)
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

                MySqlDataAdapter da = new MySqlDataAdapter("AccountLedgerPromotionFilter", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("?adminNumber", MySqlDbType.VarChar).Value = adminNumber;

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
        /// Function to fill datatable for comboBox studentNames
        /// </summary>
        public DataTable filterDetailsFordgvLedgerPopup(string adminNumber)
        {
            DataTable dtbl = new DataTable();
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("AccountLedgerPopUpFilter", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("?adminNumber", MySqlDbType.VarChar).Value = adminNumber;

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
        /// Function to fill datatable for comboBox feeItem in frmFeeProcessing
        /// </summary>
        public DataTable FillFeeItemCombo(decimal termId,decimal classId)
        {
            DataTable dtbl = new DataTable();
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("FeeItemViewForComboAll", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("?termId", MySqlDbType.Int32).Value = termId;
                da.SelectCommand.Parameters.Add("?classNo", MySqlDbType.Int32).Value = classId;
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
        /// Function to fill dgvFeeProcessing grid with details based on param
        /// </summary>
        public DataTable FillFeeItemComboOne(decimal termId)
        {
            DataTable dtbl = new DataTable();
            try
            {

                if (sqlcon.State == ConnectionState.Closed)
                {
                    sqlcon.Open();
                }

                MySqlDataAdapter da = new MySqlDataAdapter("FeeItemViewForComboOne", sqlcon);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("?feeItemId", MySqlDbType.Int32).Value = termId;

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










    }
}
