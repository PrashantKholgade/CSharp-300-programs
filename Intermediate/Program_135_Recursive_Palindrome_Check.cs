// Program 135: Recursive Palindrome Check
// Category: Intermediate

using System;
class Program {
    static bool IsPalin(string s, int l, int r) =>
        l >= r || (s[l] == s[r] && IsPalin(s, l+1, r-1));
    static void Main() {
        Console.Write("String: "); string s = Console.ReadLine().ToLower();
        Console.WriteLine(IsPalin(s, 0, s.Length-1) ? "Palindrome." : "Not palindrome.");
    }
}
