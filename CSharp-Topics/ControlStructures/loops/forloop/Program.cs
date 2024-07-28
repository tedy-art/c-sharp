using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n\nAnother ex:");
            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\n\nnested for loop");
            // Outer loop
            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
                }
            }
            Console.ReadLine();
        }
    }
}