// Program 246: Employee Payroll System
// Category: Advanced

using System;using System.Collections.Generic;
abstract class Employee{public string Name;public double Basic;public Employee(string n,double b){Name=n;Basic=b;}public abstract double Salary();}
class FullTime:Employee{public FullTime(string n,double b):base(n,b){}public override double Salary()=>Basic*12;}
class PartTime:Employee{public int Hours;public double Rate;public PartTime(string n,int h,double r):base(n,h*r){Hours=h;Rate=r;}public override double Salary()=>Hours*Rate;}
class Program{static void Main(){var emps=new List<Employee>{new FullTime("Alice",5000),new PartTime("Bob",80,25)};foreach(var e in emps)Console.WriteLine(e.Name+": Rs."+e.Salary().ToString("F2"));}}
