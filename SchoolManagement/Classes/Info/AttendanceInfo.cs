using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class AttendanceInfo
    {

        private DateTime _date;
        private int _student_id;
        private int _term_id;
        private int _class_id;
        private string _status;


        public DateTime Date
        {
            get {return _date; }
            set { _date = value; }
        }

        public int StudentId
        {
            get {return _student_id; }
            set { _student_id = value; }
        }

        public int TermId
        {
            get { return _term_id; }
            set { _term_id = value; }

        }


        public int ClassId
        {
            get { return _class_id; }
            set { _class_id = value; }

        }


        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }


    }
}
