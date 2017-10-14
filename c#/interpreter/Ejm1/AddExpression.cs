
namespace Interpreter.Ejm1
{
    class AddExpression : NonTerminalExpression
    {
        public override int evaluate(Context c)
        {
            return getLeftNode().evaluate(c) + getRightNode().evaluate(c);
        }

        public AddExpression(Expression l, Expression r)
            : base(l, r)
        {

        }
    }
}
