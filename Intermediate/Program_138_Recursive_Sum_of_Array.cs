// Program 138: Recursive Sum of Array
// Category: Intermediate

using System;
class Program {
    static int Sum(int[] a, int n) => n == 0 ? 0 : a[n-1] + Sum(a, n-1);
    static void Main() {
        int[] arr = {1,2,3,4,5,6,7,8,9,10};
        Console.WriteLine("Sum = " + Sum(arr, arr.Length));
    }
}
