// Program 199: Print All Permutations of a String
// Category: Intermediate

using System;
class Program {
    static void Permute(char[] arr, int start) {
        if (start == arr.Length-1) { Console.WriteLine(new string(arr)); return; }
        for (int i=start; i<arr.Length; i++) {
            char t=arr[start]; arr[start]=arr[i]; arr[i]=t;
            Permute(arr, start+1);
            t=arr[start]; arr[start]=arr[i]; arr[i]=t;
        }
    }
    static void Main() {
        Console.Write("Enter string (max 5 chars): "); string s = Console.ReadLine();
        Permute(s.ToCharArray(), 0);
    }
}
