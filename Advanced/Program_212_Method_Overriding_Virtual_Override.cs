// Program 212: Method Overriding Virtual Override
// Category: Advanced

using System;
class Base{public virtual string Greet()=>"Hello from Base";}
class Derived:Base{public override string Greet()=>"Hello from Derived";}
class Program{static void Main(){Base b=new Base();Base d=new Derived();Console.WriteLine(b.Greet());Console.WriteLine(d.Greet());}}
