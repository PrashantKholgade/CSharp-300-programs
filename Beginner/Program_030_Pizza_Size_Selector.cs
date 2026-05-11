// Program 30: Pizza Size Selector
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter pizza size (S/M/L/XL): ");
        string size = Console.ReadLine().Trim().ToUpper();
        switch (size)
        {
            case "S":  Console.WriteLine("Small  - Rs. 199"); break;
            case "M":  Console.WriteLine("Medium - Rs. 299"); break;
            case "L":  Console.WriteLine("Large  - Rs. 399"); break;
            case "XL": Console.WriteLine("X-Large- Rs. 499"); break;
            default:   Console.WriteLine("Invalid size.");    break;
        }
    }
}
