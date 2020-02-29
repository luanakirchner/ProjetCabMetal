using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Json.Net;
using Newtonsoft.Json;

namespace CabMetal
{
    class ConfigurationDB
    {
        private string server;
        private string database;
        private string uid;
        private string password;

        public string Server { get => server; set => server = value; }
        public string Database { get => database; set => database = value; }
        public string Uid { get => uid; set => uid = value; }
        public string Password { get => password; set => password = value; }

        public static ConfigurationDB FromJson(string jsonString)
        {
            return JsonConvert.DeserializeObject<ConfigurationDB>(jsonString);
        }
    }
}
