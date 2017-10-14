
namespace Interpreter.Ejm1
{
    class SubtractExpression : NonTerminalExpression
    {
        public override int evaluate(Context c)
        {
            return getLeftNode().evaluate(c) - getRightNode().evaluate(c);
        }

        public SubtractExpression(Expression l, Expression r)
            : base(l, r)
        {
        }
    }
}
