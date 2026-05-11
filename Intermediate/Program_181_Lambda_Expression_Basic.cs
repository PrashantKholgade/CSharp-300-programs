// Program 181: Lambda Expression Basic
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Func<int,int> square = x => x * x;
        Func<int,int,int> add = (a,b) => a + b;
        Action<string> greet = name => Console.WriteLine("Hello, " + name + "!");
        Console.WriteLine("Square(7) = " + square(7));
        Console.WriteLine("Add(3,4)  = " + add(3, 4));
        greet("Alice");
    }
}
