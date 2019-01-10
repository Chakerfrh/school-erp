using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class DesignationInfo
    {
        private string _designation;
        private string _description;

        public string Description
        {
            get {return _description;}
            set { _description = value; }
        }

        public string Designation
        {
            get {return _designation; }
            set { _designation=value; }
        }


    }
}
