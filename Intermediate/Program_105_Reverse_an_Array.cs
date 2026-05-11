// Program 105: Reverse an Array
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Size: "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) { Console.Write("arr[" + i + "]: "); arr[i] = int.Parse(Console.ReadLine()); }
        Array.Reverse(arr);
        Console.Write("Reversed: ");
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }
}
