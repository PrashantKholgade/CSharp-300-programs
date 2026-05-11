// Program 210: Inheritance Shape Hierarchy
// Category: Advanced

using System;
abstract class Shape{public abstract double Area();public void Print()=>Console.WriteLine(GetType().Name+" Area="+Area().ToString("F2"));}
class Rectangle:Shape{double w,h;public Rectangle(double w,double h){this.w=w;this.h=h;}public override double Area()=>w*h;}
class Triangle:Shape{double b,h;public Triangle(double b,double h){this.b=b;this.h=h;}public override double Area()=>0.5*b*h;}
class Program{static void Main(){new Rectangle(4,5).Print();new Triangle(3,6).Print();}}
