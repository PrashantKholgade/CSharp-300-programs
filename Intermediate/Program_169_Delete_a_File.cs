// Program 169: Delete a File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "copy.txt";
        if (File.Exists(path)) { File.Delete(path); Console.WriteLine("Deleted " + path); }
        else Console.WriteLine("File not found.");
    }
}
