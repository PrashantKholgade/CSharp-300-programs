// Program 107: Count Occurrences in Array
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Size: "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) { Console.Write("arr[" + i + "]: "); arr[i] = int.Parse(Console.ReadLine()); }
        Console.Write("Key to count: "); int key = int.Parse(Console.ReadLine());
        int count = 0;
        foreach (int x in arr) if (x == key) count++;
        Console.WriteLine(key + " appears " + count + " times.");
    }
}
