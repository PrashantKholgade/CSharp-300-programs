// Program 176: Tuple Return from Method
// Category: Intermediate

using System;
class Program {
    static (int Min, int Max, double Avg) Stats(int[] arr) {
        int min=arr[0],max=arr[0],sum=0;
        foreach(int x in arr){ if(x<min)min=x; if(x>max)max=x; sum+=x; }
        return (min, max, (double)sum/arr.Length);
    }
    static void Main() {
        int[] data = {4,7,2,9,1,5,8};
        var (min,max,avg) = Stats(data);
        Console.WriteLine($"Min={min}  Max={max}  Avg={avg:F2}");
    }
}
