using System;


namespace MethodOverloading
{
    public class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded method to add two doubles
        public double Add(double a, double b)
        {
            return a + b;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Calculator calc = new Calculator();

            // Calling different overloaded versions of the Add method
            Console.WriteLine(calc.Add(2, 3));        // Outputs: 5
            Console.WriteLine(calc.Add(2, 3, 4));     // Outputs: 9
            Console.WriteLine(calc.Add(2.5, 3.5));    // Outputs: 6.0
        }
    }
}