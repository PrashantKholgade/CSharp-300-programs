// Program 205: This Keyword
// Category: Advanced

using System;
class Student{
    string name;int marks;
    public Student(string name,int marks){this.name=name;this.marks=marks;}
    public Student SetName(string name){this.name=name;return this;}
    public void Show()=>Console.WriteLine(name+": "+marks);
}
class Program{static void Main(){var s=new Student("Alice",90);s.SetName("Bob").Show();}}
