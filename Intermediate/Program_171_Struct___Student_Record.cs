// Program 171: Struct - Student Record
// Category: Intermediate

using System;
struct Student {
    public string Name; public int Age; public double GPA;
    public Student(string n, int a, double g) { Name=n; Age=a; GPA=g; }
    public override string ToString() => $"{Name} | Age: {Age} | GPA: {GPA:F1}";
}
class Program {
    static void Main() {
        Student s = new Student("Alice", 20, 3.8);
        Console.WriteLine(s);
    }
}
