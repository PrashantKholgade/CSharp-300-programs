// Program 228: LinkedList Example
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    LinkedList<int>list=new LinkedList<int>();
    list.AddLast(10);list.AddLast(20);list.AddFirst(5);list.AddLast(30);
    Console.Write("LinkedList: ");foreach(int x in list)Console.Write(x+" ");Console.WriteLine();
    list.Remove(20);Console.Write("After remove 20: ");foreach(int x in list)Console.Write(x+" ");Console.WriteLine();
}}
