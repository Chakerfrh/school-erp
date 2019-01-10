using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class SalaryPackageInfo
    {
        #region Variables
        /// <summary>
        /// Public variable declaration part
        /// </summary>
        private string _payHead;
        private string _payType;
        private decimal _amount;
        private bool _isActive;
        private string _extra;

        #endregion

        #region Properties
         public string PayHead
        {
            get { return _payHead; }
            set { _payHead = value; }
        }


        public string PayType
        {
            get { return _payType; }
            set { _payType = value;}
        }

        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }


        public string Extra
        {
            get { return _extra; }
            set { _extra = value; }
        }


        #endregion
    }
}
