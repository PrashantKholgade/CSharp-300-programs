// Program 40: Print All Armstrong Numbers from 1 to 500
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Armstrong numbers between 1 and 500: ");
        for (int n = 1; n <= 500; n++)
        {
            int temp = n, sum = 0;
            while (temp != 0) { int d = temp % 10; sum += d * d * d; temp /= 10; }
            if (sum == n) Console.Write(n + " ");
        }
        Console.WriteLine();
    }
}
