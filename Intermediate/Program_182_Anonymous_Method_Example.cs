// Program 182: Anonymous Method Example
// Category: Intermediate

using System;
class Program {
    delegate int Operation(int a, int b);
    static void Main() {
        Operation multiply = delegate(int a, int b) { return a * b; };
        Operation subtract = delegate(int a, int b) { return a - b; };
        Console.WriteLine("5 * 3 = " + multiply(5, 3));
        Console.WriteLine("10- 4 = " + subtract(10, 4));
    }
}
