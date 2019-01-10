using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class PaymentMasterInfo
    {
        #region Variables
        /// <summary>
        /// Private variable declaration part
        /// </summary>
        private decimal _paymentMasterId;
        private string _voucherNo;
        private string _invoiceNo;
        private decimal _suffixPrefixId;
        private DateTime _date;
        private decimal _ledgerId;
        private decimal _totalAmount;
        private string _narration;
        private decimal _voucherTypeId;
        private decimal _userId;
        private decimal _financialYearId;
        private DateTime _extraDate;
        private string _extra1;
        private string _extra2;
        #endregion
        #region properties
        /// <summary>
        /// Property to get and set PaymentMasterId
        /// </summary>
        public decimal PaymentMasterId
        {
            get { return _paymentMasterId; }
            set { _paymentMasterId = value; }
        }
        /// <summary>
        /// Property to get and set VoucherNo
        /// </summary>
        public string VoucherNo
        {
            get { return _voucherNo; }
            set { _voucherNo = value; }
        }
        /// <summary>
        /// Property to get and set InvoiceNo
        /// </summary>
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        /// <summary>
        /// Property to get and set SuffixPrefixId
        /// </summary> 
        public decimal SuffixPrefixId
        {
            get { return _suffixPrefixId; }
            set { _suffixPrefixId = value; }
        }
        /// <summary>
        /// Property to get and set Date
        /// </summary> 
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
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
        /// Property to get and set TotalAmount
        /// </summary>
        public decimal TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
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
        /// Property to get and set VoucherTypeId
        /// </summary> 
        public decimal VoucherTypeId
        {
            get { return _voucherTypeId; }
            set { _voucherTypeId = value; }
        }
        /// <summary>
        /// Property to get and set UserId
        /// </summary>   
        public decimal UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        /// <summary>
        /// Property to get and set FinancialYearId
        /// </summary>  
        public decimal FinancialYearId
        {
            get { return _financialYearId; }
            set { _financialYearId = value; }
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
