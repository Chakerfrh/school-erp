using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Classes.Info
{
    class RoleInfo
    {


        #region Variables
        /// <summary>
        /// private variable declaration part
        /// </summary>
        private decimal _roleId;
        private string _role;
        private string _narration;
       
        #endregion
        #region properties
        /// <summary>
        /// Property to get and set RoleId
        /// </summary>
        public decimal RoleId
        {
            get { return _roleId; }
            set { _roleId = value; }
        }
        /// <summary>
        /// Property to get and set Role
        /// </summary>
        public string Role
        {
            get { return _role; }
            set { _role = value; }
        }
        /// <summary>
        /// Property to get and set Narration
        /// </summary>
        public string Narration
        {
            get { return _narration; }
            set { _narration = value; }
        }
       
        #endregion




    }
}
