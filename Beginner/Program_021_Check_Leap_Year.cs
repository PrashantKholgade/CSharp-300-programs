// Program 21: Check Leap Year
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool leap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        Console.WriteLine(year + (leap ? " is a Leap Year." : " is NOT a Leap Year."));
    }
}
