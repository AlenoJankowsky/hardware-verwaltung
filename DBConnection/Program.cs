namespace DBConnection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Logger oLogger = new Logger();
            oLogger.InitializeLog();

            try
            {
                oLogger.Info("Log Initialisiert!");
                oLogger.Info("Versuche nun mit der Datenbank zu Verbinden..");
                Connection oConnection = new Connection();

                if (Connection.DBConnect())
                {
                    oLogger.Info("Verbindung zur Datenbank erfolgreich!");
                }
                else
                {
                    oLogger.Warning("Verbindung zur Datenbank konnte nicht hergestellt werden!");
                }
            }
            catch (Exception ex)
            {
                oLogger.Error(ex.ToString());
            }

            oLogger.Warning("Programm ende! Schließe Log..");
            oLogger.CloseLog();
        }
    }
}
