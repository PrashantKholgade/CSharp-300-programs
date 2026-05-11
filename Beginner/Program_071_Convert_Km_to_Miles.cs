// Program 71: Convert Km to Miles
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter distance in km: ");
        double km = double.Parse(Console.ReadLine());
        Console.WriteLine(km + " km = " + (km * 0.621371).ToString("F4") + " miles");
    }
}
