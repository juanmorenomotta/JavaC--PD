using System;
namespace FactoryMethod.Ejm1
{
    class BDLogger:Logger
    {
        public void Log(String msg)
        {
            Console.WriteLine(msg + " grabado en la bd");
        }
    }
}
