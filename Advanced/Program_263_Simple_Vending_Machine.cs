// Program 263: Simple Vending Machine
// Category: Advanced

using System;using System.Collections.Generic;
class Item{public string Name;public double Price;public int Qty;}
class VendingMachine{
    List<Item>items=new List<Item>();
    public VendingMachine(){items.Add(new Item{Name="Cola",Price=30,Qty=5});items.Add(new Item{Name="Chips",Price=20,Qty=3});}
    public void ShowMenu(){Console.WriteLine("Items:");for(int i=0;i<items.Count;i++)Console.WriteLine((i+1)+". "+items[i].Name+" Rs."+items[i].Price+" ("+items[i].Qty+")");}
    public void Buy(int idx,double paid){var it=items[idx-1];if(it.Qty==0){Console.WriteLine("Out of stock.");}else if(paid<it.Price){Console.WriteLine("Insufficient amount.");}else{it.Qty--;Console.WriteLine("Dispensing "+it.Name+". Change: Rs."+(paid-it.Price));}}
}
class Program{static void Main(){var vm=new VendingMachine();vm.ShowMenu();Console.Write("Select: ");int s=int.Parse(Console.ReadLine());Console.Write("Insert amount: ");double m=double.Parse(Console.ReadLine());vm.Buy(s,m);}}
