using System;

namespace InterfaceAbstraction
{
    // interface
    public interface IAnimal
    {
        void MakeSound();
        void Sleep();
    }

    // class implementing the interface
    public class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Weow!");
        }

        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
    }
    public class Program
    { 
        public static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.MakeSound();
            cat.Sleep();
            Console.ReadLine();
        }
    }
}