using System;
using System.Collections;
namespace Interpreter.Ejm2
{
    public class Parser
    {
        /**
         * Arbol de expresiones
         */
        private ArrayList parseTree = new ArrayList(); // only one NonTerminal E

        /**
         * Recorre la expresion y va formando un arbol de expresiones
         * @param s expresion polaca inversa
         */
        public Parser(string s)
        {

            foreach (string token in s.Split(' '))
            {
                if (token.Equals("+"))
                    parseTree.Add(new TerminalExpression_Plus());
                else if (token.Equals("-"))
                    parseTree.Add(new TerminalExpression_Minus());
                // ...
                else
                    parseTree.Add(new TerminalExpression_Number(Convert.ToInt16(token)));
            }
        }

        /**
         * Recorrer el Arbol de expresiones y lo va evaluando hasta encontrar el valor total de la expresion
         * @return valor total de la expresion
         */
        public int Evaluate()
        {
            Stack context = new Stack();
            foreach (Expression e in parseTree)
                e.Interpret(context);
            return (int)context.Pop();
        }
    }

}
