// Program 229: LINQ Where Filter
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<int>nums=new List<int>{1,2,3,4,5,6,7,8,9,10};
    var evens=nums.Where(x=>x%2==0);
    Console.Write("Evens: ");foreach(int x in evens)Console.Write(x+" ");Console.WriteLine();
    var gt5=nums.Where(x=>x>5);
    Console.Write("Greater than 5: ");foreach(int x in gt5)Console.Write(x+" ");Console.WriteLine();
}}
