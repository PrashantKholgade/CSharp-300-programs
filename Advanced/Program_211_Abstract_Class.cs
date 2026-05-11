// Program 211: Abstract Class
// Category: Advanced

using System;
abstract class Vehicle{public string Brand;public Vehicle(string b){Brand=b;}public abstract void StartEngine();public void Display()=>Console.WriteLine("Brand: "+Brand);}
class Car:Vehicle{public Car(string b):base(b){}public override void StartEngine()=>Console.WriteLine(Brand+": Vroom!");}
class Bike:Vehicle{public Bike(string b):base(b){}public override void StartEngine()=>Console.WriteLine(Brand+": Braaap!");}
class Program{static void Main(){Vehicle[]v={new Car("Toyota"),new Bike("Yamaha")};foreach(var x in v){x.Display();x.StartEngine();}}}
