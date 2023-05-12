using System;
using System.Collections.Generic;

public class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aStack.Count);

        if (aStack.Count > 0)
        {
            Console.WriteLine("Top item: {0}", aStack.Peek());
        }
        else
        {
            Console.WriteLine("Stack is empty");
        }

        bool containsSearch = aStack.Contains(search);
        Console.WriteLine("Stack contains \"{0}\": {1}", search, containsSearch);

        if (containsSearch)
        {
            while (aStack.Count > 0 && aStack.Peek() != search)
            {
                aStack.Pop();
            }
            aStack.Pop();
        }

        aStack.Push(newItem);

        return aStack;
    }
}