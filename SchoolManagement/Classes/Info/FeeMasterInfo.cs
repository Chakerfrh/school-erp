using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class FeeMasterInfo
    {

        private decimal _feeMasterId;
        private decimal _ledgerId;
        private decimal _classId;
        private decimal _termId;
        private decimal _userId;
        private decimal _total;
        private DateTime _transDate;
        private string _extra;
        private string _extra1;
        private string _extra2;


        public  decimal FeeMasterId
        {
            get { return _feeMasterId; }
            set { _feeMasterId = value; }
        }

        public decimal LedgerId
        {
            get { return _ledgerId; }
            set { _ledgerId = value; }
        }

        public decimal ClassId
        {
            get { return _classId; }
            set {_classId=value; }
        }

        public decimal TermId
        {
            get { return _termId; }
            set { _termId = value; }

        }

        public decimal UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }

        public DateTime TransDate
        {
            get { return _transDate; }
            set { _transDate = value; }
        }

        public string Extra
        {
            get { return _extra; }
            set { _extra = value; }
        }

        public string Extra1
        {
            get { return _extra1; }
            set { _extra1 = value; }
        }
        public string Extra2
        {
            get { return _extra2; }
            set { _extra2 = value; }
        }

    }
}
