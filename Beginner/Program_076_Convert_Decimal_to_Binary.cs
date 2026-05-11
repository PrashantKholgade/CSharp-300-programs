// Program 76: Convert Decimal to Binary
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter decimal number: ");
        int num = int.Parse(Console.ReadLine());
        string binary = "";
        int temp = num;
        if (temp == 0) { binary = "0"; }
        else
        {
            while (temp > 0) { binary = (temp % 2) + binary; temp /= 2; }
        }
        Console.WriteLine(num + " in binary = " + binary);
    }
}
