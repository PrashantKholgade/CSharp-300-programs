// Program 162: Read Text from File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string path = "output.txt";
        if (File.Exists(path))
            Console.WriteLine("File content:
" + File.ReadAllText(path));
        else
            Console.WriteLine("File not found: " + path);
    }
}
