// Program 118: Check Palindrome String
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine().ToLower();
        char[] arr = s.ToCharArray(); Array.Reverse(arr);
        string rev = new string(arr);
        Console.WriteLine(s == rev ? """ + s + "" is a palindrome." : """ + s + "" is NOT a palindrome.");
    }
}
