// Program 114: Array Frequency Counter
// Category: Intermediate

using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        int[] arr = {3,1,4,1,5,9,2,6,5,3,5};
        Dictionary<int,int> freq = new Dictionary<int,int>();
        foreach (int x in arr) { if (!freq.ContainsKey(x)) freq[x] = 0; freq[x]++; }
        foreach (var kv in freq) Console.WriteLine(kv.Key + " -> " + kv.Value + " times");
    }
}
