package patrones.bridge.eje1;

/**
 * 
 * EncryptedMessage encripta un mensaje entrante al trasladar todos los
 * caracteres a la derecha por una posición.
 * 
 */
public class EncryptedMessage implements Message {
	private MessageLogger logger;

	public EncryptedMessage(MessageLogger l) {
		logger = l;
	}

	public void log(String msg) {
		String str = preProcess(msg);
		logger.logMsg(str);
	}

	private String preProcess(String msg) {
		msg = msg.substring(msg.length() - 1)
				+ msg.substring(0, msg.length() - 1);
		return msg;
	}
}
