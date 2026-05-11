// Program 91: Check Valid Triangle
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Side a: "); double a = double.Parse(Console.ReadLine());
        Console.Write("Side b: "); double b = double.Parse(Console.ReadLine());
        Console.Write("Side c: "); double c = double.Parse(Console.ReadLine());
        if (a+b>c && b+c>a && a+c>b)
            Console.WriteLine("Valid triangle.");
        else
            Console.WriteLine("Not a valid triangle.");
    }
}
