// Program 72: Currency Converter USD to INR
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        const double RATE = 83.5;
        Console.Write("Enter amount in USD: ");
        double usd = double.Parse(Console.ReadLine());
        Console.WriteLine("$" + usd + " = Rs." + (usd * RATE).ToString("F2"));
    }
}
