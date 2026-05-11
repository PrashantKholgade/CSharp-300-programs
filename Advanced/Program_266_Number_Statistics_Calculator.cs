// Program 266: Number Statistics Calculator
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    var nums=new List<double>();Console.WriteLine("Enter numbers (blank to stop):");
    while(true){string line=Console.ReadLine();if(string.IsNullOrEmpty(line))break;if(double.TryParse(line,out double x))nums.Add(x);}
    if(nums.Count==0){Console.WriteLine("No data.");return;}
    nums.Sort();double med=nums.Count%2==0?(nums[nums.Count/2-1]+nums[nums.Count/2])/2:nums[nums.Count/2];
    Console.WriteLine($"Count:{nums.Count} Sum:{nums.Sum():F2} Avg:{nums.Average():F2} Min:{nums.Min()} Max:{nums.Max()} Median:{med:F2}");
}}
