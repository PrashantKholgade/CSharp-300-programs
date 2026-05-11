// Program 175: Nullable Types
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int? score = null;
        Console.WriteLine("Score has value: " + score.HasValue);
        score = 85;
        Console.WriteLine("Score has value: " + score.HasValue);
        Console.WriteLine("Score = " + score.Value);
        Console.WriteLine("Score ?? 0 = " + (score ?? 0));
    }
}
