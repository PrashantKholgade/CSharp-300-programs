// Program 120: Count Words in a String
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter sentence: "); string s = Console.ReadLine().Trim();
        string[] words = s.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Word count = " + words.Length);
    }
}
