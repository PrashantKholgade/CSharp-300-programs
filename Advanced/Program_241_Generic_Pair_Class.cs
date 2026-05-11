// Program 241: Generic Pair Class
// Category: Advanced

using System;
class Pair<T,U>{public T First;public U Second;public Pair(T f,U s){First=f;Second=s;}public override string ToString()=>"("+First+", "+Second+")";}
class Program{static void Main(){
    var p1=new Pair<string,int>("Alice",25);
    var p2=new Pair<double,bool>(3.14,true);
    Console.WriteLine(p1);Console.WriteLine(p2);
}}
