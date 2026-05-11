// Program 117: Reverse a String
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine();
        char[] arr = s.ToCharArray(); Array.Reverse(arr);
        Console.WriteLine("Reversed: " + new string(arr));
    }
}
