// Program 232: LINQ GroupBy
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<string>words=new List<string>{"cat","car","bat","ball","can","bar"};
    var groups=words.GroupBy(w=>w[0]);
    foreach(var g in groups){Console.Write(g.Key+": ");foreach(var w in g)Console.Write(w+" ");Console.WriteLine();}
}}
