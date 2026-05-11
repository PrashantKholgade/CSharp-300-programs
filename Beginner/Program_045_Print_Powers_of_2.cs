// Program 45: Print Powers of 2
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter N (number of terms): ");
        int n = int.Parse(Console.ReadLine());
        long power = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("2^" + i + " = " + power);
            power *= 2;
        }
    }
}
