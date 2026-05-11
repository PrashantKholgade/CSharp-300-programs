// Program 161: Write Text to File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "output.txt";
        Console.Write("Enter text to write: "); string text = Console.ReadLine();
        File.WriteAllText(path, text);
        Console.WriteLine("Written to " + path);
    }
}
