using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count > 0)
        {
            Console.WriteLine("First item: {0}", aQueue.Peek());
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine("Queue contains \"{0}\": {1}", search, containsSearch);

        if (containsSearch)
        {
            while (aQueue.Count > 0 && aQueue.Peek() != search)
            {
                aQueue.Dequeue();
            }
            aQueue.Dequeue();
        }

        return aQueue;
    }
}