// Program 140: Recursive Binary Search
// Category: Intermediate

using System;
class Program {
    static int BinSearch(int[] arr, int l, int r, int key) {
        if (l > r) return -1;
        int mid = (l+r)/2;
        if (arr[mid] == key) return mid;
        return arr[mid] > key ? BinSearch(arr, l, mid-1, key) : BinSearch(arr, mid+1, r, key);
    }
    static void Main() {
        int[] arr = {2,5,8,12,16,23,38,56,72,91};
        Console.Write("Search key: "); int key = int.Parse(Console.ReadLine());
        int idx = BinSearch(arr, 0, arr.Length-1, key);
        Console.WriteLine(idx >= 0 ? "Found at index " + idx : "Not found.");
    }
}
