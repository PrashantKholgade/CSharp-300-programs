// Program 46: Collatz Conjecture
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        long n = long.Parse(Console.ReadLine());
        int steps = 0;
        Console.Write(n + " ");
        while (n != 1)
        {
            n = (n % 2 == 0) ? n / 2 : 3 * n + 1;
            Console.Write(n + " ");
            steps++;
        }
        Console.WriteLine("
Steps: " + steps);
    }
}
