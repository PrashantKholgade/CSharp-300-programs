// Program 79: Print All Prime Numbers up to N
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Primes up to " + n + ": ");
        for (int num = 2; num <= n; num++)
        {
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
                if (num % i == 0) { prime = false; break; }
            if (prime) Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
