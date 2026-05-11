// Program 23: Month Name from Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter month number (1-12): ");
        int m = int.Parse(Console.ReadLine());
        string[] months = { "January","February","March","April","May","June",
                            "July","August","September","October","November","December" };
        if (m >= 1 && m <= 12)
            Console.WriteLine("Month: " + months[m - 1]);
        else
            Console.WriteLine("Invalid month number.");
    }
}
