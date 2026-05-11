// Program 157: Rethrow Exception
// Category: Intermediate

using System;
class Program {
    static void InnerMethod() { throw new InvalidOperationException("Inner error occurred."); }
    static void OuterMethod() {
        try { InnerMethod(); }
        catch (Exception) { Console.WriteLine("Outer: Caught and rethrowing."); throw; }
    }
    static void Main() {
        try { OuterMethod(); }
        catch (Exception ex) { Console.WriteLine("Main: Final catch - " + ex.Message); }
    }
}
