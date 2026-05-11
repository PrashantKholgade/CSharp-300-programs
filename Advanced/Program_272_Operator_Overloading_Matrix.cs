// Program 272: Operator Overloading Matrix
// Category: Advanced

using System;
class Matrix{
    int[,]m={{0,0},{0,0}};
    public Matrix(int a,int b,int c,int d){m[0,0]=a;m[0,1]=b;m[1,0]=c;m[1,1]=d;}
    public static Matrix operator+(Matrix a,Matrix b)=>new Matrix(a.m[0,0]+b.m[0,0],a.m[0,1]+b.m[0,1],a.m[1,0]+b.m[1,0],a.m[1,1]+b.m[1,1]);
    public void Print(){Console.WriteLine(m[0,0]+" "+m[0,1]);Console.WriteLine(m[1,0]+" "+m[1,1]);}
}
class Program{static void Main(){var a=new Matrix(1,2,3,4);var b=new Matrix(5,6,7,8);Console.WriteLine("A+B:");(a+b).Print();}}
