// Program 149: TryParse Safe Input
// Category: Intermediate

using System;
class Program {
    static void Main() {
        Console.Write("Enter an integer: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int num))
            Console.WriteLine("Valid integer: " + num);
        else
            Console.WriteLine("Invalid input. Please enter an integer.");
    }
}
