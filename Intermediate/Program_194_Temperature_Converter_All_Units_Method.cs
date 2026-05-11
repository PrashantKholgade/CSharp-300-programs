// Program 194: Temperature Converter All Units Method
// Category: Intermediate

using System;
class Program {
    static double CtoF(double c) => c*9/5+32;
    static double CtoK(double c) => c+273.15;
    static double FtoC(double f) => (f-32)*5/9;
    static void Main() {
        Console.Write("Celsius: "); double c = double.Parse(Console.ReadLine());
        Console.WriteLine(c+"°C = "+CtoF(c).ToString("F2")+"°F");
        Console.WriteLine(c+"°C = "+CtoK(c).ToString("F2")+" K");
        Console.Write("Fahrenheit: "); double f = double.Parse(Console.ReadLine());
        Console.WriteLine(f+"°F = "+FtoC(f).ToString("F2")+"°C");
    }
}
