// Program 64: Repeating Number Pattern
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
            for (int j = 1; j <= i; j++) Console.Write(i + " ");
            Console.WriteLine();
        }
    }
}
