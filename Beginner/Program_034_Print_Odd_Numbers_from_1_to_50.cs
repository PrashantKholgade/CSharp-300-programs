// Program 34: Print Odd Numbers from 1 to 50
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Odd numbers 1-50: ");
        for (int i = 1; i <= 50; i += 2)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
