// Program 106: Linear Search in Array
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] arr = { 10, 25, 3, 47, 8, 99, 56 };
        Console.Write("Enter search key: ");
        int key = int.Parse(Console.ReadLine());
        int found = -1;
        for (int i = 0; i < arr.Length; i++) if (arr[i] == key) { found = i; break; }
        Console.WriteLine(found >= 0 ? "Found at index " + found : "Not found.");
    }
}
