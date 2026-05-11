// Program 5: Swap Two Variables
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
        int temp = a; a = b; b = temp;
        Console.WriteLine("After swap: a = " + a + ", b = " + b);
    }
}
