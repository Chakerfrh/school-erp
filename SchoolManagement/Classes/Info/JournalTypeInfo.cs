using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class JournalTypeInfo
    {
        #region Variables
        private decimal _journalTypeId;
        private string _journalTypeName;
        private string _abbreviation;
        private bool _isActive;
        private bool _isDefault;
        private string _narration;
        private DateTime _extraDate;
      
     
        private string _heading1;
        private string _heading2;

        private string _extra1;
        private string _extra2;
        #endregion
        #region Properties
        /// <summary>
        /// To get and set the VoucherTypeId
        /// </summary>
        public decimal JournalTypeId
        {
            get { return _journalTypeId; }
            set { _journalTypeId = value; }
        }
        /// <summary>
        /// To get and set the VoucherTypeName
        /// </summary>
        public string JournalTypeName
        {
            get { return _journalTypeName; }
            set { _journalTypeName = value; }
        }
        /// <summary>
        /// To get and set the TypeOfVoucher
        /// </summary>
        public string Abbreviation
        {
            get { return _abbreviation; }
            set { _abbreviation = value; }
        }
      
    
        /// <summary>
        /// To get and set the Narration
        /// </summary>
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }
        /// <summary>
        /// To get and set the ExtraDate
        /// </summary>
        public DateTime ExtraDate
        {
            get { return _extraDate; }
            set { _extraDate = value; }
        }
        /// <summary>
        /// To get and set the Extra1
        /// </summary>
        public string Extra1
        {
            get { return _extra1; }
            set { _extra1 = value; }
        }
        /// <summary>
        /// To get and set the Extra2
        /// </summary>
        public string Extra2
        {
            get { return _extra2; }
            set { _extra2 = value; }
        }
        /// <summary>
        /// To get and set the IsActive
        /// </summary>
        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        /// <summary>
        /// To get and set the IsDefault
        /// </summary>
        public bool IsDefault
        {
            get { return _isDefault; }
            set { _isDefault = value; }
        }
    
     
        /// <summary>
        /// To get and set the Heading1
        /// </summary>
        public string Heading1
        {
            get { return _heading1; }
            set { _heading1 = value; }
        }
        /// <summary>
        /// To get and set the Heading2
        /// </summary>
        public string Heading2
        {
            get { return _heading2; }
            set { _heading2 = value; }
        }

        #endregion
    }
}
