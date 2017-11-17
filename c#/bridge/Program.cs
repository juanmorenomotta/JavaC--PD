using System;
using Bridge.Ejm1;
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an appropriate implementer object
            MessageLogger logger = new FileLogger();
            // Choose required interface object and
            // configure it with the implementer object
            Message msg = new EncryptedMessage(logger);
            msg.Log("Test Cifrado");

            MessageLogger logger2 = new ConsoleLogger();
            Message msg2 = new TextMessage(logger2);
            msg2.Log("Texto Normal");
            Console.ReadKey();
        }
    }
}
