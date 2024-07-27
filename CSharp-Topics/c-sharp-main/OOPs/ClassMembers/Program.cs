/*
class Members - 
- Fields and method inside classes are often reffered to as "class members".
*/


using System;

namespace MyApplication
{
    class Car
    {
        // we can also leave the fields blank and modify then later as we want
        public string color; // fields -> class member
        public string model; // fields -> class member
        public int year; // fields -> class member
        public int maxSpeed; // fields -> class member

        public void fullThrottle() // method -> class member
        {
            Console.WriteLine("The car is going as fast as it can!");
        } 

        static void Main(string[] args)
        {
            Car myObj = new Car();
            myObj.color = "red";
            myObj.maxSpeed = 200;

            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.maxSpeed);
            myObj.fullThrottle();

            // leaving blank fields are usefull when creating multiple objects of one class
            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "Red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "Blue";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);
        }
    }
}
