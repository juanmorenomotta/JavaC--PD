package patrones.interpreter.ej2;

class ClienteMain {
	public static void main(String[] args) {
		System.out.println("'42 2 1 - +' equals "
				+ new Parser("42 2 1 - +").evaluate());
	}
}
