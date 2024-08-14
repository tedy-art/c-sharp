using System;
using System.Collections;

namespace nonGenericHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable NonGenericHashTable = new Hashtable();
            NonGenericHashTable.Add(1, "Soda");
            NonGenericHashTable.Add(2, "Burger");
            NonGenericHashTable.Add(3, "Fries");
            NonGenericHashTable.Add(4, "Onion Rings");

            foreach (DictionaryEntry h in NonGenericHashTable)
            {
                Console.WriteLine(h.Key + " " + h.Value);
            }
        }
    }
}