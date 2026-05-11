// Program 70: Triangle Area Using Heron Formula
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Side a: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Side b: "); double b = double.Parse(Console.ReadLine());
        Console.Write("Side c: "); double c = double.Parse(Console.ReadLine());
        double s = (a + b + c) / 2;
        double area = Math.Sqrt(s * (s-a) * (s-b) * (s-c));
        Console.WriteLine("Area = " + area.ToString("F4"));
    }
}
