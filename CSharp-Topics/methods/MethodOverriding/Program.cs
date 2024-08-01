using System;

namespace MethodOverridingTest
{
    // Base class
    class Animal
    {
        // Virtual method
        public virtual void Speak()
        {
            Console.WriteLine("The animal makes a sound.");
        }
    }

    // Derived class
    class Dog : Animal
    {
        // Overriding method
        public override void Speak()
        {
            Console.WriteLine("The dog barks.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();  // Create a base class object
            Animal myDog = new Dog();        // Create a derived class object

            myAnimal.Speak();  // Calls the base class method
            myDog.Speak();     // Calls the overridden method in the derived class
        }
    }
}
