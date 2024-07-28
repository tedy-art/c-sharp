using System;

namespace doWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i <= 5);


            string userInput;

            do
            {
                Console.WriteLine("Enter Something(type 'exit' to quit) : ");
                userInput = Console.ReadLine();
                Console.WriteLine("You entered: " + userInput);
            } while (userInput != "exit");
        }
    }
}