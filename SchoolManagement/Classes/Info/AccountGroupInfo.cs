using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class AccountGroupInfo
    {

        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>

        private decimal _accountId;
        private string _accountName;
        private string _accountGroup;
        private string _accountSubGroup;
        private string _accountCode;
        private string _affects;
        private string _narration;
        private bool _isDefault;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;

        #endregion

        #region properties
        /// <summary>
        /// Property to get and set Accountgroupid
        /// </summary>
        public decimal AccountId
        {
            get { return _accountId; }
            set { _accountId = value; }
        } 



        /// <summary>
        /// Property to get and set AccountGroupName
        /// </summary>
        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }
        /// <summary>
        /// Property to get and set GroupUnder
        /// </summary>
        public string AccountGroup
        {
            get { return _accountGroup; }
            set { _accountGroup = value; }
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
        /// Property to get and set IsDefault
        /// </summary>
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
        /// <summary>
        /// Property to get and set AccountSubGroup
        /// </summary>
        public string AccountSubGroup
        {
            get { return _accountSubGroup; }
            set { _accountSubGroup = value; }
        }

        /// <summary>
        /// Property to get and set The acount code
        /// </summary>
        public string AccountCode
        {
            get { return _accountCode; }
            set { _accountCode = value; }
        }

        /// <summary>
        /// Property to get and set The financial statement it affects
        /// </summary>
        public string Affects
        {
            get { return _affects; }
            set { _affects = value; }
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
        #endregion







    }
}
