// Program 214: Polymorphism Demo
// Category: Advanced

using System;
class Shape{public virtual void Draw()=>Console.WriteLine("Drawing Shape");}
class Circle:Shape{public override void Draw()=>Console.WriteLine("Drawing Circle");}
class Square:Shape{public override void Draw()=>Console.WriteLine("Drawing Square");}
class Program{static void Main(){Shape[]shapes={new Shape(),new Circle(),new Square()};foreach(var s in shapes)s.Draw();}}
