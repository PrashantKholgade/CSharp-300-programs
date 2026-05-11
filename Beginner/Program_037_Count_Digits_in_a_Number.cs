// Program 37: Count Digits in a Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        int num = int.Parse(Console.ReadLine());
        if (num == 0) { Console.WriteLine("Digits: 1"); return; }
        num = Math.Abs(num);
        int count = 0;
        while (num != 0) { count++; num /= 10; }
        Console.WriteLine("Number of digits: " + count);
    }
}
