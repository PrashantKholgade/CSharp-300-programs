// Program 217: Multiple Interfaces
// Category: Advanced

using System;
interface IPrintable{void Print();}
interface ISaveable{void Save();}
class Report:IPrintable,ISaveable{string title;public Report(string t){title=t;}public void Print()=>Console.WriteLine("Printing: "+title);public void Save()=>Console.WriteLine("Saving: "+title);}
class Program{static void Main(){var r=new Report("Annual Report");r.Print();r.Save();}}
