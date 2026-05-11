// Program 245: Simple Inventory System
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Product{public string Name;public double Price;public int Qty;}
class Program{static void Main(){
    var inv=new List<Product>{new Product{Name="Apple",Price=2.5,Qty=100},new Product{Name="Bread",Price=1.5,Qty=50},new Product{Name="Milk",Price=3.0,Qty=30}};
    Console.WriteLine("--- Inventory ---");
    foreach(var p in inv)Console.WriteLine($"{p.Name,-10} Rs.{p.Price:F2}  Qty:{p.Qty}");
    Console.WriteLine("Total value: Rs."+inv.Sum(p=>p.Price*p.Qty).ToString("F2"));
    var low=inv.Where(p=>p.Qty<60);
    Console.WriteLine("Low stock: "+string.Join(", ",low.Select(p=>p.Name)));
}}
