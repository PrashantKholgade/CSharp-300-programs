// Program 136: Recursive GCD
// Category: Intermediate

using System;
class Program {
    static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
    static void Main() {
        Console.Write("a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("b: "); int b = int.Parse(Console.ReadLine());
        Console.WriteLine("GCD = " + GCD(a, b));
    }
}
