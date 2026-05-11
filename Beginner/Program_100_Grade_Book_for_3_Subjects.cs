// Program 100: Grade Book for 3 Subjects
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        string[] subjects = { "Math", "Science", "English" };
        double total = 0;
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Enter marks for " + subjects[i] + " (out of 100): ");
            double marks = double.Parse(Console.ReadLine());
            total += marks;
        }
        double avg = total / 3;
        char grade = avg >= 90 ? 'A' : avg >= 75 ? 'B' : avg >= 60 ? 'C' : avg >= 45 ? 'D' : 'F';
        Console.WriteLine("Total: " + total + ", Average: " + avg.ToString("F2") + ", Grade: " + grade);
    }
}
