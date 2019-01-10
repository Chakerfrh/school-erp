using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class AccountLedgerInfo
    {

        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        private decimal _ledgerId;
        private decimal _accountGroupId;
        private string _ledgerName;
        private decimal _openingBalance;
        private string _crOrDr;
        private string _narration;
        private bool _active;


        private string _otherName;
        private DateTime _dateJoined;
        private string _adminNumber;
        private int _classNo;
        private DateTime _dateOfBirth;
        private string _photo;
        private string _homePhone;
        private string _email;
        private string _gender;


        private string _guardianName;
        private string _guardianRelationship;
        private string _guardianPhone;
        private string _guardianEmail;

        private string _bankAccountNumber;
        private string _branchName;
        private string _branchCode;

        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;
        private bool _isDefault;
        private bool _isPromoted;
        #endregion

        #region properties
        /// <summary>
        /// Property to get and set LedgerId
        /// </summary>
        public decimal LedgerId
        {
            get { return _ledgerId; }
            set { _ledgerId = value; }
        }
        /// <summary>
        /// Property to get and set AccountGroupId
        /// </summary>
        public decimal AccountGroupId
        {
            get { return _accountGroupId; }
            set { _accountGroupId = value; }
        }
        /// <summary>
        /// Property to get and set LedgerName
        /// </summary>
        public string LedgerName
        {
            get { return _ledgerName; }
            set { _ledgerName = value; }
        }
        /// <summary>
        /// Property to get and set OpeningBalance
        /// </summary>
        public decimal OpeningBalance
        {
            get { return _openingBalance; }
            set { _openingBalance = value; }
        }
        /// <summary>
        /// Property to get and set CrOrDr
        /// </summary>
        public string CrOrDr
        {
            get { return _crOrDr; }
            set { _crOrDr = value; }
        }
        /// <summary>
        /// Property to get and set Narration
        /// </summary>
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }


        /// <summary>
        /// To get and set the _OtherName
        /// </summary>
        public string OtherName
        {
            get { return _otherName; }
            set { _otherName = value; }
        }



        /// <summary>
        /// To get and set the Gender
        /// </summary>
        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        /// <summary>
        /// To get and set the _dateJoined
        /// </summary>
        public DateTime DateJoined
        {
            get { return _dateJoined; }
            set { _dateJoined = value; }
        }

        /// <summary>
        /// To get and set the _dateOfBirth
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }


        /// <summary>
        /// To get and set the _active
        /// </summary>
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }


        /// <summary>
        /// To get and set the _active
        /// </summary>
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        /// <summary>
        /// To get and set the _adminNumber
        /// </summary>
        public string AdminNumber
        {
            get { return _adminNumber; }
            set { _adminNumber = value; }
        }
        /// <summary>
        /// To get and set the _level
        /// </summary>
        public int ClassNo
        {
            get { return _classNo; }
            set { _classNo = value; }
        }

        /// <summary>
        /// To get and set the _homePhone
        /// </summary>
        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        /// <summary>
        /// To get and set the _email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        /// <summary>
        /// To get and set the  _guardianName
        /// </summary>
        public string GuardianName
        {
            get { return _guardianName; }
            set { _guardianName = value; }
        }



        /// <summary>
        /// To get and set the  _guardianRelationship
        /// </summary>
        public string GuardianRelationship
        {
            get { return _guardianRelationship; }
            set { _guardianRelationship = value; }
        }



        /// <summary>
        /// To get and set the  _guardianPhone
        /// </summary>
        public string GuardianPhone
        {
            get { return _guardianPhone; }
            set { _guardianPhone = value; }
        }



        /// <summary>
        /// To get and set the  _guardianRelationship
        /// </summary>
        public string GuardianEmail
        {
            get { return _guardianEmail; }
            set { _guardianEmail = value; }
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
        /// Property to get and set BranchName
        /// </summary>
        public string BranchName
        {
            get { return _branchName; }
            set { _branchName = value; }
        }
        /// <summary>
        /// Property to get and set BranchCode
        /// </summary>
        public string BranchCode
        {
            get { return _branchCode; }
            set { _branchCode = value; }
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
        /// Property to get and set Extra1
        /// </summary>
        public string Extra1
        {
            get { return _extra1; }
            set { _extra1 = value; }
        }
        /// <summary>
        /// Property to get and set Extra2
        /// </summary>
        public string Extra2
        {
            get { return _extra2; }
            set { _extra2 = value; }
        }
       
        /// <summary>
        /// Property to get and set IsDefault
        /// </summary>
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }

        /// <summary>
        /// Property to get and set IsPromoted
        /// </summary>
        public bool IsPromoted
        {
            get { return _isPromoted; }
            set { _isPromoted = value; }
        }
        #endregion
    }
}
