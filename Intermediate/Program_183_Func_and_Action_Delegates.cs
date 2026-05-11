// Program 183: Func and Action Delegates
// Category: Intermediate

using System;
class Program {
    static void Apply(int[] arr, Action<int> action) { foreach (int x in arr) action(x); }
    static int[] Transform(int[] arr, Func<int,int> func) {
        int[] res = new int[arr.Length];
        for (int i=0;i<arr.Length;i++) res[i]=func(arr[i]);
        return res;
    }
    static void Main() {
        int[] nums = {1,2,3,4,5};
        int[] squares = Transform(nums, x => x*x);
        Console.Write("Squares: ");
        Apply(squares, x => Console.Write(x+" "));
        Console.WriteLine();
    }
}
