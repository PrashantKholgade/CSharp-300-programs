// Program 68: Convert Seconds to Hours Minutes Seconds
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter total seconds: ");
        int total = int.Parse(Console.ReadLine());
        int hours   = total / 3600;
        int minutes = (total % 3600) / 60;
        int seconds = total % 60;
        Console.WriteLine(hours + "h " + minutes + "m " + seconds + "s");
    }
}
