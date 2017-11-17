using System;
namespace Bridge.Ejm1
{
    /// <summary>
    /// EncryptedMessage encripta un mensaje entrante al trasladar todos los
    /// caracteres a la derecha por una posicion.
    /// </summary>
    public class EncryptedMessage : Message
    {
        private MessageLogger Logger;

        public EncryptedMessage(MessageLogger l)
        {
            Logger = l;
        }

        public void Log(String msg)
        {
            String str = PreProcess(msg);
            Logger.LogMsg(str);
        }

        private String PreProcess(String msg)
        {
            msg = msg.Substring(msg.Length - 1)
                    + msg.Substring(0, msg.Length - 1);
            return msg;
        }
    }
}
