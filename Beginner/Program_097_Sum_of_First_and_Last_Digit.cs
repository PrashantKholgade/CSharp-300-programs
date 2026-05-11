// Program 97: Sum of First and Last Digit
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());
        int last  = num % 10;
        int first = num;
        while (first >= 10) first /= 10;
        Console.WriteLine("First digit: " + first + ", Last digit: " + last);
        Console.WriteLine("Sum = " + (first + last));
    }
}
