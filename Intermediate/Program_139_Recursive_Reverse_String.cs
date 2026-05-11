// Program 139: Recursive Reverse String
// Category: Intermediate

using System;
class Program {
    static string Rev(string s) => s.Length <= 1 ? s : Rev(s.Substring(1)) + s[0];
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine();
        Console.WriteLine("Reversed: " + Rev(s));
    }
}
