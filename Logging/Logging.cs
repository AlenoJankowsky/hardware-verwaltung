using System;
using System.Collections.Generic;
using System.Resources;
using Internal;
using System.IO;

namespace Logging
{
public class Logging
{
    StreamWriter oSteamWriter = new StreamWriter();
    public void InitializeLog()
    {
        string sLogFolder = @"C:\Users\Admin\Desktop\Logging";
        string sLogFile = Environment.UserName + "_" + DateTime.Now + "_" + "Log.txt";
        string sLogPath = sLogFolder + @"\" + sLogFile; 

        
        
        if (!File.Exists(sLogPath))
        {
         oSteamWriter = File.Create(sLogPath);
        }
        
    
    }
    public void Info(string sInfo)
    {
     oSteamWriter.WriteLine("["+ DateTime.Now + "]"+ "[INF]" + "-> " + sInfo);   
    }
    public void Warning(string sWarning)
    {
     oSteamWriter.WriteLine("["+ DateTime.Now + "]"+ "[WRN]" + "-> " + sWarning);   
    }
    public void Error(string sException)
    {
    oSteamWriter.WriteLine("["+ DateTime.Now + "]"+ "[ERR]" + "-> " + sException);   
    }}
}