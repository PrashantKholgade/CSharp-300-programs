// Program 265: Abstract Shape Calculator
// Category: Advanced

using System;
abstract class Shape{public abstract double Area();public abstract double Perimeter();public void Print()=>Console.WriteLine($"{GetType().Name,-10} Area:{Area():F2,-10} Perimeter:{Perimeter():F2}");}
class Circle:Shape{double r;public Circle(double r){this.r=r;}public override double Area()=>Math.PI*r*r;public override double Perimeter()=>2*Math.PI*r;}
class Rectangle:Shape{double w,h;public Rectangle(double w,double h){this.w=w;this.h=h;}public override double Area()=>w*h;public override double Perimeter()=>2*(w+h);}
class Triangle:Shape{double a,b,c;public Triangle(double a,double b,double c){this.a=a;this.b=b;this.c=c;}public override double Area(){double s=(a+b+c)/2;return Math.Sqrt(s*(s-a)*(s-b)*(s-c));}public override double Perimeter()=>a+b+c;}
class Program{static void Main(){Shape[]shapes={new Circle(5),new Rectangle(4,6),new Triangle(3,4,5)};foreach(var s in shapes)s.Print();}}
