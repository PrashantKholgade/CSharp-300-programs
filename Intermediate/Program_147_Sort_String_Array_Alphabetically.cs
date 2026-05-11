// Program 147: Sort String Array Alphabetically
// Category: Intermediate

using System;
class Program {
    static void Main() {
        string[] names = {"Charlie","Alice","Bob","Diana","Eve"};
        Array.Sort(names);
        Console.WriteLine("Sorted: " + string.Join(", ", names));
    }
}
