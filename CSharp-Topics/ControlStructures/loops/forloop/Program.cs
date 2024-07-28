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
            Console.ReadLine();
        }
    }
}