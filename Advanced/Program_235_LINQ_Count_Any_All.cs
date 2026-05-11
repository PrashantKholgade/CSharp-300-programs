// Program 235: LINQ Count Any All
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<int>nums=new List<int>{2,4,6,8,10,3};
    Console.WriteLine("Count evens: "+nums.Count(x=>x%2==0));
    Console.WriteLine("Any odd:     "+nums.Any(x=>x%2!=0));
    Console.WriteLine("All even:    "+nums.All(x=>x%2==0));
}}
