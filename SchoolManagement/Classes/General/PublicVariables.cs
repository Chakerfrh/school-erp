using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.General
{
    class PublicVariables
    {
        #region PublicVariables
        public static decimal _decCurrentUserId = 1;
        public static DateTime _dtCurrentDate = DateTime.Now;
        public static DateTime _dtFromDate = DateTime.Now;//financial year starting    
        public static DateTime _dtToDate = DateTime.Now;//financial year ending         
        public static decimal _decCurrentFinancialYearId = 1;
        public static bool isMessageAdd = true;
        public static bool isMessageEdit = true;
        public static bool isMessageDelete = true;
        public static bool isMessageClose = true;
        public static decimal _decCurrencyId = 1;
        public static int _inNoOfDecimalPlaces = 2;
        public static string MessageToShow = string.Empty;
        public static string MessageHeadear = string.Empty;
        public static string DBName = "dbopenmiracle_0";
        #endregion
    }
}
