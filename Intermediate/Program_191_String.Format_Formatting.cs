// Program 191: String.Format Formatting
// Category: Intermediate

using System;
class Program {
    static void Main() {
        double price = 1234.567;
        int qty = 5;
        Console.WriteLine(string.Format("Price: {0:C2}", price));
        Console.WriteLine(string.Format("Quantity: {0:D5}", qty));
        Console.WriteLine(string.Format("Rate: {0:P1}", 0.1753));
        Console.WriteLine(string.Format("Pi: {0:F4}", Math.PI));
    }
}
