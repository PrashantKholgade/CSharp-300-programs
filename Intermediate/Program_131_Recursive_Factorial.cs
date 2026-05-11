// Program 131: Recursive Factorial
// Category: Intermediate

using System;
class Program {
    static long Factorial(int n) => n <= 1 ? 1 : n * Factorial(n - 1);
    static void Main() {
        Console.Write("Enter n: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n + "! = " + Factorial(n));
    }
}
