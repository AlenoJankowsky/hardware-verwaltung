using System;
using System.Data;
using System.Data.SqlClient;

namespace DBConnection
{
    public class Connection : Program
    { 
        public bool DBConnect()
        {
            try
            { 
                string sConnectionString = @"Data Source = MyServerName; Initial Catalog = MyDbName; User ID = Admin; Password = Root";
                SqlConnection sqlconnection = new SqlConnection(sConnectionString);
                return true;
                
            }
            catch(Exception ex)
            {
                return false;
            }
         }
    }
}