// Program 201: Class Basic Person
// Category: Advanced

using System;
class Person {
    public string Name; public int Age;
    public Person(string n,int ag){Name=n;Age=ag;}
    public void Display()=>Console.WriteLine($"Name:{Name} Age:{Age}");
}
class Program{static void Main(){new Person("Alice",22).Display();}}
