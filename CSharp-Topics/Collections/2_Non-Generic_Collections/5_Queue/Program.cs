using System;
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        // create and initialize a new Queue
        Queue myQueue = new Queue();

        // Enqueuing item into the Queue
        myQueue.Enqueue(10);
        myQueue.Enqueue("Hello");
        myQueue.Enqueue(true);

        // Peeking at the front item without removing it.
        Console.WriteLine("Front item is : " + myQueue.Peek());

        // Dequeuing item from the queue
        Console.WriteLine("Dequeuing item : " + myQueue.Dequeue());

        // checking if an item item exist in the Queue
        if(myQueue.Contains("Hello"))
        {
            Console.WriteLine("'Hello' is in the queue.");
        }

        // Iterate
        foreach(object item in myQueue)
        {
            Console.WriteLine("Queue item : " + item);
        }
    }
}