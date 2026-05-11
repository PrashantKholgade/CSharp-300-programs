// Program 126: Method to Add Two Numbers
// Category: Intermediate

using System;
class Program {
    static int Add(int a, int b) => a + b;
    static void Main() {
        Console.Write("a: "); int a = int.Parse(Console.ReadLine());
        Console.Write("b: "); int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum = " + Add(a, b));
    }
}
