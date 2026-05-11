// Program 13: Multiplication Table
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.WriteLine(n + " x " + i + " = " + (n * i));
    }
}
