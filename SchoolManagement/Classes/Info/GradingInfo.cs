using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class GradingInfo
    {

        private int _studentId;
        private int _classId;
        private int _subjectId;
        private int _termId;
        private decimal _marks;
        private decimal _total;


        public int StudentId
        {
            get { return _studentId; }
            set { _studentId = value; }
        }

        public int ClassId
        {
            get { return _classId; }
            set { _classId = value; }
        }

        public int SubjectId
        {
            get { return _subjectId; }
            set { _subjectId = value; }

        }

        public int TermId
        {
            get { return _termId; }
            set { _termId = value; }
        }

        public decimal Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        public decimal Total
        {
            get { return _total; }
            set { _total = value; }
        }





    }
}
