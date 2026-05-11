// Program 119: Count Vowels in String
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine().ToLower();
        int v = 0; foreach (char c in s) if ("aeiou".Contains(c)) v++;
        Console.WriteLine("Vowels: " + v);
    }
}
