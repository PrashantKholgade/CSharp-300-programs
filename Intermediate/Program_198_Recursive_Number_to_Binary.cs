// Program 198: Recursive Number to Binary
// Category: Intermediate

using System;
class Program {
    static string ToBinary(int n) => n==0 ? "0" : n==1 ? "1" : ToBinary(n/2) + (n%2).ToString();
    static void Main() {
        Console.Write("Enter decimal: "); int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n + " in binary = " + ToBinary(n));
    }
}
