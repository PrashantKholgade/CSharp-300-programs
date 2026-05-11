// Program 15: Factorial of a Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a non-negative integer: ");
        int n = int.Parse(Console.ReadLine());
        long fact = 1;
        for (int i = 1; i <= n; i++) fact *= i;
        Console.WriteLine(n + "! = " + fact);
    }
}
