// Program 159: Display Exception Message and Stack Trace
// Category: Intermediate

using System;
class Program {
    static void Divide() { int r = 10 / 0; }
    static void Main() {
        try { Divide(); }
        catch (Exception ex) {
            Console.WriteLine("Message: " + ex.Message);
            Console.WriteLine("Type:    " + ex.GetType().Name);
            Console.WriteLine("Source:  " + ex.Source);
        }
    }
}
