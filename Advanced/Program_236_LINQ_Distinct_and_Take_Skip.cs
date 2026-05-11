// Program 236: LINQ Distinct and Take Skip
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<int>nums=new List<int>{1,2,2,3,3,3,4,5};
    Console.Write("Distinct: ");foreach(int x in nums.Distinct())Console.Write(x+" ");Console.WriteLine();
    Console.Write("Take 3:   ");foreach(int x in nums.Take(3))Console.Write(x+" ");Console.WriteLine();
    Console.Write("Skip 5:   ");foreach(int x in nums.Skip(5))Console.Write(x+" ");Console.WriteLine();
}}
