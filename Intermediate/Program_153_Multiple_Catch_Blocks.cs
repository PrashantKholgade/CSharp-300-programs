// Program 153: Multiple Catch Blocks
// Category: Intermediate

using System;
class Program {
    static void Main() {
        try {
            int[] arr = {1,2,3};
            Console.Write("Index: "); int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Value = " + arr[i]);
        } catch (FormatException)          { Console.WriteLine("Enter a valid number."); }
          catch (IndexOutOfRangeException) { Console.WriteLine("Index out of range."); }
          catch (Exception ex)             { Console.WriteLine("Error: " + ex.Message); }
    }
}
