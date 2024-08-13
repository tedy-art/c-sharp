using System;
using System.Collections.Generic;

namespace genericLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddFirst(0);

            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}