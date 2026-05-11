// Program 82: Count Consonants in a Sentence
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string s = Console.ReadLine().ToLower();
        int count = 0;
        foreach (char c in s)
            if (char.IsLetter(c) && "aeiou".IndexOf(c) < 0) count++;
        Console.WriteLine("Consonant count = " + count);
    }
}
