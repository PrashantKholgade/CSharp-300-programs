// Program 32: Print N to 1 Countdown
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
