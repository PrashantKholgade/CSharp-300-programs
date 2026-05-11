// Program 158: FormatException Handling
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter an integer: ");
        try {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("You entered: " + n);
        } catch (FormatException) {
            Console.WriteLine("FormatException: Please enter a valid integer.");
        }
    }
}
