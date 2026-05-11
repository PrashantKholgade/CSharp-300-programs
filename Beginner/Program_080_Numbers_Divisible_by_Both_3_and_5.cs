// Program 80: Numbers Divisible by Both 3 and 5
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter range end N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Numbers divisible by 3 and 5: ");
        for (int i = 1; i <= n; i++)
            if (i % 3 == 0 && i % 5 == 0) Console.Write(i + " ");
        Console.WriteLine();
    }
}
