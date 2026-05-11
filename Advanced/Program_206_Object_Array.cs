// Program 206: Object Array
// Category: Advanced

using System;
class Car{public string Brand;public int Year;public Car(string b,int y){Brand=b;Year=y;}}
class Program{static void Main(){
    Car[] cars={new Car("Toyota",2020),new Car("Honda",2019),new Car("Ford",2022)};
    foreach(var c in cars)Console.WriteLine(c.Brand+" ("+c.Year+")");
}}
