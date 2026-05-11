// Program 92: Print First N Perfect Squares
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Perfect squares: ");
        for (int i = 1; i <= n; i++) Console.Write((i*i) + " ");
        Console.WriteLine();
    }
}
