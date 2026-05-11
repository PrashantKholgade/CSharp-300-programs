// Program 172: Struct - Rectangle Operations
// Category: Intermediate

using System;
struct Rect {
    public double Width, Height;
    public double Area()      => Width * Height;
    public double Perimeter() => 2 * (Width + Height);
}
class Program {
    static void Main() {
        Rect r; r.Width=5.5; r.Height=3.2;
        Console.WriteLine("Area      = " + r.Area().ToString("F2"));
        Console.WriteLine("Perimeter = " + r.Perimeter().ToString("F2"));
    }
}
