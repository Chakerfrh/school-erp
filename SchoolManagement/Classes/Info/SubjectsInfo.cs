using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class SubjectsInfo
    {

        private string _subjectName;
        private string _subjectDescription;

        public string SubjectName
        {
            get { return _subjectName; }
            set { _subjectName = value; }
        }

        public string SubjectDescription
        {
            get { return _subjectDescription; }
            set { _subjectDescription = value; }
        }
    }
}
