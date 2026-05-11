// Program 59: Number Triangle Pattern
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
            for (int j = 1; j <= i; j++) Console.Write(j + " ");
            Console.WriteLine();
        }
    }
}
