using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using Logging;

namespace DBConnection
{
    public class Program
    { 
        
        public static void Main(string[] args)
        {
            Log Log = new Log();
            Log.InitializeLog();
            try
            {
              Log.Info("Log Initialisiert!");
              Log.Info("Versuche nun mit der Datenbank zu Verbinden..");
              Connection oConnection = new Connection();
              oConnection.DBConnect();
              if (oConnection.DBConnect() == true)
              {
                Log.Info("Verbindung zur Datenbank erfolgreich!");
              }
              else 
              {
                Log.Warning("Verbindung zur Datenbank konnte nicht hergestellt werden!");
              }
            }
            catch(Exception ex)
            {
              Log.Error(ex.ToString());
            }
          Log.Warning("Program ende! Schließe Log..");
          Log.CloseLog();
        }
    }
}
