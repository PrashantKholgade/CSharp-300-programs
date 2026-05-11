// Program 18: Reverse a Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        int orig = num, rev = 0;
        while (num != 0) { rev = rev * 10 + num % 10; num /= 10; }
        Console.WriteLine("Reversed: " + rev);
    }
}
