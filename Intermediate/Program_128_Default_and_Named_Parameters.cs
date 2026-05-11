// Program 128: Default and Named Parameters
// Category: Intermediate

using System;
class Program {
    static void Greet(string name, string msg = "Hello") {
        Console.WriteLine(msg + ", " + name + "!");
    }
    static void Main() {
        Greet("Alice");
        Greet("Bob", "Welcome");
        Greet(name: "Charlie", msg: "Hi");
    }
}
