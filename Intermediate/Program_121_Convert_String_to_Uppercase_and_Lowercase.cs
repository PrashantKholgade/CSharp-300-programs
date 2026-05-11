// Program 121: Convert String to Uppercase and Lowercase
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine();
        Console.WriteLine("Uppercase: " + s.ToUpper());
        Console.WriteLine("Lowercase: " + s.ToLower());
    }
}
