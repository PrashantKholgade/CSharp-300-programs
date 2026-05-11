// Program 9: Largest of Three Numbers
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
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        int largest = (a >= b && a >= c) ? a : (b >= c ? b : c);
        Console.WriteLine("Largest = " + largest);
    }
}
