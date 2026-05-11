// Program 53: Square Star Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter size: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++) Console.Write("* ");
            Console.WriteLine();
        }
    }
}
