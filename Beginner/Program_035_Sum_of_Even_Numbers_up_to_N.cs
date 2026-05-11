// Program 35: Sum of Even Numbers up to N
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 2; i <= n; i += 2) sum += i;
        Console.WriteLine("Sum of even numbers 1 to " + n + " = " + sum);
    }
}
