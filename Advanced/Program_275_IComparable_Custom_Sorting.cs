// Program 275: IComparable Custom Sorting
// Category: Advanced

using System;using System.Collections.Generic;
class Student:IComparable<Student>{public string Name;public double GPA;public int CompareTo(Student other)=>other.GPA.CompareTo(GPA);}
class Program{static void Main(){
    var list=new List<Student>{new Student{Name="Alice",GPA=3.8},new Student{Name="Bob",GPA=3.5},new Student{Name="Charlie",GPA=3.9}};
    list.Sort();
    Console.WriteLine("Ranked by GPA:");
    for(int i=0;i<list.Count;i++)Console.WriteLine((i+1)+". "+list[i].Name+" ("+list[i].GPA+")");
}}
