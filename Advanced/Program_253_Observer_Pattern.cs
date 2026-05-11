// Program 253: Observer Pattern
// Category: Advanced

using System;using System.Collections.Generic;
interface IObserver{void Update(string msg);}
class EventSystem{List<IObserver>obs=new List<IObserver>();public void Subscribe(IObserver o)=>obs.Add(o);public void Notify(string msg){foreach(var o in obs)o.Update(msg);}}
class Logger:IObserver{public void Update(string msg)=>Console.WriteLine("[LOG] "+msg);}
class Emailer:IObserver{public void Update(string msg)=>Console.WriteLine("[MAIL] "+msg);}
class Program{static void Main(){var ev=new EventSystem();ev.Subscribe(new Logger());ev.Subscribe(new Emailer());ev.Notify("User logged in");ev.Notify("Order placed");}}
