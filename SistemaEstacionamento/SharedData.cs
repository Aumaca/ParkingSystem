using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEstacionamento
{
    public static class SharedData
    {
        private static int activeVaga = 1;
        public static int ActiveVaga
        {
            get { return activeVaga; }
            set { activeVaga = value; }
        }

        public static class ConfigurationHelper
        {
            public static string GetConfigurationValue(string key)
            {
                return ConfigurationManager.AppSettings[key];
            }

            public static void SetConfigurationValue(string key, string value)
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings[key].Value = value;
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        public static string ValorHora
        {
            get { return ConfigurationHelper.GetConfigurationValue("ValorHora"); }
            set { ConfigurationHelper.SetConfigurationValue("ValorHora", value); }
        }

        public static string NumeroVagas
        {
            get { return ConfigurationHelper.GetConfigurationValue("NumeroVagas"); }
            set { ConfigurationHelper.SetConfigurationValue("NumeroVagas", value); }
        }
    }
}
