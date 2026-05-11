// Program 264: Student Database LINQ
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Student{public int Id;public string Name;public string Branch;public double CGPA;}
class Program{static void Main(){
    var db=new List<Student>{
        new Student{Id=1,Name="Alice",Branch="CS",CGPA=9.1},
        new Student{Id=2,Name="Bob",Branch="IT",CGPA=8.5},
        new Student{Id=3,Name="Charlie",Branch="CS",CGPA=7.8},
        new Student{Id=4,Name="Diana",Branch="EC",CGPA=9.4}};
    Console.WriteLine("CS students: "+string.Join(", ",db.Where(s=>s.Branch=="CS").Select(s=>s.Name)));
    Console.WriteLine("Topper: "+db.OrderByDescending(s=>s.CGPA).First().Name);
    Console.WriteLine("Avg CGPA: "+db.Average(s=>s.CGPA).ToString("F2"));
}}
