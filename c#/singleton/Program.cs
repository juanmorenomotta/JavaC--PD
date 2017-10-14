using System;
using Singleton.Ejm1;
using Singleton.Ejm2;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            LoggerFactory factory = new LoggerFactory();
            //Al invocar la fabrica, no importa la cantidad de veces, siempre devuelve una referencia al objeto FileLogger
            Logger logger = factory.getLogger();
            logger.Log("A Message to Log");*/


            DBConnection conn = DBConnection.getDBConnection();
            conn.Connect("empleados");
            conn.Disconnect();

            DBConnection conn2 = DBConnection.getDBConnection();
            conn2.Connect("nomina");
            conn2.Disconnect();
            //DBConnection conn3 = new DBConnection();


            Console.ReadKey();
        }
    }
}
