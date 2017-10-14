package patrones.interpreter.ej2;

import java.util.*;

/**
 * Interface que representa cualquier expresion aritmetica. Tiene el método interpret(Stack)
 *
 */
public interface Expression {
	public void interpret(Stack<Integer> s);
}
