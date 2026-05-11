// Program 109: Matrix Addition
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[,] a = {{1,2},{3,4}}, b = {{5,6},{7,8}};
        Console.WriteLine("Matrix A + B:");
        for (int i = 0; i < 2; i++) {
            for (int j = 0; j < 2; j++) Console.Write((a[i,j]+b[i,j]).ToString().PadLeft(4));
            Console.WriteLine();
        }
    }
}
