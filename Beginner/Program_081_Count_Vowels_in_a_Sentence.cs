// Program 81: Count Vowels in a Sentence
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine().ToLower();
        int count = 0;
        foreach (char c in sentence)
            if ("aeiou".IndexOf(c) >= 0) count++;
        Console.WriteLine("Vowel count = " + count);
    }
}
