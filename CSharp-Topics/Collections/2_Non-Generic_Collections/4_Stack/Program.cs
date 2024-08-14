using System;
using System.Collections;

public class Program
{
    public static void Main()
    {
        // Create and initialize a new Stack.
        Stack myStack = new Stack();

        // Pushing items onto the Stack.
        myStack.Push(10);
        myStack.Push("Hello");
        myStack.Push(true);

        // Peeking at the top item without removing it.
        Console.WriteLine("Top item is: " + myStack.Peek());

        // Popping items from the Stack.
        Console.WriteLine("Popped item: " + myStack.Pop());

        // Checking if an item exists in the Stack.
        if (myStack.Contains("Hello"))
        {
            Console.WriteLine("'Hello' is in the stack.");
        }

        // Iterating over the remaining items.
        foreach (object item in myStack)
        {
            Console.WriteLine("Stack item: " + item);
        }

        // Output:
        // Top item is: True
        // Popped item: True
        // 'Hello' is in the stack.
        // Stack item: Hello
        // Stack item: 10
    }
}
