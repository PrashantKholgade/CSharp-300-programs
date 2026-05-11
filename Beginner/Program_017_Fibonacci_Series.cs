// Program 17: Fibonacci Series
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int n = int.Parse(Console.ReadLine());
        int a = 0, b = 1;
        Console.Write("Fibonacci: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int next = a + b; a = b; b = next;
        }
        Console.WriteLine();
    }
}
