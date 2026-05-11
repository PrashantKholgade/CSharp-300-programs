// Program 276: Event Driven Temperature Alert
// Category: Advanced

using System;
class Thermometer{
    double temp;
    public event Action<double>HighAlert;
    public event Action<double>LowAlert;
    public void SetTemperature(double t){temp=t;if(t>37.5)HighAlert?.Invoke(t);if(t<35.0)LowAlert?.Invoke(t);}
}
class Program{static void Main(){var th=new Thermometer();th.HighAlert+=t=>Console.WriteLine("HIGH TEMP ALERT: "+t+"°C!");th.LowAlert+=t=>Console.WriteLine("LOW TEMP ALERT: "+t+"°C!");th.SetTemperature(36.6);th.SetTemperature(38.2);th.SetTemperature(34.5);}}
