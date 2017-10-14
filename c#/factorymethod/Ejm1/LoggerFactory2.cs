using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Libs;
namespace FactoryMethod.Ejm1
{
    class LoggerFactory2:LoggerFactory
    {
        public bool IsBDLogginEnabled()
        {
            Dictionary<string, string> properties = Properties.GetProperties(@"d:\logger.properties");
            if (properties["BDLogging"].Equals("ON"))
                return true;
            else
                return false;
        }
        public override Logger getLogger()
        {
            if (IsBDLogginEnabled())
                return new BDLogger();
            else
                if (IsFileLogginEnabled())
                    return new FileLogger();
                else
                    return new ConsoleLogger();
        }
    }
}
