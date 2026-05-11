// Program 112: Merge Two Arrays
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] a = {1,3,5}, b = {2,4,6};
        int[] merged = new int[a.Length + b.Length];
        a.CopyTo(merged, 0); b.CopyTo(merged, a.Length);
        Console.Write("Merged: ");
        foreach (int x in merged) Console.Write(x + " ");
        Console.WriteLine();
    }
}
