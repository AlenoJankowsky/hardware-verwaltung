using System;
using System.Collections.Generic;
using System.Resources;
//using Internal;
using System.IO;


namespace Logging
{
public class Log
{
    public static void Main(string[] args)
    {
       
    }
    private StreamWriter? oStreamWriter;
    public void InitializeLog()
    {
        //Manuelle Pfadeingabe beachten!
        string sLogFolder = @"C:\Users\Admin\Desktop\Logging";
        string sLogFile = Environment.UserName + "_" + DateTime.Now.ToString("yyyyMMdd") + "_" + "Log.txt";
        string sLogPath = sLogFolder + @"\" + sLogFile; 
        
        
        
        if (!File.Exists(sLogPath))
        {
         File.Create(sLogPath).Dispose();
        }
        oStreamWriter = new StreamWriter(sLogPath,append: true);
    
    }
    public void Info(string sInfo)
    {
     if(oStreamWriter != null)
     {
      oStreamWriter.WriteLine("["+ DateTime.Now + "]"+ "[INF]" + "-> " + sInfo);   
      oStreamWriter.Flush();
     }
    }
    public void Warning(string sWarning)
    {
    if(oStreamWriter != null)
     {
      oStreamWriter.WriteLine("["+ DateTime.Now + "]"+ "[WRN]" + "-> " + sWarning);   
      oStreamWriter.Flush();
     }
    }
    public void Error(string sException)
    {
    if(oStreamWriter != null)
     {
      oStreamWriter.WriteLine("["+ DateTime.Now + "]"+ "[ERR]" + "-> " + sException);   
      oStreamWriter.Flush();
     }
    }
    public void CloseLog()
    {
    if(oStreamWriter != null) oStreamWriter.Close();
    }
    }
}