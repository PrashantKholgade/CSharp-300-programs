// Program 244: Student Grade Manager with List
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Student{public string Name;public List<int>Marks=new List<int>();public double Average()=>Marks.Average();public char Grade(){double a=Average();return a>=90?'A':a>=75?'B':a>=60?'C':a>=45?'D':'F';}}
class Program{static void Main(){
    var students=new List<Student>{
        new Student{Name="Alice",Marks=new List<int>{90,85,92}},
        new Student{Name="Bob",Marks=new List<int>{60,70,65}},
        new Student{Name="Charlie",Marks=new List<int>{45,50,40}}};
    foreach(var s in students)Console.WriteLine($"{s.Name}: Avg={s.Average():F1} Grade={s.Grade()}");
    var top=students.OrderByDescending(s=>s.Average()).First();
    Console.WriteLine("Top student: "+top.Name);
}}
