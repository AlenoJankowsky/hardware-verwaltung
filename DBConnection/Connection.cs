using System.Data.SqlClient;

namespace DBConnection
{
    public class Connection
    {
        public static bool DBConnect()
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
