// Program 130: out Parameter - Multiple Return Values
// Category: Intermediate

using System;
class Program {
    static void MinMax(int[] arr, out int min, out int max) {
        min = max = arr[0];
        foreach (int x in arr) { if (x < min) min = x; if (x > max) max = x; }
    }
    static void Main() {
        int[] arr = {3,1,9,4,6,2,8};
        MinMax(arr, out int mn, out int mx);
        Console.WriteLine("Min = " + mn + ", Max = " + mx);
    }
}
