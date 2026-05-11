// Program 219: Explicit Interface Implementation
// Category: Advanced

using System;
interface IMetric{double GetValue();}
interface IImperial{double GetValue();}
class Distance:IMetric,IImperial{double meters;public Distance(double m){meters=m;}double IMetric.GetValue()=>meters;double IImperial.GetValue()=>meters*3.28084;}
class Program{static void Main(){Distance d=new Distance(10);Console.WriteLine("Meters: "+((IMetric)d).GetValue());Console.WriteLine("Feet: "+((IImperial)d).GetValue().ToString("F2"));}}
