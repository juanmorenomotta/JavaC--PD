package patrones.bridge.eje1;

public class Client {
	public static void main(String[] args) {
		// Create an appropriate implementer object
		MessageLogger logger = new FileLogger();
		// Choose required interface object and
		// configure it with the implementer object
		Message msg = new EncryptedMessage(logger);
		msg.log("Test Cifrado");
		
		MessageLogger logger2 = new ConsoleLogger();
		Message msg2 = new TextMessage(logger2);
		msg2.log("Texto Normal");
		
		// Nuevos 
		Message msg3 = new HTMLMessage(logger2);
		msg3.log("Texto en HTML");
		
		MessageLogger logger3 = new DBLogger();
		Message msg4 = new TextMessage(logger3);
		msg4.log("Texto Normal");
	}
}
