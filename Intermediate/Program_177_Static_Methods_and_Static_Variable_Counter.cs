// Program 177: Static Methods and Static Variable Counter
// Category: Intermediate

using System;
class Counter {
    static int count = 0;
    public static void Increment() { count++; }
    public static int GetCount()   { return count; }
}
class Program {
    static void Main() {
        Counter.Increment(); Counter.Increment(); Counter.Increment();
        Console.WriteLine("Count = " + Counter.GetCount());
    }
}
