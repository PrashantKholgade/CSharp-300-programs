// Program 28: Simple ATM Menu
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        double balance = 10000;
        Console.WriteLine("1. Check Balance  2. Deposit  3. Withdraw");
        Console.Write("Choose option: ");
        int opt = int.Parse(Console.ReadLine());
        switch (opt)
        {
            case 1:
                Console.WriteLine("Balance = Rs. " + balance);
                break;
            case 2:
                Console.Write("Enter deposit amount: ");
                double dep = double.Parse(Console.ReadLine());
                balance += dep;
                Console.WriteLine("New Balance = Rs. " + balance);
                break;
            case 3:
                Console.Write("Enter withdrawal amount: ");
                double wd = double.Parse(Console.ReadLine());
                if (wd > balance) Console.WriteLine("Insufficient funds.");
                else { balance -= wd; Console.WriteLine("New Balance = Rs. " + balance); }
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}
