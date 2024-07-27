using System;

namespace MyApplication
{
    class Car
    {
        string? color;  // Nullable field
        int maxSpeed;   // Non-nullable field with default value


        public void fullThrottle() // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }

        static void Main(string[] args)
        {
            // Initialize the Car object with values
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;
            myObj.fullThrottle();  // Call the method
            
            // Using the fields to avoid warnings
            Console.WriteLine($"Color: {myObj.color}");
            Console.WriteLine($"Max Speed: {myObj.maxSpeed}");
        }
    }
}
