// Program 133: Recursive Sum of Digits
// Category: Intermediate

using System;
class Program {
    static int SumDigits(int n) => n == 0 ? 0 : n % 10 + SumDigits(n / 10);
    static void Main() {
        Console.Write("Enter number: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum of digits = " + SumDigits(Math.Abs(n)));
    }
}
