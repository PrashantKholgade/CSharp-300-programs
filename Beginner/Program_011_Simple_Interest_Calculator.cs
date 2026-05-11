// Program 11: Simple Interest Calculator
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
        Console.WriteLine("Simple Interest = " + (p * r * t / 100));
    }
}
