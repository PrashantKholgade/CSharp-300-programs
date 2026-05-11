// Program 108: 2D Matrix Display
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[,] mat = { {1,2,3},{4,5,6},{7,8,9} };
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) Console.Write(mat[i,j].ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}
