// Program 233: LINQ Aggregate Sum Max Min Average
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<int>nums=new List<int>{3,1,4,1,5,9,2,6,5,3};
    Console.WriteLine("Sum="+nums.Sum()+" Max="+nums.Max()+" Min="+nums.Min()+" Avg="+nums.Average().ToString("F2"));
    int product=nums.Aggregate(1,(acc,x)=>acc*x);
    Console.WriteLine("Product="+product);
}}
