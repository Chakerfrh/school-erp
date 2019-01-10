using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class StudentInfo
    {

        #region Variables
        private string _firstName;
        private string _lastName;
        private DateTime _dateJoined;
        private bool _active;
        private string _adminNumber;
        private int _level;
        private DateTime _dateOfBirth;
        private string _photo;


        private string _homePhone;
        private string _email;
     

       

        private string _guardianName;
        private string _guardianRelationship;
        private string _guardianPhone;
        private string _guardianEmail;

       




        #endregion
        #region Properties
        /// <summary>
        /// To get and set the _firstName
        /// </summary>
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        /// <summary>
        /// To get and set the _lastName
        /// </summary>
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        /// <summary>
        /// To get and set the _dateJoined
        /// </summary>
        public DateTime DateJoined
        {
            get { return _dateJoined; }
            set { _dateJoined = value; }
        }

        /// <summary>
        /// To get and set the _dateOfBirth
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return _dateOfBirth; }
            set { _dateOfBirth = value; }
        }
        

        /// <summary>
        /// To get and set the _active
        /// </summary>
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }


        /// <summary>
        /// To get and set the _active
        /// </summary>
        public string Photo
        {
            get { return _photo; }
            set { _photo = value; }
        }

        /// <summary>
        /// To get and set the _adminNumber
        /// </summary>
        public string AdminNumber
        {
            get { return _adminNumber; }
            set { _adminNumber = value; }
        }
        /// <summary>
        /// To get and set the _level
        /// </summary>
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        /// <summary>
        /// To get and set the _homePhone
        /// </summary>
        public string HomePhone
        {
            get { return _homePhone; }
            set { _homePhone = value; }
        }

        /// <summary>
        /// To get and set the _email
        /// </summary>
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        /// <summary>
        /// To get and set the  _guardianName
        /// </summary>
        public string GuardianName
        {
            get { return _guardianName; }
            set { _guardianName = value; }
        }



        /// <summary>
        /// To get and set the  _guardianRelationship
        /// </summary>
        public string GuardianRelationship
        {
            get { return _guardianRelationship; }
            set { _guardianRelationship = value; }
        }



        /// <summary>
        /// To get and set the  _guardianPhone
        /// </summary>
        public string GuardianPhone
        {
            get { return _guardianPhone; }
            set { _guardianPhone = value; }
        }



        /// <summary>
        /// To get and set the  _guardianRelationship
        /// </summary>
        public string GuardianEmail
        {
            get { return _guardianEmail; }
            set { _guardianEmail = value; }
        }


      


        #endregion






    }
}
