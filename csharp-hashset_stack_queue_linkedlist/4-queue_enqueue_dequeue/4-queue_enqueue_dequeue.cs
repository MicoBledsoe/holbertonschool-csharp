using System;
using System.Collections.Generic;

class Program
{
    // Main - entry point
    static void Main(string[] args)
    {
        // Case 1
        Queue<string> queue1 = new Queue<string>(new[] {"C", "HTML", "Javascript", "Python", "React", "Ruby"});
        TestQueue(queue1, "C#", "Javascript");

        // Case 2
        Queue<string> queue2 = new Queue<string>(new[] {"Cohort 0", "Cohort 1", "Cohort 2", "Cohort 3", "Cohort 4", "Cohort 5", "Cohort 6", "Cohort 7"});
        TestQueue(queue2, "Cohort 8", "Cohort 5");

        // Case 3
        Queue<string> queue3 = new Queue<string>(new[] {"C", "HTML", "Javascript", "Python", "React", "Ruby"});
        TestQueue(queue3, "C#", "C++");

        // Case 4
        Queue<string> queue4 = new Queue<string>();
        TestQueue(queue4, "C#", "C++");
    }

    static void TestQueue(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Initial queue:");
        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("------");

        MyQueue.Info(aQueue, newItem, search);

        Console.WriteLine("------");

        Console.WriteLine("Modified queue:");
        foreach (string item in aQueue)
            Console.WriteLine(item);

        Console.WriteLine("======");
    }
}