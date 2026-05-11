// Program 33: Print Even Numbers from 1 to 50
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Even numbers 1-50: ");
        for (int i = 2; i <= 50; i += 2)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
