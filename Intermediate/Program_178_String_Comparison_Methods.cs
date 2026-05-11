// Program 178: String Comparison Methods
// Category: Intermediate

using System;
class Program {
    static void Main() {
        string a = "hello", b = "HELLO";
        Console.WriteLine("Equals (case-sensitive):   " + a.Equals(b));
        Console.WriteLine("Equals (ignore case):      " + a.Equals(b, StringComparison.OrdinalIgnoreCase));
        Console.WriteLine("Compare:                   " + string.Compare(a, b, true));
    }
}
