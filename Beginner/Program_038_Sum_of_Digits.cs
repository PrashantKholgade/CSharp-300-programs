// Program 38: Sum of Digits
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = Math.Abs(int.Parse(Console.ReadLine()));
        int sum = 0;
        while (num != 0) { sum += num % 10; num /= 10; }
        Console.WriteLine("Sum of digits = " + sum);
    }
}
