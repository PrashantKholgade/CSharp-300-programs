// Program 58: Pascal's Triangle
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int val = 1;
            for (int sp = 0; sp < n - i - 1; sp++) Console.Write(" ");
            for (int j = 0; j <= i; j++)
            {
                Console.Write(val + " ");
                val = val * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
}
