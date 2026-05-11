// Program 123: Replace Character in String
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("String: ");      string s = Console.ReadLine();
        Console.Write("Replace char: "); char o = char.Parse(Console.ReadLine());
        Console.Write("With char: ");    char n = char.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + s.Replace(o, n));
    }
}
