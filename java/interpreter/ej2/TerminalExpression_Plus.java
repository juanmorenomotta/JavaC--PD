package patrones.interpreter.ej2;

import java.util.Stack;

/**
 * Expresion suma
 *
 */
class TerminalExpression_Plus implements Expression {
	
	public void interpret(Stack<Integer> s) {
		s.push(s.pop() + s.pop());
	}
}
