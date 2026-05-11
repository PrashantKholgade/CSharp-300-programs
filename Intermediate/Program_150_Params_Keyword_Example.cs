// Program 150: Params Keyword Example
// Category: Intermediate

using System;
class Program {
    static int Sum(params int[] nums) { int s=0; foreach(int n in nums) s+=n; return s; }
    static void Main() {
        Console.WriteLine("Sum(1,2,3)      = " + Sum(1,2,3));
        Console.WriteLine("Sum(10,20,30,40)= " + Sum(10,20,30,40));
        Console.WriteLine("Sum(5)          = " + Sum(5));
    }
}
