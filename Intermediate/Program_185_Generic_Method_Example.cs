// Program 185: Generic Method Example
// Category: Intermediate

using System;
class Program {
    static T Max<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b) >= 0 ? a : b;
    static void Main() {
        Console.WriteLine("Max(3,7)        = " + Max(3,7));
        Console.WriteLine("Max(3.14,2.71)  = " + Max(3.14,2.71));
        Console.WriteLine("Max("apple","banana") = " + Max("apple","banana"));
    }
}
