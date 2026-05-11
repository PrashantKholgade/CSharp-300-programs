// Program 102: Sum and Average of Array
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Size: "); int n = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) { Console.Write("arr[" + i + "]: "); arr[i] = int.Parse(Console.ReadLine()); }
        int sum = 0;
        foreach (int x in arr) sum += x;
        Console.WriteLine("Sum=" + sum + "  Average=" + ((double)sum/n).ToString("F2"));
    }
}
