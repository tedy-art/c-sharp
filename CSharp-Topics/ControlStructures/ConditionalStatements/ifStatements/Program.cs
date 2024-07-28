using System;

namespace ConditionalIfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // if statement
            Console.WriteLine("if statement:");
            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("x is greater than y");
            }

            // if-else statement
            Console.WriteLine("if-else statement:");
            int number = 3;

            if(number > 5)
            {
                Console.WriteLine("The number is greater than 5");
            }
            else
            {
                Console.WriteLine("The number is 5 or less");
            }

            // else if
            Console.WriteLine("else if statement:");
            int num = 10;

            if (num > 10)
            {
                Console.WriteLine("The number is greater than 10.");
            }
            else if (num == 10)
            {
                Console.WriteLine("The number is exactly 10.");
            }
            else if (num > 5)
            {
                Console.WriteLine("The number is greater than 5 but less than 10.");
            }
            else
            {
                Console.WriteLine("The number is 5 or less.");
            }

            Console.ReadLine();
        }
    }
}
