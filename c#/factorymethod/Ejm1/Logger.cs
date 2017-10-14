
namespace FactoryMethod.Ejm1
{
    /// <summary>
    /// Interface que será implementada por FileLogger y ConsoleLogger
    /// </summary>
    interface Logger
    {
        /// <summary>
        /// Registra un mensaje
        /// </summary>
        /// <param name="msg">Mensaje a registrar</param>
        void Log(string msg);
    }
}
