using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagement.Classes.General;
using System.Windows.Forms;

namespace SchoolManagement.Classes.General
{
    class Messages
    {

        /// <summary>
        /// Function to display information message
        /// </summary>
        /// <param name="strMsg"></param>
        public static void InformationMessage(string strMsg)
        {
            MessageBox.Show(strMsg, "Niambie School ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Function for custome update message
        /// </summary>
        /// <param name="strMsg"></param>
        /// <returns></returns>
        public static bool UpdateMessageCustom(string strMsg)
        {
            bool isOk = false;
            if ((MessageBox.Show(strMsg, "Niambie School ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                isOk = true;
            }
            return isOk;
        }

        /// <summary>
        /// Function for saved message
        /// </summary>
        public static void SavedMessage()
        {
            MessageBox.Show("Saved successfully", "Niambie School ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for updated message
        /// </summary>
        public static void UpdatedMessage()
        {
            MessageBox.Show("Updated successfully ", "Niambie School ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /// <summary>
        /// Function for deleted message
        /// </summary>



        /// <summary>
        /// Function for save confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool SaveMessage()
        {
            bool isOk = true;
            if (MessageBox.Show("Do you want to save ? ", "Niambie School ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                isOk = false;
            }
            return isOk;
        }

        /// <summary>
        /// Function for save confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool SaveConfirmation()
        {
            bool isOk = true;
            bool isMessageAdd = true;
            if (isMessageAdd)
            {
                if (MessageBox.Show("Do you want to save ? ", "Niambie School Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    isOk = false;
                }
            }
            return isOk;
        }

        /// <summary>
        /// Function for update confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool UpdateMessage()
        {
            bool isOk = true;
            if (MessageBox.Show("Do you want to update ? ", "Niambie School ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                isOk = false;
            }
            return isOk;
        }
        /// <summary>
        /// Function for delete confirmation message
        /// </summary>
        /// <returns></returns>
        public static bool DeleteMessage()
        {
            bool isOk = true;
            if (MessageBox.Show("Are you sure to delete ? ", "Niambie School Management", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                isOk = false;
            }
            return isOk;
        }

        /// <summary>
        /// Function for deleted message
        /// </summary>
        public static void DeletedMessage()
        {
            MessageBox.Show("Deleted successfully ", "Niambie School ERP", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Function for reference exist message
        /// </summary>
        public static void ReferenceExistsMessage()
        {
            MessageBox.Show("You can't delete,reference exist", "Niambie School ERP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Function for close message
        /// </summary>
        /// <param name="frm"></param>
        public static void CloseMessage(System.Windows.Forms.Form frm)
        {
            if ((MessageBox.Show("Are you sure to exit ? ", "Niambie School ERP", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                frm.Close();
            }
        }
       

    }
}
