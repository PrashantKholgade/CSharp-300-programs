// Program 89: Find HCF and LCM Together
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
        while (y != 0) { int t = y; y = x % y; x = t; }
        int hcf = x;
        long lcm = (long)a / hcf * b;
        Console.WriteLine("HCF = " + hcf + ", LCM = " + lcm);
    }
}
