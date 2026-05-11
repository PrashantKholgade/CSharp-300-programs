// Program 66: Compound Interest Calculator
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Principal: ");
        double p = double.Parse(Console.ReadLine());
        Console.Write("Rate (%): ");
        double r = double.Parse(Console.ReadLine());
        Console.Write("Time (years): ");
        double t = double.Parse(Console.ReadLine());
        double amount = p * Math.Pow(1 + r / 100, t);
        Console.WriteLine("Amount = " + amount.ToString("F2"));
        Console.WriteLine("Compound Interest = " + (amount - p).ToString("F2"));
    }
}
