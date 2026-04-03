using DVDL_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DVLD_Classes
{
    public class clsGlobal
    {
        public static clsUser CurrentUser = null;

        public static string LoginInfoFilePath = "C:\\Users\\HP\\source\\repos\\DVDL-Driving License Management WindowsForm\\DVDL-Driving License Management WindowsForm\\Screens\\Login\\LogFile.txt";

        public static void RememberUsernameAndPassword(string username, string password)
        {

            if (username == null || password == null)
            {
                File.WriteAllText(LoginInfoFilePath, string.Empty);
                return;
            }

            File.WriteAllText(LoginInfoFilePath, username + "|" + password);
        }

        public static bool RestoreUsernameAndPassword(ref string username,ref string password)
        {

            if (!String.IsNullOrEmpty(File.ReadAllText(LoginInfoFilePath)))
            {
                string[] LoginInfo = File.ReadAllText(LoginInfoFilePath).Split('|');
                username = LoginInfo[0];
                password = LoginInfo[1];
                return true;
            }
            else
                return false;
        }
    }
}
