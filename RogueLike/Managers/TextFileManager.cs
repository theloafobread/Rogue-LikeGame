using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Security.Cryptography;

namespace RogueLike.Managers
{
    public class TextFileManager
    {
        private string dir;

        public string GetDataFromFile(string path)
        {
            dir = Directory.GetCurrentDirectory().ToString();
            Console.WriteLine("Data loaded from: " + dir + @"\" + path);
            string content = File.ReadAllText(dir + @"\" + path);
            return content;
        }

        public string[] GetSettingSection(string content)
        {
            string[] settingSections = content.Split(';');
            return settingSections;
        }

        public string[] GetSettings(string content)
        {
            string[] settings = content.Split(',');
            return settings;
        }

        public string GetSettingValue(string[] Settings, string settingID)
        {
            foreach (string s in Settings)
            {
                if (s.Contains(settingID))
                {
                    string[] setting = s.Split(':');
                    return setting[1];
                }
            }
            Console.WriteLine("Did not find value in provided array");
            return null;
        }

        public void SetVariableValue(string path, string settingID, string settingValue)
        {
            string temp = File.ReadAllText(path);
            string[] settings = temp.Split(',');

            foreach (string s in settings)
            {
                if (s.Contains(settingID))
                {
                    temp.Replace(s, settingID + ":" + settingValue);
                }
            }
        }
    }
}
