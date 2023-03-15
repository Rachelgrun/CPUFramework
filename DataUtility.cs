using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUFramework
{
   public static class DataUtility
    {
        private static string connstring = "";
        //private static string connstring = "Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true";

        public static string SetConnectionString(string servername, string databasename, string username, string password)
        {
            connstring = "Server =tcp:" + servername
                + "; Initial Catalog=" + databasename +
                "; Persist Security Info = False; User ID=" + username
                 + "; Password = " + password +
                "; MultipleActiveResultSets=False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30";

            using (SqlConnection conn = new SqlConnection(connstring))
            {
                conn.Open();
            }
            return connstring;
        }


        public static string ConnectionString { get => connstring; set => connstring = value; }
    }
}


//Server =tcp: rgrunwald.database.windows.net,1433; Initial Catalog= PortfolioDB; Persist Security Info = False; User ID= rgrunwaldadmin; Password = CPU123!@#;MultipleActiveResultSets=False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30; 