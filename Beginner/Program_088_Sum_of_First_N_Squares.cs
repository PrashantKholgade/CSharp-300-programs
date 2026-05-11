// Program 88: Sum of First N Squares
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        long sum = 0;
        for (int i = 1; i <= n; i++) sum += (long)i * i;
        Console.WriteLine("Sum of squares 1 to " + n + " = " + sum);
    }
}
