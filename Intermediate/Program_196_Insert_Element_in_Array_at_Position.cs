// Program 196: Insert Element in Array at Position
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] arr = {1,2,3,4,5}; int n = arr.Length;
        Console.Write("Position to insert (0-based): "); int pos = int.Parse(Console.ReadLine());
        Console.Write("Value: "); int val = int.Parse(Console.ReadLine());
        int[] newArr = new int[n+1];
        for (int i=0;i<pos;i++) newArr[i]=arr[i];
        newArr[pos]=val;
        for (int i=pos;i<n;i++) newArr[i+1]=arr[i];
        Console.Write("New Array: ");
        foreach (int x in newArr) Console.Write(x+" ");
        Console.WriteLine();
    }
}
