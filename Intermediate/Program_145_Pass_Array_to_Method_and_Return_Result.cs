// Program 145: Pass Array to Method and Return Result
// Category: Intermediate

using System;
class Program {
    static double Average(int[] arr) { int s=0; foreach(int x in arr) s+=x; return (double)s/arr.Length; }
    static void Main() {
        int[] arr = {10,20,30,40,50};
        Console.WriteLine("Average = " + Average(arr).ToString("F2"));
    }
}
