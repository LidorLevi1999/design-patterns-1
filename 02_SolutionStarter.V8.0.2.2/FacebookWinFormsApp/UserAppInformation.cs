/*using FacebookWrapper;
using FacebookWrapper.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class UserAppInformation
    {
        public List<string> FriendsList { get; }
        private static UserAppInformation s_Instance = null;
        private static readonly object sr_InstanceLock = new object();
        private static string s_InformationFilePath = AppDomain.CurrentDomain.BaseDirectory;
        private static bool s_userInformationFileExists;
        public static UserAppInformation Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_InstanceLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = LoadFromFile(LoginForm.getLoginResult() == null ? throw (new LoginResultException()) : LoginForm.getLoginResult().LoggedInUser.Name);
                            if (s_Instance == null)
                            {
                                s_Instance = new UserAppInformation();
                            }
                        }
                    }
                }
                return s_Instance;
            }
        }
        private UserAppInformation()
        {
            FriendsList = new List<string>();
        }

        public void AddFriend(string i_Friend)
        {
            FriendsList.Add(i_Friend);
        }

        public bool RemoveFriend(string i_Friend)
        {
            bool result = false;
            for (int i = 0; i < FriendsList.Count; i++)
            {
                if (FriendsList[i] == i_Friend && result == false)
                {
                    FriendsList.RemoveAt(i);
                    result = true;
                }
            }
            return result;
        }

        public static void SaveToFile(string i_UserName)
        {
            string userInformationFilePath = Path.Combine(s_InformationFilePath, string.Format("{0}Information.xml", i_UserName));
            FileMode fileMode = doesFileExists(userInformationFilePath) ? FileMode.Truncate : FileMode.CreateNew;
            using (Stream stream = new FileStream(userInformationFilePath, fileMode))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(UserAppInformation));
                xmlSerializer.Serialize(stream, s_Instance);
            }
        }

        private static bool doesFileExists(string i_Path)
        {
            if (!File.Exists(i_Path))
            {
                return false;
            }

            return true;
        }

        private static UserAppInformation LoadFromFile(string i_UserName)
        {
            UserAppInformation obj = null;
            string userInformationFilePath = Path.Combine(s_InformationFilePath, string.Format("{0}Information.xml", i_UserName));

            if (doesFileExists(userInformationFilePath))
            {
                using (Stream stream = new FileStream(userInformationFilePath, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(UserAppInformation));
                    obj = xmlSerializer.Deserialize(stream) as UserAppInformation;
                }
            }

            return obj;
        }
    }
}


*/