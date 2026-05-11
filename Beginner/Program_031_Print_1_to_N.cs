// Program 31: Print 1 to N
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.Write(i + " ");
        Console.WriteLine();
    }
}
