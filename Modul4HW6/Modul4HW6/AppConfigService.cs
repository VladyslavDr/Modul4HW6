using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Modul4HW6
{
    public class AppConfigService
    {
        private const string _configPath = "ConnectionString.json";
        public AppConfigService()
        {
            var config = GetConfig();
            ConnectionString = config.ConnectionString;
        }

        public string ConnectionString { get; }

        private AppConfig GetConfig()
        {
            var json = File.ReadAllText(_configPath);
            var config = JsonConvert.DeserializeObject<AppConfig>(json);
            return config;
        }

        private void Ser()
        {
            var json = JsonConvert.SerializeObject(GetCon());
            File.WriteAllText(_configPath, json);
        }

        private AppConfig GetCon()
        {
            return new AppConfig()
            {
                ConnectionString = "Server = WIN-T2O982ERQRV,1435; Database = HW6db; User = sa; Password = 123456;"
            };
        }
    }
}
