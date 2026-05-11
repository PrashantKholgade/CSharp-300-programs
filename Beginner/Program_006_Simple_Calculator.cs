// Program 6: Simple Calculator
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Enter operator (+,-,*,/): ");
        char op = char.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double n2 = double.Parse(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+': result = n1 + n2; break;
            case '-': result = n1 - n2; break;
            case '*': result = n1 * n2; break;
            case '/':
                if (n2 == 0) { Console.WriteLine("Division by zero!"); return; }
                result = n1 / n2; break;
            default: Console.WriteLine("Invalid operator!"); return;
        }
        Console.WriteLine("Result = " + result);
    }
}
