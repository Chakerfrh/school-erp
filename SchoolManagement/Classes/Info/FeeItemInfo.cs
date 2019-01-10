using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class FeeItemInfo
    {
        private decimal _feeItemId;
        private string _feeTitle;
        private decimal _classId;
        private decimal _termId;
        private decimal _feeAmount;
        private bool _active;

        public decimal FeeItemId
        {
            get { return _feeItemId; }
            set { _feeItemId = value; }
        }

        public string FeeTitle
        {
            get { return _feeTitle; }
            set { _feeTitle = value; }
        }

        public decimal TermId
        {
            get { return _termId; }
            set { _termId = value; }
        }

        public decimal ClassId
        {
            get { return _classId; }
            set { _classId = value; }
        }

 
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }



        public decimal FeeAmount
        {
            get { return _feeAmount; }
            set { _feeAmount = value; }
        }





    }
}
