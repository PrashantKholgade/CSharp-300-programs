// Program 111: Bubble Sort
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] arr = {64, 34, 25, 12, 22, 11, 90};
        int n = arr.Length;
        for (int i = 0; i < n-1; i++)
            for (int j = 0; j < n-i-1; j++)
                if (arr[j] > arr[j+1]) { int t = arr[j]; arr[j] = arr[j+1]; arr[j+1] = t; }
        Console.Write("Sorted: ");
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }
}
