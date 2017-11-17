package patrones.bridge.eje1;

public class HTMLMessage implements Message {
	private MessageLogger logger;

	public HTMLMessage(MessageLogger l) {
		logger = l;
	}

	public void log(String msg) {
		String str = preProcess(msg);
		logger.logMsg(str);
	}

	private String preProcess(String msg) {
		return "<strong>" + msg + "</strong>";
	}
}
