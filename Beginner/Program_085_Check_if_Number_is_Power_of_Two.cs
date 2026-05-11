// Program 85: Check if Number is Power of Two
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        bool isPow2 = n > 0 && (n & (n - 1)) == 0;
        Console.WriteLine(n + (isPow2 ? " is a power of 2." : " is NOT a power of 2."));
    }
}
