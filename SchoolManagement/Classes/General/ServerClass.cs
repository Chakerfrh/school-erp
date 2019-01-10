using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SchoolManagement.Classes.General
{
    class ServerClass
    {


        /// <summary>
        /// Function for Checking MySqlConnection
        /// </summary>
        /// <param name="ServerName"></param>
        /// <param name="UserId"></param>
        /// <param name="Password"></param>
        /// <returns></returns>
        public bool CheckMySqlConnection(string ServerName, string UserId, string Password)
        {
            bool isok = false;
            string connstring = string.Format("server={0};user id={1}; password={2};", ServerName, UserId, Password);
            MySqlConnection connection = new MySqlConnection(connstring);
           
            try
            {

                connection.Open();
                isok = true;
              
            }
            catch (Exception)
            {
                
                isok = false;
            }
            return isok;
        }




        /// <summary>
        /// Function for update the AppConfig file
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public void UpdateAppConfig(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                    
                }
                else
                {
                    settings[key].Value = value;

                }

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
            }
            catch { }

        }



    }
}
