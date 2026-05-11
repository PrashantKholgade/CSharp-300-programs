// Program 160: Nested Try Catch
// Category: Intermediate

using System;
class Program {
    static void Main() {
        try {
            Console.Write("Numerator: ");   int a = int.Parse(Console.ReadLine());
            try {
                Console.Write("Denominator: "); int b = int.Parse(Console.ReadLine());
                Console.WriteLine("Result = " + (a / b));
            } catch (DivideByZeroException) {
                Console.WriteLine("Inner catch: Division by zero.");
            }
        } catch (FormatException) {
            Console.WriteLine("Outer catch: Invalid number format.");
        }
    }
}
