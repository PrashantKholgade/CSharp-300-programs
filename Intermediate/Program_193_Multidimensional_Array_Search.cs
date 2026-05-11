// Program 193: Multidimensional Array Search
// Category: Intermediate

using System;
class Program {
    static void Main() {
        int[,] m = {{1,2,3},{4,5,6},{7,8,9}};
        Console.Write("Search: "); int key = int.Parse(Console.ReadLine());
        bool found = false;
        for (int i=0;i<3&&!found;i++)
            for (int j=0;j<3;j++)
                if (m[i,j]==key) { Console.WriteLine("Found at row "+i+", col "+j); found=true; break; }
        if (!found) Console.WriteLine("Not found.");
    }
}
