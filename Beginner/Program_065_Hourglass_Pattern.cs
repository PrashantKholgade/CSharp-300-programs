// Program 65: Hourglass Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Rows (odd): ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int s = 0; s < i; s++) Console.Write(" ");
            for (int j = 0; j < n - i; j++) Console.Write("* ");
            Console.WriteLine();
        }
        for (int i = n - 2; i >= 0; i--)
        {
            for (int s = 0; s < i; s++) Console.Write(" ");
            for (int j = 0; j < n - i; j++) Console.Write("* ");
            Console.WriteLine();
        }
    }
}
