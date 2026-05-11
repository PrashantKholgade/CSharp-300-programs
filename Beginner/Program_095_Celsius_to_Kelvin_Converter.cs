// Program 95: Celsius to Kelvin Converter
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double c = double.Parse(Console.ReadLine());
        double k = c + 273.15;
        Console.WriteLine(c + "°C = " + k + " K");
    }
}
