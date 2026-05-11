// Program 43: GCD of Two Numbers
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
        while (b != 0) { int t = b; b = a % b; a = t; }
        Console.WriteLine("GCD = " + a);
    }
}
