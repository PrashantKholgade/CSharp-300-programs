// Program 124: String Split and Join
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter comma-separated values: ");
        string input = Console.ReadLine();
        string[] parts = input.Split(',');
        Console.WriteLine("Parts: " + parts.Length);
        foreach (string p in parts) Console.WriteLine("  " + p.Trim());
        Console.WriteLine("Joined with |: " + string.Join(" | ", parts));
    }
}
