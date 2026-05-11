// Program 209: Inheritance Animal
// Category: Advanced

using System;
class Animal{public string Name;public Animal(string n){Name=n;}public virtual void Speak()=>Console.WriteLine(Name+" makes a sound.");}
class Dog:Animal{public Dog(string n):base(n){}public override void Speak()=>Console.WriteLine(Name+" says: Woof!");}
class Cat:Animal{public Cat(string n):base(n){}public override void Speak()=>Console.WriteLine(Name+" says: Meow!");}
class Program{static void Main(){new Dog("Rex").Speak();new Cat("Kitty").Speak();}}
