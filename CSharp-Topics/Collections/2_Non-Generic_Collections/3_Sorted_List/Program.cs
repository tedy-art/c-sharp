using System;
using System.Collections;


namespace nonGenericSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList NonGenericSortedList = new SortedList();
            NonGenericSortedList.Add("American", "Burger");
            NonGenericSortedList.Add("Lime", "Soda");
            NonGenericSortedList.Add("French", "Fries");
            NonGenericSortedList.Add("Onion", "Rings");

            foreach (DictionaryEntry d in NonGenericSortedList)
            {
                Console.WriteLine(d.Key+" "+d.Value);
            }
        }
    }
}