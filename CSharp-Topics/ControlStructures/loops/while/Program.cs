using System;

namespace WhileLoopEx
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 5)
            {
                Console.WriteLine(i);
                i++;
            }

            string userInput = "";
            while (userInput != "exit")
            {
                Console.WriteLine("Enter Something(type 'exit' to quit) : ");
                userInput = Console.ReadLine();
                Console.WriteLine($"you entered : {userInput}");
            }
        }
    }
}