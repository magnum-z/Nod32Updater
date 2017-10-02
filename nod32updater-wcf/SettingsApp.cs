using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace nod32updater_wcf
{
    class SettingsApp
    {
        Configuration currentConfig;

        public SettingsApp()
        {
            currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }
                
        public string ReadValue(string key)
        {
            string keyValue = ConfigurationManager.AppSettings[key];
            return keyValue;
        }

        public void SaveValue(string key, string value)
        {
            if (!ConfigurationManager.AppSettings.AllKeys.Contains(key))
            {
                currentConfig.AppSettings.Settings.Add(key, "");
            }
            currentConfig.AppSettings.Settings[key].Value = value;
            currentConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");            
        }

    }
}
