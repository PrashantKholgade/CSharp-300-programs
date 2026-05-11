// Program 25: Season by Month Number
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter month number (1-12): ");
        int m = int.Parse(Console.ReadLine());
        switch (m)
        {
            case 12: case 1: case 2: Console.WriteLine("Winter"); break;
            case 3:  case 4: case 5: Console.WriteLine("Spring"); break;
            case 6:  case 7: case 8: Console.WriteLine("Summer"); break;
            case 9:  case 10:case11: Console.WriteLine("Autumn"); break;
            default: Console.WriteLine("Invalid month.");         break;
        }
    }
}
