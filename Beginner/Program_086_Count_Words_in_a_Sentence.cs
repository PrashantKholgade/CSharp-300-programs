// Program 86: Count Words in a Sentence
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine().Trim();
        if (sentence.Length == 0) { Console.WriteLine("0 words."); return; }
        int words = 1;
        for (int i = 0; i < sentence.Length - 1; i++)
            if (sentence[i] == ' ' && sentence[i+1] != ' ') words++;
        Console.WriteLine("Word count = " + words);
    }
}
