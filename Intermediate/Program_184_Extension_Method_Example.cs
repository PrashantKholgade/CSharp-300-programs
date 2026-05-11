// Program 184: Extension Method Example
// Category: Intermediate

using System;
static class StringExtensions {
    public static bool IsPalindrome(this string s) {
        string lower = s.ToLower();
        char[] arr = lower.ToCharArray(); Array.Reverse(arr);
        return lower == new string(arr);
    }
    public static int WordCount(this string s) =>
        s.Trim().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Length;
}
class Program {
    static void Main() {
        string word = "racecar";
        Console.WriteLine(word + " palindrome: " + word.IsPalindrome());
        string sentence = "Hello world from CSharp";
        Console.WriteLine("Word count: " + sentence.WordCount());
    }
}
