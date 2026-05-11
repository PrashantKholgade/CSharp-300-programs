// Program 12: Check Positive Negative or Zero
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double n = double.Parse(Console.ReadLine());
        if      (n > 0) Console.WriteLine("Positive");
        else if (n < 0) Console.WriteLine("Negative");
        else            Console.WriteLine("Zero");
    }
}
