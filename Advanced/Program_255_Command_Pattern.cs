// Program 255: Command Pattern
// Category: Advanced

using System;using System.Collections.Generic;
interface ICommand{void Execute();void Undo();}
class Light{bool on;public void TurnOn(){on=true;Console.WriteLine("Light ON");}public void TurnOff(){on=false;Console.WriteLine("Light OFF");}}
class TurnOnCmd:ICommand{Light l;public TurnOnCmd(Light x){l=x;}public void Execute()=>l.TurnOn();public void Undo()=>l.TurnOff();}
class TurnOffCmd:ICommand{Light l;public TurnOffCmd(Light x){l=x;}public void Execute()=>l.TurnOff();public void Undo()=>l.TurnOn();}
class Program{static void Main(){var light=new Light();ICommand on=new TurnOnCmd(light),off=new TurnOffCmd(light);on.Execute();off.Execute();Console.WriteLine("Undo:");off.Undo();}}
