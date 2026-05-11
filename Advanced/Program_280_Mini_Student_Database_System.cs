// Program 280: Mini Student Database System
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Student{public int Id;public string Name;public string Course;public List<double>Marks=new List<double>();public double Average()=>Marks.Any()?Marks.Average():0;public char Grade(){double a=Average();return a>=90?'A':a>=75?'B':a>=60?'C':a>=45?'D':'F';}public override string ToString()=>$"[{Id}] {Name,-12} {Course,-8} Avg:{Average():F1} Grade:{Grade()}";}
class StudentDB{
    List<Student>db=new List<Student>();int nextId=1;
    public void Add(string n,string c){db.Add(new Student{Id=nextId++,Name=n,Course=c});Console.WriteLine("Added student "+n);}
    public void AddMark(int id,double m){var s=db.Find(x=>x.Id==id);if(s!=null){s.Marks.Add(m);Console.WriteLine("Mark "+m+" added to "+s.Name);}else Console.WriteLine("Student not found.");}
    public void ShowAll(){if(!db.Any()){Console.WriteLine("No students.");return;}foreach(var s in db)Console.WriteLine(s);}
    public void ShowToppers()=>db.OrderByDescending(s=>s.Average()).Take(3).ToList().ForEach(s=>Console.WriteLine(s));
    public void ShowByGrade(char g)=>db.Where(s=>s.Grade()==g).ToList().ForEach(s=>Console.WriteLine(s));
}
class Program{static void Main(){
    var sdb=new StudentDB();
    sdb.Add("Alice","CS");sdb.Add("Bob","IT");sdb.Add("Charlie","CS");
    sdb.AddMark(1,90);sdb.AddMark(1,85);sdb.AddMark(1,92);
    sdb.AddMark(2,70);sdb.AddMark(2,65);sdb.AddMark(2,75);
    sdb.AddMark(3,55);sdb.AddMark(3,60);sdb.AddMark(3,50);
    Console.WriteLine("
--- All Students ---");sdb.ShowAll();
    Console.WriteLine("
--- Top 3 ---");sdb.ShowToppers();
    Console.WriteLine("
--- Grade A ---");sdb.ShowByGrade('A');
}}
