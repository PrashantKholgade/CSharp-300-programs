// Program 137: Tower of Hanoi
// Category: Intermediate

using System;
class Program {
    static void Hanoi(int n, char from, char to, char aux) {
        if (n == 0) return;
        Hanoi(n-1, from, aux, to);
        Console.WriteLine("Move disk " + n + ": " + from + " -> " + to);
        Hanoi(n-1, aux, to, from);
    }
    static void Main() {
        Console.Write("Number of disks: "); int n = int.Parse(Console.ReadLine());
        Hanoi(n, 'A', 'C', 'B');
    }
}
