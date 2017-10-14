using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using Interpreter.Ejm1;
namespace Interpreter
{
    public class Calculator
    {
        private string expression;
        private Dictionary<string, string> operators;
        private Context ctx;

        static void Main2(string[] args)
        {
            Calculator calc = new Calculator();
            //instantiate the context
            Context ctx = new Context();
            //set the expression to evaluate
            //calc.setExpression("(a+b)*(c-d)");
            calc.setExpression("(a*c)-b");
            //configure the calculator with the
            //Context
            calc.setContext(ctx);
            //Display the result
            Console.WriteLine(" Variable Values: " + "a=" + ctx.getValue("a")
                    + ", b=" + ctx.getValue("b") + ", c=" + ctx.getValue("c")
                    + ", d=" + ctx.getValue("d"));
            Console.WriteLine(" Expression = (a+b)*(c-d)");
            Console.WriteLine(" Result = " + calc.evaluate());
            Console.ReadKey();
        }
        //Constructor
        public Calculator()
        {
            operators = new Dictionary<string, string>();
            operators.Add("+", "1");
            operators.Add("-", "1");
            operators.Add("/", "2");
            operators.Add("*", "2");
            operators.Add("(", "0");
        }


        public int evaluate()
        {
            //infix to Postfix
            string pfExpr = infixToPostFix(expression);


            Expression exp = buildTree(pfExpr);
            return exp.evaluate(ctx);
        }

        private bool isOperator(string currChar)
        {
            if (currChar.Equals("+") || currChar.Equals("-")
                    || currChar.Equals("*") || currChar.Equals("/"))
                return true;
            else
                return false;
        }

        private string infixToPostFix(string str)
        {
            Stack s = new Stack();
            string pfExpr = "";
            string tempStr = "";
            string expr = str.Trim();
            for (int i = 0; i < str.Length; i++)
            {
                string currChar = str.Substring(i, 1);
                if ((isOperator(currChar) == false) && (!currChar.Equals("("))
                        && (!currChar.Equals(")")))
                {
                    pfExpr = pfExpr + currChar;
                }
                if (currChar.Equals("("))
                {
                    s.Push(currChar);
                }
                //for ')' Pop all stack contents until '('
                if (currChar.Equals(")"))
                {
                    tempStr = (string)s.Pop();
                    while (!tempStr.Equals("("))
                    {
                        pfExpr = pfExpr + tempStr;
                        tempStr = (string)s.Pop();
                    }
                    tempStr = "";
                }
                //if the current character is an
                //operator
                if (isOperator(currChar))
                {
                    if (s.Count != 0)
                    {
                        tempStr = (string)s.Pop();
                        string strVal1 = operators[tempStr];
                        int val1 = Convert.ToInt16(strVal1);
                        string strVal2 = operators[currChar];
                        int val2 = Convert.ToInt16(strVal2);
                        while ((val1 >= val2))
                        {
                            pfExpr = pfExpr + tempStr;
                            val1 = -100;
                            if (s.Count != 0)
                            {
                                tempStr = (string)s.Pop();
                                strVal1 = operators[tempStr];
                                val1 = Convert.ToInt16(strVal1);
                            }
                        }
                        if ((val1 < val2) && (val1 != -100))
                            s.Push(tempStr);
                    }
                    s.Push(currChar);
                }//if
            }//for

            while (s.Count != 0)
            {
                tempStr = (string)s.Pop();
                pfExpr = pfExpr + tempStr;
            }
            return pfExpr;
        }

        public void setContext(Context c)
        {
            this.ctx = c;
        }

        public void setExpression(string expr)
        {
            expression = expr;
        }

        private Expression buildTree(string expr)
        {
            Stack s = new Stack();
            for (int i = 0; i < expr.Length; i++)
            {
                string currChar = expr.Substring(i, 1);
                if (isOperator(currChar) == false)
                {
                    Expression e = new TerminalExpression(currChar);
                    s.Push(e);
                }
                else
                {
                    Expression r = (Expression)s.Pop();
                    Expression l = (Expression)s.Pop();
                    Expression n = getNonTerminalExpression(currChar, l, r);
                    s.Push(n);
                }
            }//for
            return (Expression)s.Pop();
        }

        private Expression getNonTerminalExpression(string caracter,
                Expression left, Expression right)
        {
            if (caracter.Equals("+"))
                return new AddExpression(left, right);
            if (caracter.Equals("-"))
                return new SubtractExpression(left, right);
            if (caracter.Equals("*"))
                return new MultiplyExpression(left, right);
            return null;
        }
    }//End of class
}
