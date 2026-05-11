// Program 78: Check Divisibility by 5 and 11
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
        bool by5 = n % 5 == 0, by11 = n % 11 == 0;
        if (by5 && by11) Console.WriteLine("Divisible by both 5 and 11.");
        else if (by5)    Console.WriteLine("Divisible by 5 only.");
        else if (by11)   Console.WriteLine("Divisible by 11 only.");
        else             Console.WriteLine("Not divisible by 5 or 11.");
    }
}
