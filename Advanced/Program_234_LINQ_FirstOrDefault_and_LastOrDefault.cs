// Program 234: LINQ FirstOrDefault and LastOrDefault
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<int>nums=new List<int>{10,20,30,40,50};
    Console.WriteLine("First>25: "+nums.FirstOrDefault(x=>x>25));
    Console.WriteLine("Last<40:  "+nums.LastOrDefault(x=>x<40));
    Console.WriteLine("First>100 (default): "+nums.FirstOrDefault(x=>x>100));
}}
