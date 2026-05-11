// Program 116: String Length Without Property
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter a string: "); string s = Console.ReadLine();
        int count = 0;
        foreach (char c in s) count++;
        Console.WriteLine("Length = " + count);
    }
}
