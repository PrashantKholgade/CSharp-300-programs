// Program 187: Ternary Operator Chain
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter marks: "); int m = int.Parse(Console.ReadLine());
        string grade = m>=90?"A" : m>=75?"B" : m>=60?"C" : m>=45?"D" : "F";
        string status = m >= 45 ? "PASS" : "FAIL";
        Console.WriteLine($"Grade: {grade}  Status: {status}");
    }
}
