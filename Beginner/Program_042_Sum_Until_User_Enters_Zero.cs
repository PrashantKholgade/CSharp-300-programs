// Program 42: Sum Until User Enters Zero
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        int sum = 0, num;
        Console.WriteLine("Enter numbers (0 to stop):");
        do
        {
            Console.Write("> ");
            num = int.Parse(Console.ReadLine());
            sum += num;
        } while (num != 0);
        Console.WriteLine("Total Sum = " + sum);
    }
}
