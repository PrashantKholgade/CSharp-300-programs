// Program 274: Fibonacci Memoization
// Category: Advanced

using System;using System.Collections.Generic;
class Program{
    static Dictionary<int,long>memo=new Dictionary<int,long>();
    static long Fib(int n){if(n<=1)return n;if(memo.ContainsKey(n))return memo[n];memo[n]=Fib(n-1)+Fib(n-2);return memo[n];}
    static void Main(){Console.Write("N: ");int n=int.Parse(Console.ReadLine());for(int i=0;i<=n;i++)Console.Write(Fib(i)+" ");Console.WriteLine();}
}
