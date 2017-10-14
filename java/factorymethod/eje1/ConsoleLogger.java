package patrones.factorymethod.eje1;

public class ConsoleLogger implements Logger {
	public void log(String msg) {
		System.out.println(msg);
	}
}
