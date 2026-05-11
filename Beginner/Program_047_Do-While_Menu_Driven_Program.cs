// Program 47: Do-While Menu Driven Program
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        int choice;
        do
        {
            Console.WriteLine("
1. Say Hello  2. Show Date  3. Exit");
            Console.Write("Choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine("Hello, World!"); break;
                case 2: Console.WriteLine("Date: " + DateTime.Now.ToShortDateString()); break;
                case 3: Console.WriteLine("Goodbye!"); break;
                default: Console.WriteLine("Invalid choice."); break;
            }
        } while (choice != 3);
    }
}
