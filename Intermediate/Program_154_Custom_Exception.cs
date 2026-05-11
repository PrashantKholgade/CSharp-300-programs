// Program 154: Custom Exception
// Category: Intermediate

using System;
class NegativeNumberException : Exception {
    public NegativeNumberException(string msg) : base(msg) {}
}
class Program {
    static void CheckPositive(int n) {
        if (n < 0) throw new NegativeNumberException("Negative numbers not allowed: " + n);
    }
    static void Main() {
        try {
            Console.Write("Enter a number: "); int n = int.Parse(Console.ReadLine());
            CheckPositive(n);
            Console.WriteLine("Valid: " + n);
        } catch (NegativeNumberException ex) {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
    }
}
