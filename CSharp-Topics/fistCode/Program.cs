using System;


namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // See https://aka.ms/new-console-template for more information
            Console.WriteLine("Hello, World!");

            // Declaring Variables:
            int myNumber = 10;
            Console.WriteLine(myNumber);

            // int example
            int age = 25;
            Console.WriteLine("Age: " + age);

            // long example
            long distanceToMoon = 384400000L; // Distance in meters
            Console.WriteLine("Distance to Moon: " + distanceToMoon + " meters");

            // float example
            float pi = 3.14F;
            Console.WriteLine("Value of Pi: " + pi);

            // double example
            double gravity = 9.81;
            Console.WriteLine("Gravity: " + gravity + " m/s²");

            // bool example
            bool isAlive = true;
            Console.WriteLine("Is Alive: " + isAlive);

            // char example
            char initial = 'A';
            Console.WriteLine("Initial: " + initial);

            // string example
            string greeting = "Hello, World!";
            Console.WriteLine("Greeting: " + greeting);

            // Arithmetic Operators
            int a = 10;
            int b = 5;
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Subtraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));

            // Relational Operators
            Console.WriteLine("Equal: " + (a == b));
            Console.WriteLine("Not Equal: " + (a != b));
            Console.WriteLine("Greater than: " + (a > b));
            Console.WriteLine("Less than: " + (a < b));

            // Logical Operators
            bool x = true;
            bool y = false;
            Console.WriteLine("Logical AND: " + (x && y));
            Console.WriteLine("Logical OR: " + (x || y));
            Console.WriteLine("Logical NOT: " + (!x));

            // Assignment Operators
            int c = 10;
            c += 5;
            Console.WriteLine("Add and assign: " + c);
            c -= 3;
            Console.WriteLine("Subtract and assign: " + c);

            // Bitwise Operators
            int m = 5;  // 0101 in binary
            int n = 3;  // 0011 in binary
            Console.WriteLine("Bitwise AND: " + (m & n));  // 0001 in binary
            Console.WriteLine("Bitwise OR: " + (m | n));   // 0111 in binary
            Console.WriteLine("Bitwise XOR: " + (m ^ n));  // 0110 in binary

            // Conditional (Ternary) Operator
            int max = (a > b) ? a : b;
            Console.WriteLine("Max value: " + max);

            // Null-Coalescing Operator
            string str = null;
            string result = str ?? "Default value";
            Console.WriteLine("Null-Coalescing: " + result);

            // Type Operators
            object obj = "Hello";
            if (obj is string)
            {
                Console.WriteLine("obj is a string");
            }

            string str2 = obj as string;
            if (str2 != null)
            {
                Console.WriteLine("str2: " + str2);
            }
            Console.ReadLine();
        }
    }
}
