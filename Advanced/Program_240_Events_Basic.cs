// Program 240: Events Basic
// Category: Advanced

using System;
class Button{
    public event Action Clicked;
    public void Click(){Console.WriteLine("Button clicked!");Clicked?.Invoke();}
}
class Program{static void Main(){
    var btn=new Button();
    btn.Clicked+=()=>Console.WriteLine("Handler 1: Alert shown!");
    btn.Clicked+=()=>Console.WriteLine("Handler 2: Log written!");
    btn.Click();
}}
