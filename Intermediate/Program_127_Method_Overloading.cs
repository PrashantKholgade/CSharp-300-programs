// Program 127: Method Overloading
// Category: Intermediate

using System;
class Program {
    static int    Area(int side)            => side * side;
    static double Area(double r)            => Math.PI * r * r;
    static int    Area(int l, int w)        => l * w;
    static void Main() {
        Console.WriteLine("Square(4)       = " + Area(4));
        Console.WriteLine("Circle(3.5)     = " + Area(3.5).ToString("F2"));
        Console.WriteLine("Rectangle(4,5)  = " + Area(4, 5));
    }
}
