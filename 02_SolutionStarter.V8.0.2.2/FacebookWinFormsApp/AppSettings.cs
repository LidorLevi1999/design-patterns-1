
using System;
using System.IO;
using System.Xml.Serialization;

namespace BasicFacebookFeatures
{
    public class AppSettings
    {
        private static AppSettings sr_Instance = null;
        public static AppSettings Instance
        {
            get
            {
                if(sr_Instance == null)
                {
                    sr_Instance = new AppSettings();
                }

                return sr_Instance;
            }
        }
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }

        private AppSettings() 
        {
            RememberUser = false;
            LastAccessToken = null;
        }

        public void SaveAppSettings()
        {
            string appSettingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.xml");
            bool doesAppSettingsFileExists = File.Exists(appSettingsFilePath);
            FileMode fileMode = doesAppSettingsFileExists ? FileMode.Truncate : FileMode.CreateNew;

            using (Stream stream = new FileStream(appSettingsFilePath, fileMode))
            {
                XmlSerializer appSettingsXmlSerializer = new XmlSerializer(this.GetType());
                appSettingsXmlSerializer.Serialize(stream, this);
            }
        }

        public void DeleteAppSettings()
        {
            string appSettingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.xml");
            bool doesAppSettingsFileExists = File.Exists(appSettingsFilePath);
            
            if(doesAppSettingsFileExists)
            {
                File.Delete(appSettingsFilePath);
            }
        }


        public void LoadAppSettings()
        {
            string appSettingsFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appSettings.xml");
            bool doesAppSettingsFileExists = File.Exists(appSettingsFilePath);

            if (doesAppSettingsFileExists)
            {
                using (Stream stream = new FileStream(appSettingsFilePath, FileMode.Open, FileAccess.Read))
                {
                    XmlSerializer appSettingsXmlSerializer = new XmlSerializer(typeof(AppSettings));
                    AppSettings loadedAppSettings = appSettingsXmlSerializer.Deserialize(stream) as AppSettings;
                    this.LastAccessToken = loadedAppSettings.LastAccessToken;
                    this.RememberUser = loadedAppSettings.RememberUser;
                }
            }
        }
    }
}
