using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Libs;
namespace Bridge.Ejm1
{
    /// <summary>
    /// Registra un mensaje a un archivo
    /// </summary>
    public class FileLogger : MessageLogger
    {
        public void LogMsg(string msg)
        {
            FileUtil futil = new FileUtil();
            futil.WriteToFile(msg, "log.txt");
        }
    }
}
