// Program 166: Write Array to File
// Category: Intermediate

using System;
using System.IO;
class Program {
    static void Main() {
        string[] fruits = {"Apple","Banana","Cherry","Date","Elderberry"};
        File.WriteAllLines("fruits.txt", fruits);
        Console.WriteLine("Written " + fruits.Length + " lines to fruits.txt");
    }
}
