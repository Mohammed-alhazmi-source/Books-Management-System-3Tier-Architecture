using BMS_Business;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMS.GlobalClasses
{
    public static class clsGlobal
    {
        public static clsUser CurrentUser = null;

        public static bool RememberUserNameAndPassword(string UserName, string Password)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();

            string FileName = CurrentDirectory + "\\UserAccount.txt";

            if (!File.Exists(FileName))
                File.Create(FileName);

            string Pattern = UserName + "#" + Password;

            using(StreamWriter sw = new StreamWriter(FileName))
            {
                sw.Write(Pattern);
            }
            return true;
        }

        public static bool GetStoredUserNameAndPasswordFromFile(ref string UserName, ref string Password)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();

            string FileName = CurrentDirectory + "\\UserAccount.txt";

            if(File.Exists(FileName))
            {
                using(StreamReader sr = new StreamReader(FileName))
                {
                    string Line = sr.ReadLine();

                    if (string.IsNullOrEmpty(Line))
                        return false;

                    string[] Account = Line.Split(new[] { "#" }, StringSplitOptions.None);

                    UserName = Account[0];
                    Password = clsUtil.DecryptPassword(Account[1]);
                }

                return true;
            }

            return false;
        }
    }
}