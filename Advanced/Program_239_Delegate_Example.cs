// Program 239: Delegate Example
// Category: Advanced

using System;
delegate int MathOp(int a,int b);
class Program{static void Main(){
    MathOp add=(a,b)=>a+b;
    MathOp mul=(a,b)=>a*b;
    MathOp sub=(a,b)=>a-b;
    Console.WriteLine("5+3="+add(5,3));
    Console.WriteLine("5*3="+mul(5,3));
    Console.WriteLine("5-3="+sub(5,3));
}}
