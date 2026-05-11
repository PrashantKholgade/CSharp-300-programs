// Program 41: While Loop Countdown
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter start: ");
        int n = int.Parse(Console.ReadLine());
        while (n >= 0) { Console.Write(n + " "); n--; }
        Console.WriteLine("
Blast off!");
    }
}
