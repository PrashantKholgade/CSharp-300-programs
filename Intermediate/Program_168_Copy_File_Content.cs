// Program 168: Copy File Content
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string src = "output.txt", dst = "copy.txt";
        if (!File.Exists(src)) { Console.WriteLine("Source not found."); return; }
        File.Copy(src, dst, overwrite: true);
        Console.WriteLine("Copied " + src + " -> " + dst);
    }
}
