package patrones.interpreter.ej1;

import java.util.HashMap;
import java.util.Stack;
public class Calculator {
	private String expression;
	private HashMap operators;
	private Context ctx;

	public static void main(String[] args) {
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
		System.out.println(" Variable Values: " + "a=" + ctx.getValue("a")
				+ ", b=" + ctx.getValue("b") + ", c=" + ctx.getValue("c")
				+ ", d=" + ctx.getValue("d"));
		System.out.println(" Expression = (a+b)*(c-d)");
		System.out.println(" Result = " + calc.evaluate());
	}

	public Calculator() {
		operators = new HashMap();
		operators.put("+", "1");
		operators.put("-", "1");
		operators.put("/", "2");
		operators.put("*", "2");
		operators.put("(", "0");
	}


	public int evaluate() {
		//infix to Postfix
		String pfExpr = infixToPostFix(expression);
		
		Expression exp = buildTree(pfExpr);
		return exp.evaluate(ctx);
	}

	private boolean isOperator(String currChar) {
		if (currChar.equals("+") || currChar.equals("-")
				|| currChar.equals("*") || currChar.equals("/"))
			return true;
		else
			return false;
	}

	private String infixToPostFix(String str) {
		Stack s = new Stack();
		String pfExpr = "";
		String tempStr = "";
		String expr = str.trim();
		for (int i = 0; i < str.length(); i++) {
			String currChar = str.substring(i, i + 1);
			if ((isOperator(currChar) == false) && (!currChar.equals("("))
					&& (!currChar.equals(")"))) {
				pfExpr = pfExpr + currChar;
			}
			if (currChar.equals("(")) {
				s.push(currChar);
			}
			//for ')' pop all stack contents until '('
			if (currChar.equals(")")) {
				tempStr = (String) s.pop();
				while (!tempStr.equals("(")) {
					pfExpr = pfExpr + tempStr;
					tempStr = (String) s.pop();
				}
				tempStr = "";
			}
			//if the current character is an
			//operator
			if (isOperator(currChar)) {
				if (s.isEmpty() == false) {
					tempStr = (String) s.pop();
					String strVal1 = (String) operators.get(tempStr);
					int val1 = new Integer(strVal1).intValue();
					String strVal2 = (String) operators.get(currChar);
					int val2 = new Integer(strVal2).intValue();
					while ((val1 >= val2)) {
						pfExpr = pfExpr + tempStr;
						val1 = -100;
						if (s.isEmpty() == false) {
							tempStr = (String) s.pop();
							strVal1 = (String) operators.get(tempStr);
							val1 = new Integer(strVal1).intValue();
						}
					}
					if ((val1 < val2) && (val1 != -100))
						s.push(tempStr);
				}
				s.push(currChar);
			}//if
		}//for
		while (s.isEmpty() == false) {
			tempStr = (String) s.pop();
			pfExpr = pfExpr + tempStr;
		}
		return pfExpr;
	}

	public void setContext(Context c) {
		ctx = c;
	}

	public void setExpression(String expr) {
		expression = expr;
	}

	private Expression buildTree(String expr) {
		Stack s = new Stack();
		for (int i = 0; i < expr.length(); i++) {
			String currChar = expr.substring(i, i + 1);
			if (isOperator(currChar) == false) {
				Expression e = new TerminalExpression(currChar);
				s.push(e);
			} else {
				Expression r = (Expression) s.pop();
				Expression l = (Expression) s.pop();
				Expression n = getNonTerminalExpression(currChar, l, r);
				s.push(n);
			}
		}//for
		return (Expression) s.pop();
	}

	private Expression getNonTerminalExpression(String caracter,
			Expression left, Expression right) {
		if (caracter.equals("+"))
			return new AddExpression(left, right);
		if (caracter.equals("-"))
			return new SubtractExpression(left, right);
		if (caracter.equals("*"))
			return new MultiplyExpression(left, right);
		return null;
	}
}//End of class
