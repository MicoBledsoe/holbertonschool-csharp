using System;

public class Program
{
    static void Main(string[] args)
    {
        for(int num = 0; num <= 99; num++)
        {
            Console.Write($"{num} = Ox{num.ToString("X")}\n");
        }
    }
}