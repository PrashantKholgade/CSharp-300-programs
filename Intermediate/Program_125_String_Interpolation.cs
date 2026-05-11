// Program 125: String Interpolation
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Name: ");   string name = Console.ReadLine();
        Console.Write("Age: ");    int age   = int.Parse(Console.ReadLine());
        Console.Write("Course: "); string course = Console.ReadLine();
        Console.WriteLine($"Student {name}, Age {age}, enrolled in {course}.");
    }
}
