// Program 257: Composite Pattern File System
// Category: Advanced

using System;using System.Collections.Generic;
abstract class FSNode{public string Name;public FSNode(string n){Name=n;}public abstract void Display(int depth=0);}
class File:FSNode{public File(string n):base(n){}public override void Display(int d=0)=>Console.WriteLine(new string(' ',d*2)+"- "+Name);}
class Folder:FSNode{List<FSNode>children=new List<FSNode>();public Folder(string n):base(n){}public void Add(FSNode n)=>children.Add(n);public override void Display(int d=0){Console.WriteLine(new string(' ',d*2)+"["+Name+"]");foreach(var c in children)c.Display(d+1);}}
class Program{static void Main(){var root=new Folder("root");var docs=new Folder("docs");docs.Add(new File("readme.txt"));docs.Add(new File("notes.md"));root.Add(docs);root.Add(new File("index.cs"));root.Display();}}
