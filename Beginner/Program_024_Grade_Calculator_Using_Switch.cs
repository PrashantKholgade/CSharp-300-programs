// Program 24: Grade Calculator Using Switch
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter marks (0-100): ");
        int marks = int.Parse(Console.ReadLine());
        char grade;
        switch (marks / 10)
        {
            case 10: case 9: grade = 'A'; break;
            case 8:          grade = 'B'; break;
            case 7:          grade = 'C'; break;
            case 6:          grade = 'D'; break;
            default:         grade = 'F'; break;
        }
        Console.WriteLine("Grade = " + grade);
    }
}
