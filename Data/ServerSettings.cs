using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class ServerSettings
    {
        //        DESKTOP-9802V5M\JSSQLSERVER
        //        TRANSFORMER10\SQLEXPRESS2017
        public static string ServerName { get; set; } = @"DESKTOP-9802V5M\JSSQLSERVER";
        public static string DatabaseName { get; set; } = "TransformerBank";


    }
}
