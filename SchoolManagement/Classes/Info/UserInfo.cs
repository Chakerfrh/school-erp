using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class UserInfo
    {


        #region Variables
        private decimal _userId;
        private string _userName;
        private string _password;
        private bool _active;
        private decimal _roleId;
        private string _narration;
       
        #endregion
        #region Properties
        /// <summary>
        /// To get and set the UserId
        /// </summary>
        public decimal UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        /// <summary>
        /// To get and set the UserName
        /// </summary>
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }
        /// <summary>
        /// To get and set the Password
        /// </summary>
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        /// <summary>
        /// To get and set the Active
        /// </summary>
        public bool Active
        {
            get { return _active; }
            set { _active = value; }
        }
        /// <summary>
        /// To get and set the RoleId
        /// </summary>
        public decimal RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        /// <summary>
        /// To get and set the Narration
        /// </summary>
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }
       
        #endregion




    }
}
