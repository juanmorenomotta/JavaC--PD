package patrones.singleton.ej2;

import java.io.IOException;
import java.util.Properties;

public class LoggerFactory {
	public boolean isFileLoggingEnabled() {
		Properties p = new Properties();
		try {
			p.load(ClassLoader.getSystemResourceAsStream("logger.properties"));
			String fileLoggingValue = p.getProperty("FileLogging");
			if (fileLoggingValue.equalsIgnoreCase("ON") == true)
				return true;
			else
				return false;
		} catch (IOException e) {
			return false;
		}
	}

	//Factory Method
	public Logger getLogger() {
		if (isFileLoggingEnabled()) {
			//Notar este cambio
			return FileLogger.getFileLogger();
		} else {
			return new ConsoleLogger();
		}
	}
}
