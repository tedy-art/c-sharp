using System;
using System.Collections.Generic;

namespace genericQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> GenericQueue = new Queue<string>();
            GenericQueue.Enqueue("Mark");
            GenericQueue.Enqueue("Bill");
            GenericQueue.Enqueue("Xaviar");
            GenericQueue.Enqueue("Michael");

            foreach(string s in GenericQueue)
            {
                Console.WriteLine(s);
            }
        }
    }
}