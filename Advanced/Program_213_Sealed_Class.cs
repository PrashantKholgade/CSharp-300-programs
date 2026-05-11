// Program 213: Sealed Class
// Category: Advanced

using System;
class Animal{public virtual void Sound()=>Console.WriteLine("Animal sound");}
sealed class Dog:Animal{public override void Sound()=>Console.WriteLine("Woof!");}
class Program{static void Main(){Dog d=new Dog();d.Sound();Console.WriteLine("Dog is a sealed class - cannot be further inherited.");}}
