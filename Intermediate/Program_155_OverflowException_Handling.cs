// Program 155: OverflowException Handling
// Category: Intermediate

using System;
class Program {
    static void Main() {
        try {
            checked {
                int max = int.MaxValue;
                Console.WriteLine("MaxValue = " + max);
                int overflow = max + 1;
                Console.WriteLine("Overflow = " + overflow);
            }
        } catch (OverflowException) {
            Console.WriteLine("Overflow detected! Value exceeds int range.");
        }
    }
}
