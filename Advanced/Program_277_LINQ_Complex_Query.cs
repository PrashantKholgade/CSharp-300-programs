// Program 277: LINQ Complex Query
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Employee{public string Name,Dept;public double Salary;}
class Program{static void Main(){
    var emp=new List<Employee>{new Employee{Name="Alice",Dept="IT",Salary=70000},new Employee{Name="Bob",Dept="HR",Salary=50000},new Employee{Name="Charlie",Dept="IT",Salary=80000},new Employee{Name="Diana",Dept="HR",Salary=55000}};
    var result=emp.GroupBy(e=>e.Dept).Select(g=>new{Dept=g.Key,Avg=g.Average(e=>e.Salary),Max=g.Max(e=>e.Salary)});
    foreach(var r in result)Console.WriteLine($"{r.Dept}: Avg={r.Avg:F0} Max={r.Max:F0}");
}}
