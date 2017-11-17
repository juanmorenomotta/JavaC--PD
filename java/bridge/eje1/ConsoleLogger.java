package patrones.bridge.eje1;
/**
 * Escribe el mensaje a la consola
 *
 */
public class ConsoleLogger implements MessageLogger {
	public void logMsg(String msg) {
		System.out.println(msg + " por consola");
	}
}
