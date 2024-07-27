using System;
using MyConstructorParameterApplication;
using MyConstructorSoManyParameterApplication;

namespace MyConstructorApplication
{
    class Car
    {
        public string? model;

        // Create a constructor
        public Car()
        {
            model = "Mustang"; // set the initial value for model
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine($"Without user defined COnstructor : {Ford.model}");
            
            // constructor with parameter check `Car.cs` file
            CarInfo Opel = new CarInfo("Astra");
            Console.WriteLine($"With user-defined Constructor : {Opel.model}.");

            NewCarInfo Ferrari = new NewCarInfo("F1", "Red", 2011);
            Console.WriteLine($"One of most famous {Ferrari.model} racing car mostly in {Ferrari.color} in color and start manifacturing from {Ferrari.year}.");
        }
    }
}