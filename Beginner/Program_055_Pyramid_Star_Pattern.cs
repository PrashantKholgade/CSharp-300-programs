// Program 55: Pyramid Star Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int sp = 1; sp <= n - i; sp++) Console.Write(" ");
            for (int st = 1; st <= 2 * i - 1; st++) Console.Write("*");
            Console.WriteLine();
        }
    }
}
