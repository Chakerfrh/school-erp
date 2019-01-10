using SchoolManagement.Classes.SP;
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
    public partial class frmAttendanceInquiry : Form
    {
        public frmAttendanceInquiry()
        {
            InitializeComponent();
        }


        public void ComboClassFill()
        {
            try
            {
                StudentSP stud = new StudentSP();
                DataTable dt = new DataTable();
                dt = stud.FillStudentClass();
                cbo_class.DataSource = dt;
                cbo_class.ValueMember = "ClassNo";
                cbo_class.DisplayMember = "ClassNo";
                cbo_class.SelectedIndex = -1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }



        private void btn_preview_Click(object sender, EventArgs e)
        {
            try
            {

               

                if (cbo_class.SelectedIndex == -1)
                {
                    MessageBox.Show("Class not selected");
                }

                else
                {
                    AttendanceSP reportSP = new AttendanceSP();
                    DataSet Attendance_rpt_Dataset = reportSP.AttendanceReport(Convert.ToInt32(cbo_class.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker1.Text), Convert.ToDateTime(dateTimePicker2.Text));
                    if (Attendance_rpt_Dataset.Tables[0].Rows.Count > 0)
                    {
                        frmReport frm = new frmReport();
                        frm.print_attendance_rpt(Attendance_rpt_Dataset);
                        frm.Show();
                    }

                    else
                    {
                        MessageBox.Show("No records found");
                    }
                }

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }


        private void frmAttendanceInquiry_Load(object sender, EventArgs e)
        {
            try
            {
                ComboClassFill();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
