// Program 113: Remove Duplicates from Array
// Category: Intermediate

using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        int[] arr = {1,2,2,3,4,4,5,1};
        List<int> unique = new List<int>();
        foreach (int x in arr) if (!unique.Contains(x)) unique.Add(x);
        Console.Write("Without duplicates: ");
        foreach (int x in unique) Console.Write(x + " ");
        Console.WriteLine();
    }
}
