package patrones.interpreter.ej2;

import java.util.Stack;
/**
 * Expresion terminal, contiene un entero
 *
 */
public class TerminalExpression_Number implements Expression {
	private int number;

	public TerminalExpression_Number(int number) {
		this.number = number;
	}

	public void interpret(Stack<Integer> s) {
		s.push(number);
	}
}
