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


            Console.ReadLine();
        }
    }
}
