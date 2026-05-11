// Program 220: List Basic Operations
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    List<string>names=new List<string>{"Alice","Bob","Charlie"};
    names.Add("Diana"); names.Remove("Bob");
    Console.WriteLine("Count: "+names.Count);
    foreach(var n in names)Console.WriteLine(n);
    Console.WriteLine("Contains Alice: "+names.Contains("Alice"));
}}
