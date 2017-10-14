package patrones.interpreter.ej2;

import java.util.Stack;
/**
 * Expresion resta
 *
 */
public class TerminalExpression_Minus implements Expression {
	
	public void interpret(Stack<Integer> s) {
		int tmp = s.pop();
		s.push(s.pop() - tmp);
	}
}
