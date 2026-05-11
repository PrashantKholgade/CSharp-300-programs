// Program 237: LINQ Join Two Collections
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Program{static void Main(){
    var students=new[]{new{Id=1,Name="Alice"},new{Id=2,Name="Bob"},new{Id=3,Name="Charlie"}};
    var scores=new[]{new{StudentId=1,Score=90},new{StudentId=2,Score=85},new{StudentId=3,Score=92}};
    var result=students.Join(scores,s=>s.Id,sc=>sc.StudentId,(s,sc)=>new{s.Name,sc.Score});
    foreach(var r in result)Console.WriteLine(r.Name+": "+r.Score);
}}
