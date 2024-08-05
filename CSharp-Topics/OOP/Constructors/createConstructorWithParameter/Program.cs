using System;

namespace MyConstructorParameterApplication
{
    class Car
    {
        public string model;
        public string color;
        public int year;

        // creating a class constructor with parameter
        public Car(string modelName, string ModelColor, int modelYear)
        {
            model = modelName;
            // we can use as many parameter as we want
            color = ModelColor;
            year = modelYear;
        }

        static void Main(string[] args)
        {
            Car Ford = new Car("mustang", "Red", 1969);
            Console.WriteLine($"{Ford.color} {Ford.year} {Ford.model}.");
            Console.ReadLine();
        }
    }
}