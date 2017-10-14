
namespace Interpreter.Ejm1
{
    class MultiplyExpression : NonTerminalExpression
    {
        public override int evaluate(Context c)
        {
            return getLeftNode().evaluate(c) * getRightNode().evaluate(c);
        }

        public MultiplyExpression(Expression l, Expression r)
            : base(l, r)
        {

        }
    }
}
