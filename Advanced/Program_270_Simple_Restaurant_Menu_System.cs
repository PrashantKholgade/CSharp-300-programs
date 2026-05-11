// Program 270: Simple Restaurant Menu System
// Category: Advanced

using System;using System.Collections.Generic;using System.Linq;
class MenuItem{public string Name,Category;public double Price;}
class Program{static void Main(){
    var menu=new List<MenuItem>{
        new MenuItem{Name="Burger",Category="Main",Price=150},
        new MenuItem{Name="Pizza",Category="Main",Price=250},
        new MenuItem{Name="Fries",Category="Side",Price=80},
        new MenuItem{Name="Cola",Category="Drinks",Price=60}};
    var order=new List<MenuItem>();
    Console.WriteLine("Menu:");
    for(int i=0;i<menu.Count;i++)Console.WriteLine((i+1)+". "+menu[i].Name+"  Rs."+menu[i].Price);
    Console.Write("Enter item numbers separated by space: ");
    foreach(string s in Console.ReadLine().Split(' ')){if(int.TryParse(s,out int idx)&&idx>=1&&idx<=menu.Count)order.Add(menu[idx-1]);}
    Console.WriteLine("
Your order:");
    foreach(var item in order)Console.WriteLine("  "+item.Name+"  Rs."+item.Price);
    Console.WriteLine("Total: Rs."+order.Sum(x=>x.Price));
}}
