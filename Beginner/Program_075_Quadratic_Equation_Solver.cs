// Program 75: Quadratic Equation Solver
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("a: "); double a = double.Parse(Console.ReadLine());
        Console.Write("b: "); double b = double.Parse(Console.ReadLine());
        Console.Write("c: "); double c = double.Parse(Console.ReadLine());
        double disc = b*b - 4*a*c;
        if (disc > 0)
        {
            double r1 = (-b + Math.Sqrt(disc)) / (2*a);
            double r2 = (-b - Math.Sqrt(disc)) / (2*a);
            Console.WriteLine("Two real roots: " + r1.ToString("F4") + " and " + r2.ToString("F4"));
        }
        else if (disc == 0)
            Console.WriteLine("One root: " + (-b / (2*a)).ToString("F4"));
        else
            Console.WriteLine("Complex roots. No real solution.");
    }
}
