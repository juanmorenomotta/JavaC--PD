using System;
using FactoryMethod.Ejm1;
namespace FactoryMethod
{
    /// <summary>
    /// Cliente Main
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            
            LoggerFactory2 factory = new LoggerFactory2();
            Logger logger = factory.getLogger();
            logger.Log("Esto es un mensaje");
            Console.ReadKey();
            //Establezca el parámetro FileLogging=ON y ejecute nuevamente la aplicación
        }
    }
}
