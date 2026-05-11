// Program 254: Strategy Pattern
// Category: Advanced

using System;
interface ISortStrategy{void Sort(int[]arr);}
class BubbleSort:ISortStrategy{public void Sort(int[]a){for(int i=0;i<a.Length-1;i++)for(int j=0;j<a.Length-i-1;j++)if(a[j]>a[j+1]){int t=a[j];a[j]=a[j+1];a[j+1]=t;}}}
class BuiltinSort:ISortStrategy{public void Sort(int[]a)=>Array.Sort(a);}
class Sorter{ISortStrategy strategy;public Sorter(ISortStrategy s){strategy=s;}public void Sort(int[]a){strategy.Sort(a);}}
class Program{static void Main(){int[]arr={5,3,8,1,2};new Sorter(new BubbleSort()).Sort(arr);foreach(int x in arr)Console.Write(x+" ");Console.WriteLine();}}
