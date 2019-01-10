using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolManagement.Classes.Info
{
    class TermInfo
    {

        private string _termName;
        private DateTime _dateStart;
        private DateTime _dateEnd;


        public string TermName
        {
            get { return _termName; }
            set { _termName = value; }
        }


        public DateTime DateStart
        {
            get { return _dateStart; }
            set { _dateStart = value; }
        }

        public DateTime DateEnd
        {
            get { return _dateEnd; }
            set { _dateEnd = value; }
        }


    }
}
