// Program 69: Circle Area and Circumference
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double r = double.Parse(Console.ReadLine());
        Console.WriteLine("Area          = " + (Math.PI * r * r).ToString("F4"));
        Console.WriteLine("Circumference = " + (2 * Math.PI * r).ToString("F4"));
    }
}
