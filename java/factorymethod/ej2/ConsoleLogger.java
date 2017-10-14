package patrones.factorymethod.ej2;

public class ConsoleLogger implements Logger {
	public void log(String msg) {
		System.out.println(msg);
	}
}
