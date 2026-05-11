// Program 61: Inverted Pyramid Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = n; i >= 1; i--)
        {
            for (int s = 0; s < n - i; s++) Console.Write(" ");
            for (int j = 0; j < 2 * i - 1; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}
