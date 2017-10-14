package patrones.interpreter.ej2;

import java.util.ArrayList;
import java.util.Stack;

/**
 * Parser: analizador gramatical
 *
 */
public class Parser {
	/**
	 * Arbol de expresiones
	 */
	private ArrayList<Expression> parseTree = new ArrayList<Expression>(); // only one NonTerminal E

	/**
	 * Recorre la expresion y va formando un arbol de expresiones
	 * @param s expresion polaca inversa
	 */
	public Parser(String s) {
		for (String token : s.split(" ")) {
			if (token.equals("+"))
				parseTree.add(new TerminalExpression_Plus());
			else if (token.equals("-"))
				parseTree.add(new TerminalExpression_Minus());
			// ...
			else
				parseTree.add(new TerminalExpression_Number(Integer
						.valueOf(token)));
		}
	}

	/**
	 * Recorrer el árbol de expresiones y lo va evaluando hasta encontrar el valor total de la expresion
	 * @return valor total de la expresion
	 */
	public int evaluate() {
		Stack<Integer> context = new Stack<Integer>();
		for (Expression e : parseTree)
			e.interpret(context);
		return context.pop();
	}
}
