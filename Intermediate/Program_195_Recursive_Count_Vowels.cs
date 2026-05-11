// Program 195: Recursive Count Vowels
// Category: Intermediate

using System;
class Program {
    static int CountVowels(string s, int i) {
        if (i == s.Length) return 0;
        int v = "aeiouAEIOU".IndexOf(s[i]) >= 0 ? 1 : 0;
        return v + CountVowels(s, i+1);
    }
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine();
        Console.WriteLine("Vowels: " + CountVowels(s, 0));
    }
}
