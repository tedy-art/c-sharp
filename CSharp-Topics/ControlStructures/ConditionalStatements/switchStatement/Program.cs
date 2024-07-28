using System;

namespace SwitchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            switch (number)
            {
                case 1:
                    Console.WriteLine("The number is one.");
                    break;
                case 2:
                    Console.WriteLine("The number is two.");
                    break;
                case 3:
                    Console.WriteLine("The number is three.");
                    break;
                case 4:
                    Console.WriteLine("The number is four.");
                    break;
                default:
                    Console.WriteLine("The number is not between 1 and 4.");
                    break;
            }

            Console.WriteLine("Enhanced Example With Fall-through :");
            char grade = 'B';

            switch (grade)
            {
                case 'A':
                case 'B':
                case 'C':
                    Console.WriteLine("Passing grade.");
                    break;
                case 'D':
                case 'F':
                    Console.WriteLine("Failing grade.");
                    break;
                default:
                    Console.WriteLine("Invalid grade.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
