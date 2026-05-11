// Program 57: Floyd's Triangle
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter rows: ");
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++) Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }
}
