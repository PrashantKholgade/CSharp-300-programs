// Program 49: Reduce Number to Single Digit by Summing Digits
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Math.Abs(int.Parse(Console.ReadLine()));
        while (n >= 10)
        {
            int s = 0;
            while (n != 0) { s += n % 10; n /= 10; }
            n = s;
        }
        Console.WriteLine("Single digit result: " + n);
    }
}
