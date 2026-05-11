// Program 39: Check Perfect Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < n; i++)
            if (n % i == 0) sum += i;
        Console.WriteLine(n + (sum == n ? " is a Perfect number." : " is NOT a Perfect number."));
    }
}
