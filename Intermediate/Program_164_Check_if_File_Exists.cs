// Program 164: Check if File Exists
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        Console.Write("Enter filename: "); string path = Console.ReadLine();
        Console.WriteLine(File.Exists(path) ? "File exists!" : "File does NOT exist.");
    }
}
