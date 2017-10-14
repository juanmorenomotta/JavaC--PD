using System;
using System.Collections.Generic;
namespace Interpreter.Ejm1
{
    public class Context
    {
        private Dictionary<string, int> varList = new Dictionary<string, int>();

        public void assign(String var, int value)
        {
            varList.Add(var, value);
        }

        public int getValue(String var)
        {
            int objInt = (int)varList[var];
            return objInt;
        }

        public Context()
        {
            initialize();
        }

        //Values are hardcoded to keep the example simple
        private void initialize()
        {
            assign("a", 20);
            assign("b", 40);
            assign("c", 30);
            assign("d", 10);
        }
    }
}
