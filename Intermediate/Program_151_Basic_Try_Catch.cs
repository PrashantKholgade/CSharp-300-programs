// Program 151: Basic Try Catch
// Category: Intermediate

using System;
class Program {
    static void Main() {
        try {
            Console.Write("Enter numerator: ");   int a = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: "); int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Result = " + (a / b));
        } catch (DivideByZeroException) {
            Console.WriteLine("Error: Cannot divide by zero.");
        } catch (FormatException) {
            Console.WriteLine("Error: Invalid number format.");
        }
    }
}
