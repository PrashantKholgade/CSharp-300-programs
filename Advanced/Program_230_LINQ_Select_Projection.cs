// Program 230: LINQ Select Projection
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    List<string>names=new List<string>{"alice","bob","charlie"};
    var upper=names.Select(n=>n.ToUpper());
    var lengths=names.Select(n=>new{Name=n,Length=n.Length});
    foreach(var x in upper)Console.Write(x+" ");Console.WriteLine();
    foreach(var x in lengths)Console.WriteLine(x.Name+"->"+x.Length);
}}
