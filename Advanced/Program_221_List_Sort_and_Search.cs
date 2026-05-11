// Program 221: List Sort and Search
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    List<int>nums=new List<int>{5,3,8,1,9,2,7};
    nums.Sort();
    Console.Write("Sorted: ");nums.ForEach(x=>Console.Write(x+" "));Console.WriteLine();
    int idx=nums.BinarySearch(7);
    Console.WriteLine("7 found at index: "+idx);
    nums.Reverse();
    Console.Write("Reversed: ");nums.ForEach(x=>Console.Write(x+" "));Console.WriteLine();
}}
