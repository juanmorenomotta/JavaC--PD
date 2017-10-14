using System;
using Interpreter.Ejm2;
namespace Interpreter
{
    class Program1
    {
        static void Main(string[] args)
        {
        		Console.WriteLine("'42 2 1 - +' equals "
				+ new Parser("42 2 1 - +").Evaluate());
                Console.ReadKey();
        }
    }
}
