// Program 101: Declare and Display an Array
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            Console.Write("Element[" + i + "]: ");
            arr[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Array: ");
        foreach (int x in arr) Console.Write(x + " ");
        Console.WriteLine();
    }
}
