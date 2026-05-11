// Program 167: Count Words in File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "output.txt";
        if (!File.Exists(path)) { Console.WriteLine("File not found."); return; }
        string content = File.ReadAllText(path);
        int words = content.Trim().Length == 0 ? 0 :
            content.Split(new char[]{' ','
','','	'}, StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine("Word count: " + words);
    }
}
