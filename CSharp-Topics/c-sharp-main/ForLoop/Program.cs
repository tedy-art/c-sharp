using System;

namespace myApplication
{
    class Program
    {
        static void Main(string[] args){
            Console.WriteLine("First Example : ");
            for (int i = 0; i < 5; i++){
                Console.WriteLine(i);
            }

            Console.WriteLine("\nSecond Example : ");
            for (int x=0; x<=10; x=x+2){
                Console.WriteLine(x);
            }

            Console.WriteLine("\nThird Example for Nested for loop : ");
            // Outer loop
            for (int i = 1; i <= 2; ++i) 
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++) 
                {
                    Console.WriteLine(" Inner: " + j); // Executes 6 times (2 * 3)
                }
            }        

            Console.WriteLine("\nThird Example for foreach loop : ");
            string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};

            foreach (string i in cars){
                Console.WriteLine(i);
            }
        }
    }
}