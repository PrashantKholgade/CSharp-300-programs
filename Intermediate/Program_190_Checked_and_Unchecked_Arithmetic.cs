// Program 190: Checked and Unchecked Arithmetic
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int max = int.MaxValue;
        Console.WriteLine("MaxValue: " + max);
        // Unchecked - wraps silently
        int unchecked_result = unchecked(max + 1);
        Console.WriteLine("Unchecked overflow: " + unchecked_result);
        // Checked - throws exception
        try { int checked_result = checked(max + 1); }
        catch (OverflowException) { Console.WriteLine("Checked: OverflowException caught!"); }
    }
}
