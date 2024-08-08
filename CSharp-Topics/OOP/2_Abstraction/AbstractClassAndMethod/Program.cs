using System;

namespace abstractClassAndMethods
{
    // Abstract class
    public abstract class Animal
    {
        // Abstract method(with no implementation)
        public abstract void MakeSound();

        // Concrete Method
        public void Sleep()
        {
            Console.WriteLine("Sleeping..");
        }
    }

    // Derived class(subclass) and inheriting abstract class
    public class Dog : Animal
    { 
        // Providing implementation for the abstract class
        public override void MakeSound()
        {
            Console.WriteLine("woof!");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.MakeSound();
            dog.Sleep();
        }
    }
}