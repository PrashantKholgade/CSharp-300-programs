// Program 54: Hollow Rectangle Pattern
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Rows: "); int rows = int.Parse(Console.ReadLine());
        Console.Write("Cols: "); int cols = int.Parse(Console.ReadLine());
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(i == 0 || i == rows-1 || j == 0 || j == cols-1 ? "* " : "  ");
            Console.WriteLine();
        }
    }
}
