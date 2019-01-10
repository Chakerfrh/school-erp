using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Configuration;
using SchoolManagement.Settings;
using System.Windows.Forms;

namespace SchoolManagement.Classes.General
{
    class DBConnection
    {

        #region Variables
        protected MySqlConnection sqlcon;
        #endregion
     
        #region Functions
        /// <summary>
        /// create an instance of DBConnection Class
        /// </summary>
         
        public DBConnection()
        {
            try
            {
                //sqlcon = new MySqlConnection(string.Format("server={0};user id={1}; password={2}; database={3}", ConfigurationManager.AppSettings["MySqlServer"].ToString(), ConfigurationManager.AppSettings["MySqlUserId"].ToString(), ConfigurationManager.AppSettings["MySqlPassword"].ToString(),"dbschool"));
                string connstring = string.Format("server={0};userid={1}; password={2}; database=dbschool", ConfigurationManager.AppSettings["MySqlServer"].ToString(), ConfigurationManager.AppSettings["MySqlUserId"].ToString(), ConfigurationManager.AppSettings["MySqlPassword"].ToString());
                sqlcon = new MySqlConnection(connstring);
                
                
            }
            catch (Exception)
            {

                
            }
            
        }


        #endregion

    }
}
