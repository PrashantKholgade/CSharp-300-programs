// Program 29: Days in a Month
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter month (1-12): ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int y = int.Parse(Console.ReadLine());
        int days;
        switch (m)
        {
            case 4: case 6: case 9: case 11: days = 30; break;
            case 2:
                bool leap = (y % 4 == 0 && y % 100 != 0) || y % 400 == 0;
                days = leap ? 29 : 28; break;
            default: days = 31; break;
        }
        Console.WriteLine("Days in month " + m + "/" + y + " = " + days);
    }
}
