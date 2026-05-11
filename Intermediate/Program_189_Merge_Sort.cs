// Program 189: Merge Sort
// Category: Intermediate

using System;
class Program {
    static void MergeSort(int[] arr, int l, int r) {
        if (l >= r) return;
        int m = (l+r)/2;
        MergeSort(arr, l, m); MergeSort(arr, m+1, r);
        int[] tmp = new int[r-l+1]; int i=l,j=m+1,k=0;
        while(i<=m && j<=r) tmp[k++] = arr[i]<=arr[j] ? arr[i++] : arr[j++];
        while(i<=m) tmp[k++]=arr[i++]; while(j<=r) tmp[k++]=arr[j++];
        for(int x=0;x<tmp.Length;x++) arr[l+x]=tmp[x];
    }
    static void Main() {
        int[] arr = {38,27,43,3,9,82,10};
        MergeSort(arr, 0, arr.Length-1);
        Console.Write("Sorted: ");
        foreach(int x in arr) Console.Write(x+" ");
        Console.WriteLine();
    }
}
