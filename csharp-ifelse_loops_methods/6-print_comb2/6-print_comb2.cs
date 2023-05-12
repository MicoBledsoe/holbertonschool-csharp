using System;

public class Program
{
    static void Main(string[] args)
    {
        for(int dig1 = 0; dig1 <= 9; dig1++)
        {
            for(int dig2 = dig1 + 1; dig2 <= 9; dig2++)
            {
                Console.Write($"{dig1}{dig2}");
                if(dig1 < 8 || dig2 < 9)
                {
                    Console.Write(", ");
                }
            }
        }
    }
}