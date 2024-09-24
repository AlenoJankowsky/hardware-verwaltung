using System;
using System.Data;
using System.Data.SqlClient;
using Logging;

namespace DBConnection
{
    public class Connection : Program
    { 
        Log Log = new Log();
        public bool DBConnect()
        {
            try
            { 
                string sConnectionString = @"Data Source = MyServerName; Initial Catalog = MyDbName; User ID = Admin; Password = Root";
                SqlConnection sqlconnection = new SqlConnection(sConnectionString);
                sqlconnection.Open();
                return true;
                
                
            }
            catch
            {
                
                return false;
            }
         }
    }
}