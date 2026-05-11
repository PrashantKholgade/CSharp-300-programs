// Program 52: Inverted Right Triangle Star Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++) Console.Write("* ");
            Console.WriteLine();
        }
    }
}
