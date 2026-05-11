// Program 104: Find Minimum in Array
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Size: "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) { Console.Write("arr[" + i + "]: "); arr[i] = int.Parse(Console.ReadLine()); }
        int min = arr[0];
        for (int i = 1; i < n; i++) if (arr[i] < min) min = arr[i];
        Console.WriteLine("Minimum = " + min);
    }
}
