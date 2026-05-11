// Program 180: Sort Array Using Array.Sort and Search with Array.BinarySearch
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] arr = {50,30,10,40,20};
        Array.Sort(arr);
        Console.Write("Sorted: ");
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
        int key = 30;
        int idx = Array.BinarySearch(arr, key);
        Console.WriteLine(key + " found at index: " + idx);
    }
}
