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

namespace SchoolManagement.Forms
{
    public partial class frmStudentBalances : Form
    {
        public frmStudentBalances()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Student Creation GridFill
        /// </summary>
        public void GridFillSearch()
        {
            try
            {

                int search_item = Convert.ToInt32(cboClass.SelectedItem.ToString());
                StudentSP spStudent = new StudentSP();
                DataTable dtblStudentBalance = new DataTable();
                dtblStudentBalance = spStudent.FillDatagridViewStudentBalance(search_item);
                dgvStudentBalance.DataSource = dtblStudentBalance;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            GridFillSearch();
        }
    }
}
