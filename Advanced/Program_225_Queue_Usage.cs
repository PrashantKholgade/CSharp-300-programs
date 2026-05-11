// Program 225: Queue Usage
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    Queue<string>queue=new Queue<string>();
    queue.Enqueue("Task1");queue.Enqueue("Task2");queue.Enqueue("Task3");
    Console.WriteLine("Processing queue:");
    while(queue.Count>0)Console.WriteLine("Processing: "+queue.Dequeue());
}}
