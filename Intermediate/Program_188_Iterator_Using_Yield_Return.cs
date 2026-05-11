// Program 188: Iterator Using Yield Return
// Category: Intermediate

using System;
using System.Collections.Generic;
class Program {
    static IEnumerable<int> EvenNumbers(int max) {
        for (int i=2; i<=max; i+=2) yield return i;
    }
    static void Main() {
        Console.Write("Even numbers up to 20: ");
        foreach (int n in EvenNumbers(20)) Console.Write(n + " ");
        Console.WriteLine();
    }
}
