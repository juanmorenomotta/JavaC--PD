package patrones.bridge.eje1;

/**
 * 
 * Escribe el mensaje en un archivo.
 *
 */
public class DBLogger implements MessageLogger {
	public void logMsg(String msg) {
	    //FileUtil futil = new FileUtil();
	    //futil.writeToFile("log.txt",msg, true, true);
		System.out.println("Mensaje:" +  msg + " grabado en una base de datos");
	  }
}
