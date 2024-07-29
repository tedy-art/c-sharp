using System;

namespace ReturnTypes
{
    class Program
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int sum = add(5, 3);
            Console.WriteLine($"sum : {sum}");
        }
    }
}