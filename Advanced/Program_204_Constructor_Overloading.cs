// Program 204: Constructor Overloading
// Category: Advanced

using System;
class Box{
    double l,w,h;
    public Box(){l=w=h=1;}
    public Box(double s){l=w=h=s;}
    public Box(double l,double w,double h){this.l=l;this.w=w;this.h=h;}
    public double Volume()=>l*w*h;
}
class Program{static void Main(){Console.WriteLine(new Box().Volume());Console.WriteLine(new Box(3).Volume());Console.WriteLine(new Box(2,3,4).Volume());}}
