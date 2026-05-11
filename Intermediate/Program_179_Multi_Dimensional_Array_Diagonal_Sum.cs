// Program 179: Multi-Dimensional Array Diagonal Sum
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[,] matrix = {{1,2,3},{4,5,6},{7,8,9}};
        int sum = 0;
        for (int i = 0; i < 3; i++) sum += matrix[i,i];
        Console.WriteLine("Primary diagonal sum = " + sum);
    }
}
