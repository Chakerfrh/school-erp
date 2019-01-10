using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class StudentLevel
    {

        private int _classno;
        private string _classSection;

        public int ClassNo 
         {
            get { return _classno; }
            set { _classno = value;}


         }

        public string ClassSection
        {
            get { return _classSection; }
            set { _classSection = value; }


        }



    }
}
