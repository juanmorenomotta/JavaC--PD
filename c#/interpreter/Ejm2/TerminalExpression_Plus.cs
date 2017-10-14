using System.Collections;

namespace Interpreter.Ejm2
{
    class TerminalExpression_Plus : Expression
    {

        public void Interpret(Stack s)
        {
            s.Push((int)s.Pop() + (int)s.Pop());
        }
    }
}
