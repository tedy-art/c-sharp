using System;

namespace ParameterAndArguments
{
    class Program
    {
        static void myMethod(string fname)
        {
            Console.WriteLine(fname + " Refsnes");
        }

        // define methods with arguments
        static int Add(int x, int y)
        {
            return x + y; 
        }
        
        static void Main(string[] args)
        {
            myMethod("Liam");
            myMethod("Jenney");
            myMethod("Anja");

            int result = Add(5, 3);
            Console.WriteLine($"Sum: {result}");
            Console.ReadLine();
        }
    }
}