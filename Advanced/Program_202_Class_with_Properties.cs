// Program 202: Class with Properties
// Category: Advanced

using System;
class Circle{
    private double _r;
    public double Radius{get=>_r; set{if(value>0)_r=value; else throw new ArgumentException("Radius must be positive");}}
    public double Area=>Math.PI*_r*_r;
}
class Program{static void Main(){var c=new Circle();c.Radius=5;Console.WriteLine("Area="+c.Area.ToString("F2"));}}
