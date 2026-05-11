// Program 83: Print ASCII Values of A to Z
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Letter | ASCII");
        for (char c = 'A'; c <= 'Z'; c++)
            Console.WriteLine("  " + c + "     | " + (int)c);
    }
}
