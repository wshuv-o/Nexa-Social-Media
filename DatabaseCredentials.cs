using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media
{
    internal static class DatabaseCredentials
    {
        public static string connectionStringLocalServer = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=;Max Pool Size=100;";
        public static string connectionStringVirtualServer = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";
        public static string connectionStringTunneldServer = "server=127.0.0.1;user=root;database=nexaa;port=3306;password=";
   
    }
}
