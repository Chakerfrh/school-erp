using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class JournalDetailsInfo
    {

        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        private decimal _journalDetailsId;
        private decimal _journalMasterId;
        private decimal _ledgerId;
        private decimal _credit;
        private decimal _debit;
       
        private string _chequeNo;
        private DateTime _chequeDate;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;
        #endregion
        #region properties
        /// <summary>
        /// Property to get and set JournalDetailsId
        /// </summary>
        public decimal JournalDetailsId
        {
            get { return _journalDetailsId; }
            set { _journalDetailsId = value; }
        }
        /// <summary>
        /// Property to get and set JournalMasterId
        /// </summary>
        public decimal JournalMasterId
        {
            get { return _journalMasterId; }
            set { _journalMasterId = value; }
        }
        /// <summary>
        /// Property to get and set LedgerId
        /// </summary>
        public decimal LedgerId
        {
            get { return _ledgerId; }
            set { _ledgerId = value; }
        }
        /// <summary>
        /// Property to get and set Credit
        /// </summary> 
        public decimal Credit
        {
            get { return _credit; }
            set { _credit = value; }
        }
        /// <summary>
        /// Property to get and set Debit
        /// </summary>   
        public decimal Debit
        {
            get { return _debit; }
            set { _debit = value; }
        }
   
        /// <summary>
        /// Property to get and set ChequeNo
        /// </summary>   
        public string ChequeNo
        {
            get { return _chequeNo; }
            set { _chequeNo = value; }
        }
        /// <summary>
        /// Property to get and set ChequeDate
        /// </summary> 
        public DateTime ChequeDate
        {
            get { return _chequeDate; }
            set { _chequeDate = value; }
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
