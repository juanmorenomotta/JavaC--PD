
namespace Interpreter.Ejm1
{
    public abstract class NonTerminalExpression : Expression
    {
        private Expression leftNode;
        private Expression rightNode;

        public NonTerminalExpression(Expression l, Expression r)
        {
            setLeftNode(l);
            setRightNode(r);
        }

        public void setLeftNode(Expression node)
        {
            leftNode = node;
        }

        public void setRightNode(Expression node)
        {
            rightNode = node;
        }

        public Expression getLeftNode()
        {
            return leftNode;
        }

        public Expression getRightNode()
        {
            return rightNode;
        }
        public virtual int evaluate(Context c)
        {
            return 1; 
        }
    }

}
