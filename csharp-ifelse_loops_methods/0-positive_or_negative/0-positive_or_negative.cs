using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10, 10);
        Console.Write("{0}", number);

    if(number > 0)
    {
        Console.WriteLine("is positive");
    }
    else if(number < 0)
    {
        Console.WriteLine("is negative");
    }
    else
    {
        Console.WriteLine("is zero");s
    }
    }
}