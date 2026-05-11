// Program 216: Interface IShape
// Category: Advanced

using System;
interface IShape{double Area();double Perimeter();}
class Circle:IShape{double r;public Circle(double r){this.r=r;}public double Area()=>Math.PI*r*r;public double Perimeter()=>2*Math.PI*r;}
class Rectangle:IShape{double w,h;public Rectangle(double w,double h){this.w=w;this.h=h;}public double Area()=>w*h;public double Perimeter()=>2*(w+h);}
class Program{static void Main(){IShape[]shapes={new Circle(5),new Rectangle(4,6)};foreach(var s in shapes)Console.WriteLine(s.GetType().Name+": Area="+s.Area().ToString("F2")+" Perimeter="+s.Perimeter().ToString("F2"));}}
