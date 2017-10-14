using System;
using Libs;
using System.Runtime.CompilerServices;

namespace FactoryMethod.Ejm1
{
    /// <summary>
    /// Registra un mensaje y lo graba en un archivo de texto
    /// </summary>
    class FileLogger : Logger
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        public void Log(String msg)
        {
            FileUtil futil = new FileUtil();

            futil.WriteToFile(msg, "log.txt");
        }
    }
}
