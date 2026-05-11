// Program 60: Alphabet Triangle Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter rows (max 26): ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j <= i; j++) Console.Write((char)('A' + j) + " ");
            Console.WriteLine();
        }
    }
}
