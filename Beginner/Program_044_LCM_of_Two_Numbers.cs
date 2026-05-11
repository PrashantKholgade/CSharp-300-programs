// Program 44: LCM of Two Numbers
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        int x = a, y = b;
        while (b != 0) { int t = b; b = a % b; a = t; }
        int gcd = a;
        Console.WriteLine("LCM = " + (x / gcd * y));
    }
}
