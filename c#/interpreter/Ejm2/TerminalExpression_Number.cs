using System.Collections;
namespace Interpreter.Ejm2
{
    /// <summary>
    /// Expresion terminal. Contiene un enteros
    /// </summary>
    public class TerminalExpression_Number : Expression
    {
        private int number;

        public TerminalExpression_Number(int number)
        {
            this.number = number;
        }

        public void Interpret(Stack s)
        {
            s.Push(number);
        }
    }
}
