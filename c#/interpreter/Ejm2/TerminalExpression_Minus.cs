using System.Collections;
namespace Interpreter.Ejm2
{
    public class TerminalExpression_Minus : Expression
    {

        public void Interpret(Stack s)
        {
            int tmp = (int)s.Pop();
            s.Push((int)s.Pop() - tmp);
        }
    }
}
