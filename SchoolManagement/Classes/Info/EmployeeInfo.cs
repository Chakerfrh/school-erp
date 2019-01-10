using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class EmployeeInfo
    {

        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
 


        private decimal _designationId;
        private string _employeeName;
        private string _employeeCode;
        private DateTime _dob;
        private string _maritalStatus;
        private string _gender;
        private string _qualification;
        private string _address;
        private string _phoneNumber;
        private string _email;
        private DateTime _joiningDate;
        private bool _isActive;
        private string _salaryType;
        private string _bankName;
        private string _branchName;
        private string _bankAccountNumber;
        private string _pinNumber;
        private string _nssfNumber;
        private string _nhifNumber;
        private DateTime _extraDate;
        private string _extra1;
        private decimal _defaultPackageId;

        #endregion
        #region properties
        /// <summary>
        /// Property to get and set DefaultPackageId
        /// </summary>
        public decimal DefaultPackageId
        {
            get { return _defaultPackageId; }
            set { _defaultPackageId = value; }

        }
       
        /// <summary>
        /// Property to get and set DesignationId
        /// </summary>
        public decimal DesignationId
        {
            get { return _designationId; }
            set { _designationId = value; }
        }
        /// <summary>
        /// Property to get and set EmployeeName
        /// </summary>
        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }
        /// <summary>
        /// Property to get and set EmployeeCode
        /// </summary>
        public string EmployeeCode
        {
            get { return _employeeCode; }
            set { _employeeCode = value; }
        }
        /// <summary>
        /// Property to get and set Dob
        /// </summary>  
        public DateTime Dob
        {
            get { return _dob; }
            set { _dob = value; }
        }
        /// <summary>
        /// Property to get and set MaritalStatus
        /// </summary>  
        public string MaritalStatus
        {
            get { return _maritalStatus; }
            set { _maritalStatus = value; }
        }
        /// <summary>
        /// Property to get and set Gender
        /// </summary>  
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        /// <summary>
        /// Property to get and set Qualification
        /// </summary>  
        public string Qualification
        {
            get { return _qualification; }
            set { _qualification = value; }
        }
        /// <summary>
        /// Property to get and set Address
        /// </summary> 
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
      
        /// <summary>
        /// Property to get and set MobileNumber
        /// </summary> 
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
        /// <summary>
        /// Property to get and set Email
        /// </summary> 
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        /// <summary>
        /// Property to get and set JoiningDate
        /// </summary>
        public DateTime JoiningDate
        {
            get { return _joiningDate; }
            set { _joiningDate = value; }
        }
      
        /// <summary>
        /// Property to get and set IsActive
        /// </summary>  
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
      
        /// <summary>
        /// Property to get and set SalaryType
        /// </summary>  
        public string SalaryType
        {
            get { return _salaryType; }
            set { _salaryType = value; }
        }
       
        /// <summary>
        /// Property to get and set BankName
        /// </summary>
        public string BankName
        {
            get { return _bankName; }
            set { _bankName = value; }
        }
        /// <summary>
        /// Property to get and set BranchName
        /// </summary>
        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }
        /// <summary>
        /// Property to get and set BankAccountNumber
        /// </summary>
        public string BankAccountNumber
        {
            get { return _bankAccountNumber; }
            set { _bankAccountNumber = value; }
        }
       
       
        /// <summary>
        /// Property to get and set ExtraDate
        /// </summary>
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }
        

        /// <summary>
        /// Property to get and set NSSF
        /// </summary>
        public string NssfNumber
        {
            get { return _nssfNumber; }
            set { _nssfNumber = value; }
        }
        /// <summary>
        /// Property to get and set NhifNumber
        /// </summary>
        public string NhifNumber
        {
            get { return _nhifNumber; }
            set { _nhifNumber = value; }
        }
        /// <summary>
        /// Property to get and set PinNumber
        /// </summary>
        public string PinNumber
        {
            get { return _pinNumber; }
            set { _pinNumber = value; }
        }

        /// <summary>
        /// Property to get and set Extra1
        /// </summary>
        public string Extra1
        {
            get { return _extra1; }
            set { _extra1 = value; }
        }

        #endregion



    }
}
