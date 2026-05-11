// Program 10: Temperature Converter Celsius to Fahrenheit
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double c = double.Parse(Console.ReadLine());
        double f = (c * 9.0 / 5.0) + 32;
        Console.WriteLine(c + "°C = " + f + "°F");
    }
}
