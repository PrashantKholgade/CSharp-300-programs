// Program 14: Sum of Natural Numbers
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine("Sum of 1 to " + n + " = " + sum);
    }
}
