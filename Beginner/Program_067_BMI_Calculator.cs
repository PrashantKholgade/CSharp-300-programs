// Program 67: BMI Calculator
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Weight (kg): ");
        double weight = double.Parse(Console.ReadLine());
        Console.Write("Height (m): ");
        double height = double.Parse(Console.ReadLine());
        double bmi = weight / (height * height);
        Console.WriteLine("BMI = " + bmi.ToString("F2"));
        if      (bmi < 18.5) Console.WriteLine("Underweight");
        else if (bmi < 25.0) Console.WriteLine("Normal weight");
        else if (bmi < 30.0) Console.WriteLine("Overweight");
        else                 Console.WriteLine("Obese");
    }
}
