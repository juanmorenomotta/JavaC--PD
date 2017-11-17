using System;
namespace Bridge.Ejm1
{
    /// <summary>
    /// Mensaje de texto
    /// </summary>
    public class TextMessage : Message
    {
        private MessageLogger Logger;

        public TextMessage(MessageLogger l)
        {
            Logger = l;
        }

        public void Log(String msg)
        {
            String str = preProcess(msg);
            Logger.LogMsg(str);
        }

        private String preProcess(String msg)
        {
            return msg;
        }
    }
}
