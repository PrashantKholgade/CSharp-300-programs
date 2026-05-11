// Program 26: Vowel or Consonant Check
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a character: ");
        char ch = char.ToLower(char.Parse(Console.ReadLine()));
        switch (ch)
        {
            case 'a': case 'e': case 'i': case 'o': case 'u':
                Console.WriteLine(ch + " is a Vowel.");
                break;
            default:
                if (char.IsLetter(ch)) Console.WriteLine(ch + " is a Consonant.");
                else Console.WriteLine("Not an alphabet.");
                break;
        }
    }
}
