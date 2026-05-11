// Program 207: Static Class Members
// Category: Advanced

using System;
class MathHelper{
    public static double PI=3.14159;
    public static double CircleArea(double r)=>PI*r*r;
    public static int Factorial(int n){int f=1;for(int i=2;i<=n;i++)f*=i;return f;}
}
class Program{static void Main(){Console.WriteLine("Area="+MathHelper.CircleArea(5).ToString("F2"));Console.WriteLine("5!="+MathHelper.Factorial(5));}}
