// Program 93: Shopping Bill Calculator
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        double total = 0;
        Console.WriteLine("Enter items (name price). Type 'done' to finish.");
        while (true)
        {
            Console.Write("Item name: ");
            string item = Console.ReadLine();
            if (item.ToLower() == "done") break;
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine());
            total += price;
            Console.WriteLine("  Added: Rs." + price);
        }
        double tax   = total * 0.18;
        Console.WriteLine("Subtotal: Rs." + total.ToString("F2"));
        Console.WriteLine("GST(18%): Rs." + tax.ToString("F2"));
        Console.WriteLine("Total   : Rs." + (total + tax).ToString("F2"));
    }
}
