// Program 238: LINQ ToList ToArray ToDictionary
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    IEnumerable<int>query=Enumerable.Range(1,5).Select(x=>x*x);
    List<int>list=query.ToList();
    int[]arr=query.ToArray();
    Dictionary<int,int>dict=query.ToDictionary(x=>x,x=>(int)Math.Sqrt(x));
    Console.Write("List: ");list.ForEach(x=>Console.Write(x+" "));Console.WriteLine();
    foreach(var kv in dict)Console.Write(kv.Value+"^2="+kv.Key+" ");Console.WriteLine();
}}
