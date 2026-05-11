// Program 261: Product Catalog with LINQ
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class Product{public string Name,Category;public double Price;}
class Program{static void Main(){
    var products=new List<Product>{
        new Product{Name="Laptop",Category="Electronics",Price=75000},
        new Product{Name="Phone",Category="Electronics",Price=30000},
        new Product{Name="Shirt",Category="Clothing",Price=1200},
        new Product{Name="Jeans",Category="Clothing",Price=2500}};
    var byCategory=products.GroupBy(p=>p.Category);
    foreach(var g in byCategory){Console.WriteLine(g.Key+":");foreach(var p in g)Console.WriteLine($"  {p.Name}: Rs.{p.Price:F2}");}
    Console.WriteLine("Cheapest: "+products.OrderBy(p=>p.Price).First().Name);
}}
