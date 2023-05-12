using System;
using System.Collections.Generic;

public class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aQueue.Count}");

        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        aQueue.Enqueue(newItem);

        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains {search}: {containsSearch}");

        if (containsSearch)
        {
            while (aQueue.Count > 0)
            {
                string currentItem = aQueue.Dequeue();
                if (currentItem == search)
                {
                    break;
                }
            }
        }

        return aQueue;
    }
}