using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace DBConnection
{
    public class Program
    { 

        public void Main()
        {
            Connection oConnection = new Connection();
            oConnection.DBConnect();
            if (oConnection.DBConnect() == true)
            {

            }

        }
    }
}
