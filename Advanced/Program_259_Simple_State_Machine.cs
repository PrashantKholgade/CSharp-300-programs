// Program 259: Simple State Machine
// Category: Advanced

using System;
enum TrafficState{Red,Green,Yellow}
class TrafficLight{
    TrafficState state=TrafficState.Red;
    public void Next(){state=state==TrafficState.Red?TrafficState.Green:state==TrafficState.Green?TrafficState.Yellow:TrafficState.Red;}
    public void Show()=>Console.WriteLine("Light: "+state);
}
class Program{static void Main(){var tl=new TrafficLight();for(int i=0;i<6;i++){tl.Show();tl.Next();}}}
