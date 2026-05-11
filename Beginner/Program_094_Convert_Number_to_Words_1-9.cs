// Program 94: Convert Number to Words (1-9)
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        string[] words = {"","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
        Console.Write("Enter a digit (1-9): ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(n >= 1 && n <= 9 ? words[n] : "Out of range.");
    }
}
