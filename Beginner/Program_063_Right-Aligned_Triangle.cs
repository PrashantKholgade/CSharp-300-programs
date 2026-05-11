// Program 63: Right-Aligned Triangle
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int s = 0; s < n - i; s++) Console.Write("  ");
            for (int j = 0; j < i; j++) Console.Write("* ");
            Console.WriteLine();
        }
    }
}
