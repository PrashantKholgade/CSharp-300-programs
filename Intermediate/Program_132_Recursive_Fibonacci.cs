// Program 132: Recursive Fibonacci
// Category: Intermediate

using System;
class Program {
    static int Fib(int n) => n <= 1 ? n : Fib(n-1) + Fib(n-2);
    static void Main() {
        Console.Write("Terms: "); int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) Console.Write(Fib(i) + " ");
        Console.WriteLine();
    }
}
