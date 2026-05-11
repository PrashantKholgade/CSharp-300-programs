// Program 4: Area of a Rectangle
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter length: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter width: ");
        double width  = double.Parse(Console.ReadLine());
        Console.WriteLine("Area = " + (length * width));
    }
}
