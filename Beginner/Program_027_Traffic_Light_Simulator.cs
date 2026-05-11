// Program 27: Traffic Light Simulator
// Category: Beginner

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter traffic light color (Red/Yellow/Green): ");
        string color = Console.ReadLine().Trim().ToLower();
        switch (color)
        {
            case "red":    Console.WriteLine("STOP");    break;
            case "yellow": Console.WriteLine("READY");   break;
            case "green":  Console.WriteLine("GO");      break;
            default:       Console.WriteLine("Unknown signal."); break;
        }
    }
}
