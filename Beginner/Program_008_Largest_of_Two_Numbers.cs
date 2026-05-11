// Program 8: Largest of Two Numbers
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());
        if (a > b)       Console.WriteLine("Largest = " + a);
        else if (b > a)  Console.WriteLine("Largest = " + b);
        else             Console.WriteLine("Both are equal.");
    }
}
