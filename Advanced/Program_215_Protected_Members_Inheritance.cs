// Program 215: Protected Members Inheritance
// Category: Advanced

using System;
class Person{protected string name;protected int age;public Person(string n,int a){name=n;age=a;}}
class Employee:Person{string role;public Employee(string n,int a,string r):base(n,a){role=r;}public void Show()=>Console.WriteLine($"{name} | Age:{age} | {role}");}
class Program{static void Main(){new Employee("Alice",30,"Engineer").Show();}}
