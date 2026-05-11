// Program 222: Dictionary Word Count
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    Console.Write("Enter sentence: ");string sentence=Console.ReadLine().ToLower();
    string[]words=sentence.Split(' ');
    Dictionary<string,int>freq=new Dictionary<string,int>();
    foreach(string w in words){if(!freq.ContainsKey(w))freq[w]=0;freq[w]++;}
    foreach(var kv in freq)Console.WriteLine(kv.Key+": "+kv.Value);
}}
