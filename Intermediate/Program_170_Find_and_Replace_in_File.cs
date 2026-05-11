// Program 170: Find and Replace in File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "output.txt";
        if (!File.Exists(path)) { Console.WriteLine("File not found."); return; }
        Console.Write("Replace: ");   string old = Console.ReadLine();
        Console.Write("With:    ");   string nw  = Console.ReadLine();
        string content = File.ReadAllText(path).Replace(old, nw);
        File.WriteAllText(path, content);
        Console.WriteLine("Done.");
    }
}
