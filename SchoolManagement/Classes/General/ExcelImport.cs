using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SchoolManagement.Classes.General
{
    class ExcelImport
    {



       

       

        

        

       


        /// <summary>
        /// Fill Sheet into DataTable 
        /// </summary>
        /// <param name="ExcelSheetPath">Excel Sheet file Path ex.C:\Excel.xlsx<</param>
        /// <param name="SheetName">Name of Sheet in Excel</param>
        /// <returns></returns>
        public DataTable FillDataFromExcelSheet(string ExcelSheetPath, string SheetName)
        {
            // Create the connection object
            DataTable dt = new DataTable();
            string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ ExcelSheetPath +";Extended Properties=\"Excel 8.0;HDR=YES;\";";
            OleDbConnection connection = new OleDbConnection(connString);
            try
            {
              
                connection.Open();
                string select = "SELECT * FROM ["+ SheetName.Trim() + "$]";

                OleDbDataAdapter adapter = new OleDbDataAdapter(select, connection);
            
                dt.Clear();
                adapter.Fill(dt);
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }


  







    }
}
