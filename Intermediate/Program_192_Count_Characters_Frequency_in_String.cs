// Program 192: Count Characters Frequency in String
// Category: Intermediate

using System;
using System.Collections.Generic;
class Program {
    static void Main() {
        Console.Write("Enter string: "); string s = Console.ReadLine().ToLower();
        Dictionary<char,int> freq = new Dictionary<char,int>();
        foreach (char c in s) { if (!freq.ContainsKey(c)) freq[c]=0; freq[c]++; }
        foreach (var kv in freq)
            Console.WriteLine("'" + kv.Key + "' : " + kv.Value);
    }
}
