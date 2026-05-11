// Program 87: Simple Tax Calculator
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter annual income: ");
        double income = double.Parse(Console.ReadLine());
        double tax;
        if      (income <= 250000)  tax = 0;
        else if (income <= 500000)  tax = (income - 250000) * 0.05;
        else if (income <= 1000000) tax = 12500 + (income - 500000) * 0.20;
        else                        tax = 112500 + (income - 1000000) * 0.30;
        Console.WriteLine("Tax payable = Rs." + tax.ToString("F2"));
    }
}
