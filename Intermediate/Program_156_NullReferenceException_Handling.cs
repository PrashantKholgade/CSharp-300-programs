// Program 156: NullReferenceException Handling
// Category: Intermediate

using System;
class Program {
    static void Main() {
        try {
            string s = null;
            Console.WriteLine(s.Length);
        } catch (NullReferenceException) {
            Console.WriteLine("Error: Object reference not set. Variable is null.");
        }
    }
}
