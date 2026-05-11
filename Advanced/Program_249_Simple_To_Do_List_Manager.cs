// Program 249: Simple To-Do List Manager
// Category: Advanced

using System;using System.Collections.Generic;
class Program{static void Main(){
    var todos=new List<string>();
    string cmd;
    Console.WriteLine("Commands: add <task> | done <n> | list | quit");
    while((cmd=Console.ReadLine().Trim().ToLower())!="quit"){
        if(cmd.StartsWith("add ")){todos.Add(cmd.Substring(4));Console.WriteLine("Added.");}
        else if(cmd.StartsWith("done ")){int idx=int.Parse(cmd.Substring(5))-1;if(idx>=0&&idx<todos.Count){Console.WriteLine("Done: "+todos[idx]);todos.RemoveAt(idx);}else Console.WriteLine("Invalid.");}
        else if(cmd=="list"){for(int i=0;i<todos.Count;i++)Console.WriteLine((i+1)+". "+todos[i]);}
    }
}}
