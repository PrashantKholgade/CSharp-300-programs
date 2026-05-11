// Program 129: ref Parameter Example
// Category: Intermediate

using System;
class Program {
    static void Double(ref int x) { x *= 2; }
    static void Main() {
        int val = 5;
        Console.WriteLine("Before: " + val);
        Double(ref val);
        Console.WriteLine("After:  " + val);
    }
}
