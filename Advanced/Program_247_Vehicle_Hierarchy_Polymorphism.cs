// Program 247: Vehicle Hierarchy Polymorphism
// Category: Advanced

using System;
abstract class Vehicle{public string Brand;public int Speed;public Vehicle(string b,int s){Brand=b;Speed=s;}public abstract string FuelType();public override string ToString()=>$"{Brand} | Speed:{Speed}km/h | Fuel:{FuelType()}";}
class Car:Vehicle{public Car(string b,int s):base(b,s){}public override string FuelType()=>"Petrol";}
class ElectricCar:Vehicle{public ElectricCar(string b,int s):base(b,s){}public override string FuelType()=>"Electric";}
class Bicycle:Vehicle{public Bicycle(string b,int s):base(b,s){}public override string FuelType()=>"Human Power";}
class Program{static void Main(){Vehicle[]v={new Car("Toyota",180),new ElectricCar("Tesla",250),new Bicycle("Trek",30)};foreach(var x in v)Console.WriteLine(x);}}
