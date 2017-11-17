using System;
namespace Bridge.Ejm1
{
    /// <summary>
    /// Escribe el mensaje a la consola
    /// </summary>
    public class ConsoleLogger : MessageLogger
    {
        public void LogMsg(String msg)
        {
            Console.WriteLine(msg + " por consola");
        }
    }
}
