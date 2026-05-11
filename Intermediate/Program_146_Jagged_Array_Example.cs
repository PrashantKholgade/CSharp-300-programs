// Program 146: Jagged Array Example
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[][] jag = new int[3][];
        jag[0] = new int[]{1};
        jag[1] = new int[]{1,2};
        jag[2] = new int[]{1,2,3};
        foreach (var row in jag) {
            foreach (int x in row) Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}
