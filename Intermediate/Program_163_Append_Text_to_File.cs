// Program 163: Append Text to File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "log.txt";
        Console.Write("Enter line to append: "); string line = Console.ReadLine();
        File.AppendAllText(path, line + Environment.NewLine);
        Console.WriteLine("Appended to " + path);
    }
}
