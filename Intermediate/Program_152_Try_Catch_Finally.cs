// Program 152: Try Catch Finally
// Category: Intermediate

using System;
class Program {
    static void Main() {
        try {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Square = " + (n * n));
        } catch (FormatException ex) {
            Console.WriteLine("Format error: " + ex.Message);
        } finally {
            Console.WriteLine("Program execution complete.");
        }
    }
}
