// Program 84: Power Without Math.Pow
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Base: ");    long b = long.Parse(Console.ReadLine());
        Console.Write("Exponent: ");int  e = int.Parse(Console.ReadLine());
        long result = 1;
        for (int i = 0; i < e; i++) result *= b;
        Console.WriteLine(b + "^" + e + " = " + result);
    }
}
