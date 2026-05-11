// Program 279: Polymorphic Drawing System
// Category: Advanced

using System;using System.Collections.Generic;
abstract class Drawable{public int X,Y;public abstract void Draw();public void Move(int dx,int dy){X+=dx;Y+=dy;Console.WriteLine("Moved to ("+X+","+Y+")");}}
class Circle:Drawable{public int R;public Circle(int x,int y,int r){X=x;Y=y;R=r;}public override void Draw()=>Console.WriteLine($"Circle at ({X},{Y}) r={R}");}
class Square:Drawable{public int Side;public Square(int x,int y,int s){X=x;Y=y;Side=s;}public override void Draw()=>Console.WriteLine($"Square at ({X},{Y}) side={Side}");}
class Program{static void Main(){List<Drawable>canvas=new List<Drawable>{new Circle(0,0,5),new Square(10,10,4)};foreach(var d in canvas){d.Draw();d.Move(2,3);}}}
