// Program 197: Delete Element from Array at Position
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[] arr = {10,20,30,40,50};
        Console.Write("Index to delete: "); int pos = int.Parse(Console.ReadLine());
        int[] newArr = new int[arr.Length-1];
        for (int i=0,j=0;i<arr.Length;i++) if(i!=pos) newArr[j++]=arr[i];
        Console.Write("After deletion: ");
        foreach (int x in newArr) Console.Write(x+" ");
        Console.WriteLine();
    }
}
