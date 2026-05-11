// Program 262: Simple Parking Lot System
// Category: Advanced

using System;using System.Collections.Generic;
class ParkingLot{
    int total,available;Dictionary<string,int>parked=new Dictionary<string,int>();int slot=1;
    public ParkingLot(int n){total=available=n;}
    public void Park(string plate){if(available==0){Console.WriteLine("Lot full!");return;}parked[plate]=slot++;available--;Console.WriteLine(plate+" parked at slot "+(slot-1));}
    public void Leave(string plate){if(!parked.ContainsKey(plate)){Console.WriteLine("Not found.");return;}Console.WriteLine(plate+" left slot "+parked[plate]);parked.Remove(plate);available++;}
    public void Status()=>Console.WriteLine($"Total:{total} Available:{available} Occupied:{total-available}");
}
class Program{static void Main(){var lot=new ParkingLot(3);lot.Park("MH01AB1234");lot.Park("MH02CD5678");lot.Status();lot.Leave("MH01AB1234");lot.Status();}}
