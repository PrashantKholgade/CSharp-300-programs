// Program 16: Check Prime Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        bool prime = n >= 2;
        for (int i = 2; i <= Math.Sqrt(n) && prime; i++)
            if (n % i == 0) prime = false;
        Console.WriteLine(n + (prime ? " is Prime." : " is NOT Prime."));
    }
}
