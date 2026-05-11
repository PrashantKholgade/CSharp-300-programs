// Program 208: Access Modifiers Demo
// Category: Advanced

using System;
class Employee{
    public string Name;
    private double salary;
    protected string department;
    public Employee(string n,double s,string d){Name=n;salary=s;department=d;}
    public void ShowSalary()=>Console.WriteLine(Name+"'s salary: "+salary);
    public string Department=>department;
}
class Program{static void Main(){var e=new Employee("Alice",50000,"IT");e.ShowSalary();Console.WriteLine("Dept: "+e.Department);}}
