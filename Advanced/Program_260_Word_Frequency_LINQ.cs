// Program 260: Word Frequency LINQ
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    Console.Write("Enter sentence: ");string sentence=Console.ReadLine().ToLower();
    var words=sentence.Split(new char[]{' ',',','.',';','!'},StringSplitOptions.RemoveEmptyEntries);
    var freq=words.GroupBy(w=>w).Select(g=>new{Word=g.Key,Count=g.Count()}).OrderByDescending(x=>x.Count);
    Console.WriteLine("Word frequencies:");
    foreach(var x in freq)Console.WriteLine($"  {x.Word,-15} : {x.Count}");
}}
