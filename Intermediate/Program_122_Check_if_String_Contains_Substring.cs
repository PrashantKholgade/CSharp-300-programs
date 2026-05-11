// Program 122: Check if String Contains Substring
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Main string: ");    string main = Console.ReadLine();
        Console.Write("Substring to find: "); string sub = Console.ReadLine();
        Console.WriteLine(main.Contains(sub) ? "Found!" : "Not found.");
    }
}
