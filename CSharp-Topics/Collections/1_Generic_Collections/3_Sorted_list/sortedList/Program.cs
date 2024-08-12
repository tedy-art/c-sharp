using System;
using System.Collections.Generic;

namespace genericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> GenericSortedList = new SortedList<string, string>();
            GenericSortedList.Add("American", "Burger");
            GenericSortedList.Add("Lime", "Soda");
            GenericSortedList.Add("French", "Fries");
            GenericSortedList.Add("Onion", "Rings");

            foreach(KeyValuePair<string, string> kvp in GenericSortedList)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}