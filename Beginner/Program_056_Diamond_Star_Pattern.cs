// Program 56: Diamond Star Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter rows (odd): ");
        int n = int.Parse(Console.ReadLine());
        // Upper half
        for (int i = 1; i <= n; i += 2)
        {
            for (int s = 0; s < (n - i) / 2; s++) Console.Write(" ");
            for (int j = 0; j < i; j++) Console.Write("*");
            Console.WriteLine();
        }
        // Lower half
        for (int i = n - 2; i >= 1; i -= 2)
        {
            for (int s = 0; s < (n - i) / 2; s++) Console.Write(" ");
            for (int j = 0; j < i; j++) Console.Write("*");
            Console.WriteLine();
        }
    }
}
