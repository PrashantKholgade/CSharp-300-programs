// Program 96: Simple Running Average
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("How many numbers? ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number " + i + ": ");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("Average = " + (sum / n).ToString("F4"));
    }
}
