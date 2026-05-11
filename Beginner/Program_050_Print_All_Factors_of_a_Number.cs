// Program 50: Print All Factors of a Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Factors of " + n + ": ");
        for (int i = 1; i <= n; i++)
            if (n % i == 0) Console.Write(i + " ");
        Console.WriteLine();
    }
}
