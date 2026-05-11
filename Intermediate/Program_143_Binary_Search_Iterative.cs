// Program 143: Binary Search Iterative
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] arr = {2,5,8,12,16,23,38,56,72,91};
        Console.Write("Key: "); int key = int.Parse(Console.ReadLine());
        int l=0, r=arr.Length-1, res=-1;
        while (l <= r) {
            int mid = (l+r)/2;
            if (arr[mid] == key) { res = mid; break; }
            else if (arr[mid] < key) l = mid+1;
            else r = mid-1;
        }
        Console.WriteLine(res >= 0 ? "Found at index " + res : "Not found.");
    }
}
