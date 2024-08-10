using System;

namespace MethodOverring
{
    public class Animal
    {
        // Virtual method in the base class
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    public class Dog : Animal
    {
        // Overriding the MakeSound method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("The dog says: Woof!");
        }
    }

    public class Cat : Animal
    {
        // Overriding the MakeSound method in the derived class
        public override void MakeSound()
        {
            Console.WriteLine("The cat says: Meow!");
        }
    }

    public class Program
    {
        public static void Main()
        {
            // Base class reference pointing to a derived class object
            Animal myAnimal;

            // Creating a Dog object and assigning it to an Animal reference
            myAnimal = new Dog();
            myAnimal.MakeSound();  // Outputs: The dog says: Woof!
    
            // Creating a Cat object and assigning it to an Animal reference
            myAnimal = new Cat();
            myAnimal.MakeSound();  // Outputs: The cat says: Meow!

            // Creating an Animal object and calling its method
            myAnimal = new Animal();
            myAnimal.MakeSound();  // Outputs: The animal makes a sound
        }
    }
}