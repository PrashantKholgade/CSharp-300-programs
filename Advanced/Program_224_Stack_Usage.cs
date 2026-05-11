// Program 224: Stack Usage
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    Stack<string>history=new Stack<string>();
    history.Push("Page1");history.Push("Page2");history.Push("Page3");
    Console.WriteLine("Current: "+history.Peek());
    Console.WriteLine("Going back...");history.Pop();
    Console.WriteLine("Current: "+history.Peek());
}}
