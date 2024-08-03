using System;

namespace MyApplication
{
    class Car
    {
        public string model;

        // creating a constructor for Car class
        public Car()
        {
            model = "mustang";
        }

        static void Main(string[] args)
        {
            Car Ford = new Car();
            Console.WriteLine(Ford.model);
        }
    }
}