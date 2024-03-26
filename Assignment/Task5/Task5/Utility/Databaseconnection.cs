using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5.Database
{
    internal class Databaseconnection
    {
        private static IConfiguration iconfiguration;
        static Databaseconnection()
        {
            GetAppSettingsFile();
        }

        private static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            iconfiguration = builder.Build();
        }

        public static string GetConnectionString()
        {
            return iconfiguration.GetConnectionString("LocalConnectionString");
        }
    }
}
