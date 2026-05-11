// Program 134: Recursive Power
// Category: Intermediate

using System;
class Program {
    static double Pow(double b, int e) => e == 0 ? 1 : b * Pow(b, e-1);
    static void Main() {
        Console.Write("Base: ");     double b = double.Parse(Console.ReadLine());
        Console.Write("Exponent: "); int e    = int.Parse(Console.ReadLine());
        Console.WriteLine(b + "^" + e + " = " + Pow(b, e));
    }
}
