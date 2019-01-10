
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Settings;
using SchoolManagement.Forms;
using SchoolManagement.Forms.Settings;
using SchoolManagement.Classes.SP;
using SchoolManagement.CrystalReports;

namespace SchoolManagement
{
    public partial class frmMDI : Form
    {
       

        public frmMDI()
        {
            InitializeComponent();
        }

        public static frmMDI MDIObj;

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

       

      

        

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                frmCreateUser frm = new frmCreateUser();
                frmCreateUser open = Application.OpenForms[" frmCreateUser "] as frmCreateUser;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripAddStudents_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentRegister frm = new frmStudentRegister();
                frmStudentRegister open = Application.OpenForms[" frmStudentRegister"] as frmStudentRegister;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentImport frm = new frmStudentImport();
                frmStudentImport open = Application.OpenForms[" frmStudentImport"] as frmStudentImport;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                frmRoles frm = new frmRoles();
                frmRoles open = Application.OpenForms["  frmRoles"] as frmRoles;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void toolStripMenuItem26_Click(object sender, EventArgs e)
        {
            try
            {
                frmRegisterStaff frm = new frmRegisterStaff();
                frmRegisterStaff open = Application.OpenForms["frmRegisterStaff"] as frmRegisterStaff;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolStripMenuItem29_Click(object sender, EventArgs e)
        {
            try
            {
                frmDesignation frm = new frmDesignation();
                frmDesignation open = Application.OpenForms["frmDesignation"] as frmDesignation;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            try
            {
                frmSubjects frm = new frmSubjects();
                frmSubjects open = Application.OpenForms["frmSubjects"] as frmSubjects;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                frmClass frm = new frmClass();
                frmClass open = Application.OpenForms["frmClass"] as frmClass;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            try
            {
                frmGrading frm = new frmGrading();
                frmGrading open = Application.OpenForms["frmGrading"] as frmGrading;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFeeProcessing frm = new frmFeeProcessing();
                frmFeeProcessing open = Application.OpenForms["frmFeeProcessing"] as frmFeeProcessing;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmFees frm = new frmFees();
                frmFees open = Application.OpenForms["frmFees"] as frmFees;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendance frm = new frmAttendance();
                frmAttendance open = Application.OpenForms["frmAttendance"] as frmAttendance;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            try
            {
                frmStaffInquiries frm = new frmStaffInquiries();
                frmStaffInquiries open = Application.OpenForms[" frmStaffRegister"] as frmStaffInquiries;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmTerm frm = new frmTerm();
                frmTerm open = Application.OpenForms["frmTerm"] as frmTerm;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountGroup frm = new frmAccountGroup();
                frmAccountGroup open = Application.OpenForms["frmAccountGroup"] as frmAccountGroup;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountLedger frm = new frmAccountLedger();
                frmAccountLedger open = Application.OpenForms["frmAccountLedger"] as frmAccountLedger;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            try
            {
                frmJournalType frm = new frmJournalType();
                frmJournalType open = Application.OpenForms["frmJournalType"] as frmJournalType;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                frmUserRights frm = new frmUserRights();
                frmUserRights open = Application.OpenForms["frmUserRights"] as frmUserRights;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void salaryPackageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalaryPackage frm = new frmSalaryPackage();
                frmSalaryPackage open = Application.OpenForms["frmSalaryPackage"] as frmSalaryPackage;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            try
            {
                frmAttendanceInquiry frm = new frmAttendanceInquiry();
                frmAttendanceInquiry open = Application.OpenForms["frmAttendanceInquiry"] as frmAttendanceInquiry;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void frmMDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                Application.Exit();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            try
            {
                frmPromoteStudents frm = new frmPromoteStudents();
                frmPromoteStudents open = Application.OpenForms["frmPromoteStudents"] as frmPromoteStudents;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void inquiriesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentBalancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmStudentBalances frm = new frmStudentBalances();
                frmStudentBalances open = Application.OpenForms["frmStudentBalances"] as frmStudentBalances;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmPayment frm = new frmPayment();
                frmPayment open = Application.OpenForms["frmPayment"] as frmPayment;
                if (open == null)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    open.Activate();
                    if (open.WindowState == FormWindowState.Minimized)
                    {
                        open.WindowState = FormWindowState.Normal;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
