using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DataAccessScaffolding
{
    internal class Connection
    {
        public SqlConnection connConnection;

        public SqlConnection OpenConnection()
        {
            String strConnectionString;
            try
            {
                string server = ConfigurationManager.AppSettings["server"];
                string user = ConfigurationManager.AppSettings["user"];
                string pw = ConfigurationManager.AppSettings["pw"];
                string db = ConfigurationManager.AppSettings["db"];

                strConnectionString = @"Server=" + server + ";UID=" + user + ";PWD=" + pw + ";Database=" + db;

                connConnection = null;

                connConnection = new SqlConnection(strConnectionString);
                connConnection.Open();

                return connConnection;
            }
            catch (Exception e)
            {
            }
            return connConnection;
        }
    }
}