package patrones.singleton.ej2;

public class FileLogger implements Logger {
	private static FileLogger logger;

	//Constructor privado para evitar que los objetos clientes creen varias instancias
	private FileLogger() {

	}

	//Método estático que devuelve una sola instancia de la clase
	public static FileLogger getFileLogger() {
		if (logger == null) {
			logger = new FileLogger();
		}
		return logger;

	}

	//Metodo sincronizado para que dos hilos no lo ejecuten a la vez
	public synchronized void log(String msg) {
		FileUtil futil = new FileUtil();
		futil.writeToFile("log.txt", msg, true, true);
	}
}
