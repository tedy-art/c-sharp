using System;
using System.Collections.Generic;

namespace GenericDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> GenericDictionary = new Dictionary<int, string>();
            GenericDictionary.Add(1, "soda");
            GenericDictionary.Add(2, "Burger");
            GenericDictionary.Add(3, "Fries");
            GenericDictionary.Add(4, "Onion Rings");
            foreach(KeyValuePair<int, string> kvp in GenericDictionary)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}