// Program 227: SortedDictionary Example
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    SortedDictionary<string,int>scores=new SortedDictionary<string,int>{{"Charlie",85},{"Alice",95},{"Bob",78}};
    foreach(var kv in scores)Console.WriteLine(kv.Key+": "+kv.Value);
}}
