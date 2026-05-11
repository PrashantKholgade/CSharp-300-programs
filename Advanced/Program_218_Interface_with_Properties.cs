// Program 218: Interface with Properties
// Category: Advanced

using System;
interface IEmployee{string Name{get;}double Salary{get;}void ShowInfo();}
class Manager:IEmployee{public string Name{get;}public double Salary{get;}public Manager(string n,double s){Name=n;Salary=s;}public void ShowInfo()=>Console.WriteLine($"Manager:{Name} Salary:{Salary:F2}");}
class Program{static void Main(){IEmployee e=new Manager("Alice",75000);e.ShowInfo();}}
