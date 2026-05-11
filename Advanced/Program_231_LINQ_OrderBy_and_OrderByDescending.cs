// Program 231: LINQ OrderBy and OrderByDescending
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<int>nums=new List<int>{5,1,9,3,7,2,8};
    Console.Write("Asc:  ");foreach(int x in nums.OrderBy(n=>n))Console.Write(x+" ");Console.WriteLine();
    Console.Write("Desc: ");foreach(int x in nums.OrderByDescending(n=>n))Console.Write(x+" ");Console.WriteLine();
}}
