// Program 7: Check Even or Odd
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n % 2 == 0 ? n + " is Even." : n + " is Odd.");
    }
}
