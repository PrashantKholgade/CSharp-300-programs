// Program 226: HashSet Usage
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    HashSet<int>set=new HashSet<int>{1,2,3,4,5};
    set.Add(3);set.Add(6);
    Console.Write("Set: ");foreach(int x in set)Console.Write(x+" ");Console.WriteLine();
    Console.WriteLine("Contains 4: "+set.Contains(4));
    set.Remove(2);Console.WriteLine("After remove 2, count: "+set.Count);
}}
