// Program 20: Check Armstrong Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a 3-digit integer: ");
        int num = int.Parse(Console.ReadLine());
        int orig = num, sum = 0;
        while (num != 0) { int d = num % 10; sum += d * d * d; num /= 10; }
        Console.WriteLine(orig == sum ? orig + " is Armstrong." : orig + " is NOT Armstrong.");
    }
}
