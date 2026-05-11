// Program 48: Skip Multiples of 3 While Printing
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Numbers 1-30 skipping multiples of 3:");
        for (int i = 1; i <= 30; i++)
        {
            if (i % 3 == 0) continue;
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
