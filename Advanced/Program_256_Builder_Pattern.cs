// Program 256: Builder Pattern
// Category: Advanced

using System;
class Pizza{public string Size,Crust,Topping;public override string ToString()=>$"{Size} pizza on {Crust} crust with {Topping}";}
class PizzaBuilder{Pizza p=new Pizza();public PizzaBuilder SetSize(string s){p.Size=s;return this;}public PizzaBuilder SetCrust(string c){p.Crust=c;return this;}public PizzaBuilder SetTopping(string t){p.Topping=t;return this;}public Pizza Build()=>p;}
class Program{static void Main(){var pizza=new PizzaBuilder().SetSize("Large").SetCrust("Thin").SetTopping("Mushrooms").Build();Console.WriteLine(pizza);}}
