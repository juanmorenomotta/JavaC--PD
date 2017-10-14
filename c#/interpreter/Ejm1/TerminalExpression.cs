
namespace Interpreter.Ejm1
{
    public class TerminalExpression : Expression
    {
        private string var;

        public TerminalExpression(string v)
        {
            var = v;
        }

        public int evaluate(Context c)
        {
            return c.getValue(var);
        }
    }
}
