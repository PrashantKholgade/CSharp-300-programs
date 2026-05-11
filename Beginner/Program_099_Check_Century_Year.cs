// Program 99: Check Century Year
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());
        Console.WriteLine(year % 100 == 0 ? year + " is a Century Year." : year + " is NOT a Century Year.");
    }
}
