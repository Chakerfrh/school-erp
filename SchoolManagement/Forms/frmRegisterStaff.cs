using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Classes.Info;
using SchoolManagement.Classes.SP;
using SchoolManagement.Classes.General;

namespace SchoolManagement.Forms
{
    public partial class frmRegisterStaff : Form
    {
        public frmRegisterStaff()
        {
            InitializeComponent();
        }



        public void  SaveFunction()
        {
            try
            {

                EmployeeInfo empInfo = new EmployeeInfo();
                EmployeeSP empSP = new EmployeeSP();


                empInfo.EmployeeName = txtEmployeeName.Text.Trim();
                empInfo.EmployeeCode = txtEmployeeCode.Text.Trim();
                empInfo.Address = txtAddress.Text.Trim();
                empInfo.BankAccountNumber = txtBankAccountNumber.Text.Trim();
                empInfo.BankName = txtBankName.Text.Trim();
                empInfo.BranchName = txtBranch.Text.Trim();
                empInfo.DefaultPackageId = Convert.ToDecimal(cmbDefaultPackage.SelectedValue.ToString());
                empInfo.Dob = Convert.ToDateTime(dtpDob.Text.Trim());
                empInfo.Email = txtEmail.Text.Trim();
                empInfo.Gender = cmbGender.SelectedText.Trim();
                empInfo.MaritalStatus = cmbMaritalStatus.SelectedText.Trim();
                empInfo.NhifNumber = txtNHIFNumber.Text.Trim();
                empInfo.NssfNumber = txtNSSFNumber.Text.Trim();
                empInfo.PhoneNumber = txtPhoneNumber.Text.Trim();
                empInfo.PinNumber = txtPINNumber.Text.Trim();
                empInfo.Qualification = txtQualification.Text.Trim();
                empInfo.SalaryType = cmbSalaryType.SelectedText.Trim();
                empInfo.JoiningDate = Convert.ToDateTime(dtpJoiningDate.Text.Trim());
                empInfo.IsActive = cbxActive.Checked ? true : false;
                empInfo.Address = txtAddress.Text.Trim();

                empSP.EmployeeAdd(empInfo);
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }




        public void SaveOrEdit()
        {

            if(txtEmployeeCode.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Enter Employee Code");
                txtEmployeeCode.Focus();
            }

            else if (txtEmployeeName.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Enter Employee Name");
                txtEmployeeName.Focus();
            }

            else if (cmbDesignation.SelectedIndex == -1)
            {
                MessageBox.Show("Select a designation name");
                cmbDesignation.Focus();
            }

            else
            {

                if (Messages.SaveMessage())
                {
                    SaveFunction();
                    Messages.SavedMessage();

                }
                
            }


        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveOrEdit();

        }

      
    }
}
