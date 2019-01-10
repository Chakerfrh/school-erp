using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class PrivilegeInfo
    {

        #region Variables
        /// <summary>
        /// private variable declaration part
        /// </summary>
        private decimal _privilegeId;
        private decimal _userId;
        private string _formName;
        private string _action;
        private decimal _roleId;
       

        #endregion
        #region properties
        /// <summary>
        /// Property to get and set PrivilegeId
        /// </summary>
        public decimal PrivilegeId
        {
            get { return _privilegeId; }
            set { _privilegeId = value; }
        }
        /// <summary>
        /// Property to get and set UserId
        /// </summary>
        public decimal UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }
        /// <summary>
        /// Property to get and set FormName
        /// </summary>  
        public string FormName
        {
            get { return _formName; }
            set { _formName = value; }
        }
        /// <summary>
        /// Property to get and set Action
        /// </summary>  
        public string Action
        {
            get { return _action; }
            set { _action = value; }
        }
        /// <summary>
        /// Property to get and set RoleId
        /// </summary>
        public decimal RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
       
        #endregion



    }
}
