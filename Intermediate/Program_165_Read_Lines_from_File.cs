// Program 165: Read Lines from File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "output.txt";
        if (!File.Exists(path)) { Console.WriteLine("File not found."); return; }
        string[] lines = File.ReadAllLines(path);
        for (int i = 0; i < lines.Length; i++)
            Console.WriteLine((i+1) + ": " + lines[i]);
    }
}
