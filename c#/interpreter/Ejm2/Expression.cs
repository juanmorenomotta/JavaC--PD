using System.Collections;
namespace Interpreter.Ejm2
{
    /// <summary>
    /// Interface que representa cualquier expresion aritmetica. Tiene el metodo interpret(Stack)
    /// </summary>
    public interface Expression
    {
         void Interpret(Stack s);
    }
}
