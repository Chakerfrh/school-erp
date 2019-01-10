using SchoolManagement.CrystalReports.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.CrystalReports
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Function to print the detailed report in crystal report
        /// </summary>
        /// <param name="Detailed_rpt_Dataset"></param>
        internal void print_attendance_rpt(DataSet Attendance_rpt_Dataset)
        {
            try
            {
                Attendance_report rpt_attendance = new Attendance_report();
              

                foreach (DataTable dtbl_detaild in Attendance_rpt_Dataset.Tables)
                {
                    
                    if (dtbl_detaild.TableName == "Table")
                    {

                        rpt_attendance.Database.Tables["attendace"].SetDataSource(dtbl_detaild);
                    }

                }

               
                this.crptViewer.ReportSource = rpt_attendance;
                this.crptViewer.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }




    }
}
