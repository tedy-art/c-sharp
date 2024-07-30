using System;

namespace MethodOverloading
{
    class Program
    {
        // Method with two int parameters
        static int add(int a, int b)
        {
            return a + b;
        }

        // Method with three int parameters
        static int add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method with two double parameters
        static double add(double a, double b)
        {
            return a + b;
        }

        // Method with two string parameters
        static string add(string a, string b)
        {
            return $"{a} {b}";
        }

        static void Main(string[] args)
        {
            int resultTwoSum = add(5, 3);
            Console.WriteLine($"2 sum : {resultTwoSum}");

            int resultThreeSum = add(3, 4, 5);
            Console.WriteLine($"3 sum : {resultThreeSum}");

            double resultDoubleSum = add(51.11, 4.55);
            Console.WriteLine($"double : {resultDoubleSum}");

            string strConcate = add("I", "Tejas");
            Console.WriteLine($"str : {strConcate}");

            Console.ReadLine();
        }
    }
}
