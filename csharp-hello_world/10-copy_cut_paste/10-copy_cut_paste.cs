using System;

class Program
{
    static void Main(string[] args)
    {
        string word = "Holberton"; 
        string first3 = word.Substring(0, 3);
        string last2 = word.Substring(word.Length -2);
        string middle = word.Substring(1, word.Length -3);
        Console.WriteLine(first3);
        Console.WriteLine(last2);
        Console.WriteLine(middle);
    }
}